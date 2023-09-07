using HRIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Userlogin
{
    public interface ISysemUsers
    {
        void DisplaySystemUsers(List<SystemUser> SystemUsers);
        void DisplayUserCustom(List<object> systemuser);
    }
}
