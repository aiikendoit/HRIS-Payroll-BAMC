using HRIS.Models;
using HRIS.Views.Forms.Maintenance.Degreetype;
using HRIS.Views.Forms.Maintenance.License;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class licensetype_Presenter
    {
        private readonly ILicenseTypeView _view;
        private readonly HrisContext _context;
        private List<Models.Licensetype> licensetypesData;

        public licensetype_Presenter(ILicenseTypeView view)
        {
            _view = view;
            _context = new HrisContext();
            licensetypesData = new List<Models.Licensetype>();
        }
        public void LoadLicentype()
        {
            var p = _context.Licensetypes.ToList();
            licensetypesData = p;
            _view.DisplayLicensetype(p);
        }
        public void Addlicensetype(Licensetype licensetype)
        {
            _context.Licensetypes.Add(licensetype);
            _context.SaveChanges();
            MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadLicentype();
        }
        public void UpdateLicense(Licensetype licensetype)
        {
            _context.Licensetypes.Update(licensetype);
            _context.SaveChanges();
            MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadLicentype();
        }
        public void SearchData(string searchQuery)
        {
            var searchResults = licensetypesData
                 .Where(b => b.PkLicensetype.ToString().Contains(searchQuery)
                 || (b.Description != null && b.Description.Contains(searchQuery,
                 StringComparison.OrdinalIgnoreCase)))
                 .ToList();

            _view.DisplayLicensetype(searchResults);
        }
    }
}
