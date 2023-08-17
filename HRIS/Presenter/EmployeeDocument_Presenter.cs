using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private List<object> employeeDocument;
        
        
        public EmployeeDocument_Presenter(IEmployeeDocumentView view) 
        {
            _view = view;
            _context = new HrisContext();
            employeeDocument = new List<object>();
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
                            fk_doctype = e.FkDoctype,
//                            e2.Lastname,
                            //d.Description,
                           e.Description,
                            remarks = e.Remarks,
                            //employeedocs =  e.EmployeeDocs,
                            createddate = e.Createddate,
                            createdby = e.Createdby,
                            fk_systeuser = e.FkSystemUser
                        };
            employeeDocument = query.ToList<object>();//error
            _view.DisplayEmployeeDocumentsData(employeeDocument);
        }
    }
}
