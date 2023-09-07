using HRIS.Models;
using HRIS.Views.Forms.Maintenance.AddressFolder.Barangay;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace HRIS.Presenter
{
    public class barangay_Presenter
    {
        private readonly IBarangayView _view;
        private readonly HrisContext _context;
        private List<Barangay> barangaydata;
        public barangay_Presenter(IBarangayView view)
        {
            _view = view;
            _context = new HrisContext();
            barangaydata = new List<Barangay>();
        }
        public void loadBarangays(int? towncityid)
        {
            var p = _context.Barangays
                .Where(e => e.FkTownCity == towncityid && e.IsActive == true)
                .OrderBy(e => e.Description)
                .ToList();
            _view.DisplayBarangay(p);
        }
        public void loadBarangaywhere(int? brgyid)
        {
            var p = _context.Barangays
                .Where(e => e.PkBarangay == brgyid)
                .OrderBy(e => e.Description)
                .ToList();
            _view.DisplayBarangay(p);
        }
        public void LoadAllBarangay()
        {
            var p = _context.Barangays.ToList();
            barangaydata = _context.Barangays.ToList();
            _view.DisplayBarangay(p);
        }
       
        public bool AddBarangay(Barangay barangay)
        {
            bool isexist = false;
            // Check if the employee already exists
            bool barangayexist = _context.Barangays.Any(e => e.Description == barangay.Description && e.FkTownCity == barangay.FkTownCity);

            if (barangayexist)
            {
                isexist = true;
                MessageBox.Show("Barangay already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _context.Barangays.Add(barangay);
                _context.SaveChanges();
                MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isexist;
        }
        public void UpdateBarangay(Barangay barangay)
        {
            
            var existingBarangay = _context.Barangays.Find(barangay.PkBarangay);

            if (existingBarangay != null)
            {
                _context.Entry(existingBarangay).State = EntityState.Detached;
                _context.Entry(barangay).State = EntityState.Modified;
                _context.Barangays.Update(barangay);
                _context.SaveChanges();
                LoadAllBarangay();
                MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("existingBarangay not found");
            }
        }
        public void SearchData(string searchQuery)
        {
            var searchResults = barangaydata
                 .Where(b => b.PkBarangay.ToString().Contains(searchQuery)
                 || (b.Description != null && b.Description.Contains(searchQuery, 
                 StringComparison.OrdinalIgnoreCase)))
                 .ToList();

            _view.DisplayBarangay(searchResults);
        }
    }
}
