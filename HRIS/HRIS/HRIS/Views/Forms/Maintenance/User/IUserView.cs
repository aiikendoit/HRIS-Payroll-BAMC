using HRIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Maintenance.User
{
    public interface IUserView
    {
        void DisplaySystemUser(List<SystemUser> SystemUsers);
        void ClearFields();
    }
}
