using HRIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Maintenance.Leaves
{
    public interface ILeaveTypeView
    {
        void DisplayLeavetype(List<Leavetype> leavetypeList);
    }
}
