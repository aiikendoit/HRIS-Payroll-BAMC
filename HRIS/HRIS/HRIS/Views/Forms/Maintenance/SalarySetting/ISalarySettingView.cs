using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Maintenance.SalarySetting
{
    public interface ISalarySettingView
    {
        void DisplaySalarysetting(List<Models.Salarytype> salarytypes);
    }
}
