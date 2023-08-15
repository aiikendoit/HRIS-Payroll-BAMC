using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIS.Models;

namespace HRIS.Views.Forms.Employee.Documents
{
    public interface IEmployeeDocumentView
    {
        void DisplayEmployees(List<Employeedocument> Employeedocuments);
        //void ClearFields();
    }
}
