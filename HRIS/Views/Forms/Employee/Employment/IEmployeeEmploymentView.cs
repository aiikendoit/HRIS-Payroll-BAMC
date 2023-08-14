using HRIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Employee.Employment
{
    public interface IEmployeeEmploymentView
    {
        void DisplayEmployeeEmploymentCustom(List<object> employment);
        void DisplayEmployeeEmploymentAll(List<Employmentstatus> employmentstatuses);
    }
}
