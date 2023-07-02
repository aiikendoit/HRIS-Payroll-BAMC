using HRIS.Models;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace HRIS.Presenter
{
    public class civilStatus_Presenter
    {
        private readonly ICivilStatusView _view;
        private readonly HrisContext _context;

        public civilStatus_Presenter(ICivilStatusView view)
        {
            _view = view;
            _context = new HrisContext();
        }
        public void LoadCivilStatus()
        {
            var p = _context.Civilstatuses.ToList();
            _view.DisplayEmployees(p);
        }

        public void AddCivilStatus(Civilstatus civilstatus)
        {
            _context.Civilstatuses.Add(civilstatus);
            _context.SaveChanges();
            _view.ClearFields();
            LoadCivilStatus();
        }

        public void UpdateCivilStatus(Civilstatus civilstatus)
        {
            
            _context.Civilstatuses.Update(civilstatus);
            _context.SaveChanges();
            _view.ClearFields();
            LoadCivilStatus();
        }

        public void DeleteCivilStatus(Civilstatus civilstatus)
        {
            _context.Civilstatuses.Remove(civilstatus);
            _context.SaveChanges();
            _view.ClearFields();
            LoadCivilStatus();
        }

       
    }
}
