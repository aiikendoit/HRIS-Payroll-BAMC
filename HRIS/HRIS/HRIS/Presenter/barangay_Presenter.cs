using HRIS.Models;
using HRIS.Views.Forms.Maintenance.AddressFolder.Barangay;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class barangay_Presenter
    {
        private readonly IBarangayView _view;
        private readonly HrisContext _context;
        public barangay_Presenter(IBarangayView view)
        {
            _view = view;
            _context = new HrisContext();
        }
        public void loadBarangays(int? towncityid)
        {
            var p = _context.Barangays
                .Where(e => e.FkTownCity == towncityid)
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
        public void LoadAllBarangay( DataGridView dataGridView)
        {
            var p = _context.Barangays.ToList();
            dataGridView.DataSource = p;
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
            var existingBrgy = _context.Barangays.Find(barangay.PkBarangay);

            if (existingBrgy != null)
            {
                _context.Entry(existingBrgy).State = EntityState.Detached;
                _context.Entry(barangay).State = EntityState.Modified;
                _context.Update(barangay);
                _context.SaveChanges();
                MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                MessageBox.Show("Barangay not found");
            }
        }
    }
}
