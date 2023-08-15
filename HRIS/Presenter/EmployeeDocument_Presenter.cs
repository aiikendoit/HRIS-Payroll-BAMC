using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIS.Models;
using HRIS.Views.Forms.Employee;
using HRIS.Views.Forms.Employee.Documents;

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
    }
}
