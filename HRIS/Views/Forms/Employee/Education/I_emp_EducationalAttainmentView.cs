using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Employee.Education
{
    public interface I_emp_EducationalAttainmentView
    {
        void DisplayEmployeeEducAttainment(List<Models.Educationalattainment> employee_educAttainment);
    }
}
