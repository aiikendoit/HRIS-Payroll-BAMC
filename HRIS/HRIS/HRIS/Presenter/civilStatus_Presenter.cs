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
        private List<Civilstatus> civilstatusdata;

        public civilStatus_Presenter(ICivilStatusView view)
        {
            _view = view;
            _context = new HrisContext();
            civilstatusdata = new List<Civilstatus>();
        }
        public void LoadCivilStatus()
        {
            var p = _context.Civilstatuses.ToList();
            civilstatusdata = p;
            _view.DisplayCivilStatus(p);
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
        public void SearchData(string searchQuery)
        {
            var searchResults = civilstatusdata
                 .Where(b => b.PkCivilstatus.ToString().Contains(searchQuery)
                 || (b.Description != null && b.Description.Contains(searchQuery,
                 StringComparison.OrdinalIgnoreCase)))
                 .ToList();

            _view.DisplayCivilStatus(searchResults);
        }


    }
}
