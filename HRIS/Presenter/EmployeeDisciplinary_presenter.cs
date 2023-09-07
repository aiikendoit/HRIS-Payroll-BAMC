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

        public void loadEmpDscActAll(int PKEmployeeId) //retrieve all data
        {
            var q = _dbcontext.Employeedisciplinaries.Where(e => e.FkEmployee == PKEmployeeId)
                .OrderBy(e => e.Description)
                .ToList();
            empDA_ListData = q.ToList();
            empDA_view.DisplayEmployeeDscAct_All(q);
        }

        public void loadEmpDiscAcWhere(int PKEmployeeId) // join query
        {

            var query = from e in _dbcontext.Employeedisciplinaries
                         //join e2 in _dbcontext.Employees on e.FkEmployee equals e2.PkEmployee
                         join d in _dbcontext.Disciplinarytypes on e.FkDisciplinarytype equals d.PkDisciplinarytype
                         join o in _dbcontext.Offensetypes on e.FkOffensetype equals o.PkOffensetype
                         where e.FkEmployee == PKEmployeeId
                         select new
                         {
                             e.PkEmployeedisciplinary,
                             fk_employee = e.FkEmployee,
                             FK_offensetype = o.Description,//error not match id
                             FK_disciplinarytype = d.Disciplinarytypename,//error not match id
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
            try
            {
                _dbcontext.Employeedisciplinaries.Add(employeedisciplinary);
                _dbcontext.SaveChanges();
                //MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.InnerException.ToString());
            }
        }

        public void UpdateEmpDiscAct(Employeedisciplinary employeedisciplinary) //update method
        {
            //_dbcontext.Employeedisciplinaries.Update(employeedisciplinary);
            //_dbcontext.SaveChanges();
            //MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //empDA_view.displayEmployeeDscAct_ListObject(empDAListObject);

            var existingEduc = _dbcontext.Employeedisciplinaries.Find(employeedisciplinary.PkEmployeedisciplinary);

            if (existingEduc != null)
            {
                _dbcontext.Entry(existingEduc).State = EntityState.Detached;//detached employeeID
                _dbcontext.Entry(employeedisciplinary).State = EntityState.Modified;
                _dbcontext.SaveChanges();
                MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void _loadEmpDscActAllWhereId(int PK_employeeDisciplinary) //retrieve all data by employee disciplnry action pk
        {
            var q = _dbcontext.Employeedisciplinaries.Where(e => e.PkEmployeedisciplinary == PK_employeeDisciplinary)
                .OrderBy(e => e.Description)
                .ToList();
            empDA_ListData = q.ToList();
            empDA_view.DisplayEmployeeDscAct_All(q);
        }
    }
}
