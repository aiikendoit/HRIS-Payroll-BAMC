using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIS.Forms.Employee.Documents;
using HRIS.Models;
using HRIS.Views.Forms.Employee;
using HRIS.Views.Forms.Employee.Documents;
using Microsoft.EntityFrameworkCore;

namespace HRIS.Presenter
{
    public class EmployeeDocument_Presenter
    {
        
        private readonly IEmployeeDocumentView _view;
        private readonly HrisContext _context;
        private List<object> employeeDocumentList;
        private List<Employeedocument> employeeDocumentsListData;


        public EmployeeDocument_Presenter(IEmployeeDocumentView view) 
        {
            _view = view;
            _context = new HrisContext();
            employeeDocumentList = new List<object>();
        }
        public void add_EmployeeDocs(Employeedocument employeedocument)
        {
            try
            {
                _context.Employeedocuments.Add(employeedocument);
                _context.SaveChanges();
            }
            catch (Exception x) 
            {
                MessageBox.Show(x.InnerException.ToString());
            }
        }

        public void loadEmployeeDocsDetails(int PKEmployeeid)
        {
            var query = from d in _context.Doctypes
                        join e in _context.Employeedocuments on d.PkDoctype equals e.FkDoctype
                        //join e2 in _context.Employees on e.FkEmployee equals e2.PkEmployee
                        where e.FkEmployee == PKEmployeeid
                        select new
                        {
                           pk_employeedocument =  e.PkEmployeedocument,
                           fk_employee =  e.FkEmployee,
                            fk_doctype = d.PkDoctype,
//                            e2.Lastname,
                            //d.Description,
                           e.Description,
                            remarks = e.Remarks,
                            employeedocs =  e.EmployeeDocs,
                            createddate = e.Createddate,
                            createdby = e.Createdby,
                            fk_systeuser = e.FkSystemUser
                        };
            employeeDocumentList = query.ToList<object>();//error
            _view.DisplayEmployeeDocumentsData(employeeDocumentList);
        }

        public void loadEmployeeDocs(int pk_employeedocument) 
        {
            var p = _context.Employeedocuments.Where(c => c.PkEmployeedocument == pk_employeedocument)
                .ToList();
            _view.DisplayEmployeeDocuments(p);
        }

        internal void SearchData(string searchQuery)
        {
            //var searchResults = employeeDocumentList
            //     .Where(b => b.PkEmployeedocument.ToString().Contains(searchQuery)
            //     || (b.Description != null && b.Description.Contains(searchQuery,
            //     StringComparison.OrdinalIgnoreCase)))
            //     .ToList();

            //_view.DisplayEmployeeDocuments(searchResults);
        }

        public void updateEmployeeDocs(Employeedocument employeedocument)
        {
            var empDocsUpdate = _context.Employeedocuments.Find(employeedocument.PkEmployeedocument);

            if (empDocsUpdate != null)
            {
                _context.Entry(empDocsUpdate).State = EntityState.Detached;
                _context.Entry(employeedocument).State = EntityState.Modified;
                _context.SaveChanges();
                MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
