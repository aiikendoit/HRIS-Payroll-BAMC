using HRIS.Models;
using HRIS.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Employee.Leaves
{
    public interface IEmployeeLeaveSettingView
    {
        void DisplayLeavesetting(List<Leavessetting> leavessettings);
        void DisplayLeavesettingCustom(List<object> leavessettings);
    }
}
