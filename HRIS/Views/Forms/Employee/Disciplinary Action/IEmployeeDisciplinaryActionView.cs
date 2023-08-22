using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Employee.Disciplinary_Action
{
    public interface IEmployeeDisciplinaryActionView
    {
        void DisplayEmployeeDscAct(List<Models.Employeedisciplinary> employeedisciplinaries);

        void ClearFields();
    }
}
