using HRIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Maintenance.Department
{
    public interface IDeparmentView
    {
        void DisplayDepartment(List<Models.Department> departments);
    }
}
