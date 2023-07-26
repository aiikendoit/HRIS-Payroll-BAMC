using HRIS.Models;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using HRIS.Views.Forms.Maintenance.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class systemUser_Presenter
    {
        private readonly IUserView _view;
        private readonly HrisContext _context;
        public systemUser_Presenter(IUserView view)
        {
            _view = view;
            _context = new HrisContext();
        }
        public void LoadSystemUser()
        {
            var p = _context.SystemUsers.ToList();
            _view.DisplaySystemUser(p);
        }

        public void AddCivilStatus(SystemUser systemUser)
        {
            _context.SystemUsers.Add(systemUser);
            _context.SaveChanges();
            _view.ClearFields();
            LoadSystemUser();
        }

        public void UpdateCivilStatus(SystemUser systemUser)
        {

            _context.SystemUsers.Update(systemUser);
            _context.SaveChanges();
            _view.ClearFields();
            LoadSystemUser();
        }

        public void DeleteCivilStatus(SystemUser systemUser)
        {
            _context.SystemUsers.Remove(systemUser);
            _context.SaveChanges();
            _view.ClearFields();
            LoadSystemUser();
        }
    }
}
