using HRIS.Models;
using HRIS.Views.Forms.Employee;
using HRIS.Views.Forms.Userlogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class userlogin_Presenter
    {
        private readonly ISysemUsers _view;
        private readonly HrisContext _context;
        private List<object> employeesData;
        public userlogin_Presenter(ISysemUsers view)
        {
            _view = view;
            _context = new HrisContext();
            employeesData = new List<object>();
        }
        public void loadlogin(string usercode )
        {
            var query = from login in _context.SystemUsers
                        join emp in _context.Employees on login.FkEmployee equals emp.PkEmployee
                        where login.Usercode == usercode
                        select new
                        {
                            idno = emp.Idno,
                            completename = emp.Firstname + " " + emp.Middlename + " " + emp.Lastname,
                            profilepicture = emp.ProfilePicture,
                            usercode = login.Usercode,
                            password = login.Userpass
                        };

            employeesData = query.ToList<object>();
            _view.DisplayUserCustom(employeesData);
        }
    }
}
