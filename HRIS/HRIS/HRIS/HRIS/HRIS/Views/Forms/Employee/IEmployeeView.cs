using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Employee
{
    public interface IEmployeeView
    {
        void DisplayEmployee(List<Models.Employee> employees);
        void DisplayEmployeeAllDetails(List<Models.Employee> employees);
    }
}
