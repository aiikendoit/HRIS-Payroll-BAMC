using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIS.Models;
using HRIS.Views.Forms.Employee.Disciplinary_Action;
using Microsoft.EntityFrameworkCore;

namespace HRIS.Presenter
{
    public class EmployeeDisciplinary_presenter
    {
        private readonly IEmployeeDisciplinaryActionView empDA_view;
        private readonly HrisContext _dbcontext;
        private List<object> empDAListObject;
        private List<Employeedisciplinary> empDA_ListData;

        public EmployeeDisciplinary_presenter(IEmployeeDisciplinaryActionView view)
        {
            empDA_view = view;
            _dbcontext = new HrisContext();
            empDAListObject = new List<object>();


        }

        public void loadEmpDscActAll() //retrieve all data
        {
            var q = _dbcontext.Employeedisciplinaries
                .OrderBy(e => e.Description)
                .ToList();
            empDA_ListData = q.ToList();
            empDA_view.DisplayEmployeeDscAct_All(q);
        }

        public void loadEmpDiscAcWhere(int PKEmployeeId) // join query
        {
            //var query = from e2 in _dbcontext.Employeedisciplinaries
            //            join employee in _dbcontext.Employees on e2.FkEmployee equals employee.PkEmployee
            //            join d in _dbcontext.Disciplinarytypes on e2.FkDisciplinarytype equals d.PkDisciplinarytype
            //            join o in _dbcontext.Offensetypes on e2.FkOffensetype equals o.PkOffensetype
            //            select new
            //            {
            //                e2.PkEmployeedisciplinary,
            //                e2.FkEmployee,
            //                e2.FkOffensetype,
            //                e2.FkDisciplinarytype,
            //                employee.Lastname,
            //                employee.Firstname,
            //                o.Description,
            //                d.Disciplinarytypename,
            //                d.Disciplinarydescription
            //            };

            var query = from e in _dbcontext.Employeedisciplinaries
                         //join e2 in _dbcontext.Employees on e.FkEmployee equals e2.PkEmployee
                         join d in _dbcontext.Disciplinarytypes on e.FkDisciplinarytype equals d.PkDisciplinarytype
                         join o in _dbcontext.Offensetypes on e.FkOffensetype equals o.PkOffensetype
                         where e.FkEmployee == PKEmployeeId
                         select new
                         {
                             e.PkEmployeedisciplinary,
                             fk_employee = e.FkEmployee,
                             FK_offensetype = o.Description,
                             FK_disciplinarytype = d.Disciplinarytypename,
                             //o.Description,
                             //d.Disciplinarytypename,
                             e.Description,
                             e.Datestart,
                             e.Dateend,
                             e.File,
                             e.Createddate,
                             e.Createdby
                         };

            empDAListObject = query.ToList<object>();
            empDA_view.displayEmployeeDscAct_ListObject(empDAListObject);
        }

        internal void SearchData(string searchQuery) //search text box
        {
            var searchResults = empDA_ListData
                 .Where(b => b.PkEmployeedisciplinary.ToString().Contains(searchQuery)
                 || (b.Description != null && b.Description.Contains(searchQuery,
                 StringComparison.OrdinalIgnoreCase)))
                 .ToList();

            empDA_view.DisplayEmployeeDscAct_All(searchResults);
        }

        public void AddEmplDiscAct(Employeedisciplinary employeedisciplinary) //add method
        {
            _dbcontext.Employeedisciplinaries.Add(employeedisciplinary);
            _dbcontext.SaveChanges();
            MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadEmpDscActAll();
        }

        public void UpdateEmpDiscAct(Employeedisciplinary employeedisciplinary) //update method
        {
            _dbcontext.Employeedisciplinaries.Update(employeedisciplinary);
            _dbcontext.SaveChanges();
            MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadEmpDscActAll();
        }
    }
}
