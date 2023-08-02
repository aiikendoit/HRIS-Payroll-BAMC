using HRIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Maintenance.Employment
{
    public interface IEmploymentTypeView
    {
        void DisplayEmployment(List<Models.Employmenttype> employments);
    }
}
