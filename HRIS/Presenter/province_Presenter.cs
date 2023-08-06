using HRIS.Models;
using HRIS.Views.Forms.Maintenance.AddressFolder.ProvincesFolder;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class province_Presenter
    {
        private readonly IProvinceView _view;
        private readonly HrisContext _context;
        private List<Province> _provinceListData;
        public province_Presenter(IProvinceView view)
        {
            _view = view;
            _context = new HrisContext();
            _provinceListData = new List<Province>();
        }
        public void loadProvince()
        {
            var p = _context.Provinces
                 .OrderBy(e => e.Description)
                 .ToList();
            _provinceListData = p;
            _view.DisplayProvinces(p);
        }
        public void loadProvincewhere(int provinceid)
        {
            var p = _context.Provinces
                .Where(e => e.PkProvince == provinceid)
                 .OrderBy(e => e.Description)
                 .ToList();
            _view.DisplayProvinces(p);
        }
        public void AddProvinces(Province province)
        {
            _context.Provinces.Add(province);
            _context.SaveChanges();
            MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadProvince();
        }
        public void UpdateProvince(Province province)
        {
            _context.Provinces.Update(province);
            _context.SaveChanges();
            MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadProvince();
        }
        public void SearchData(string searchQuery)
        {
            var searchResults = _provinceListData
                 .Where(b => b.PkProvince.ToString().Contains(searchQuery)
                 || (b.Description != null && b.Description.Contains(searchQuery,
                 StringComparison.OrdinalIgnoreCase)))
                 .ToList();

            _view.DisplayProvinces(searchResults);
        }

    }
}
