using HRIS.Models;
using HRIS.Views.Forms.Maintenance.NationalityFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class nationality_Presenter
    {
        private readonly INationalityView _view;
        private readonly HrisContext _context;
        private List<Nationality> nationalitiesData;
        public nationality_Presenter(INationalityView view)
        {
            _view = view;
            _context = new HrisContext();
            nationalitiesData = new List<Nationality>();
        }
        public void loadNationality()
        {
            var p = _context.Nationalities.ToList();
            nationalitiesData = p;
            _view.DisplayNationality(p);
        }
        public void AddNationality(Nationality nationality)
        {
            _context.Nationalities.Add(nationality);
            _context.SaveChanges();
            _view.ClearFields();
            MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadNationality();
        }
        public void UpdateNationality(Nationality nationality)
        {
            _context.Nationalities.Update(nationality);
            _context.SaveChanges();
            MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _view.ClearFields();
            loadNationality();
        }
        public void SearchData(string searchQuery)
        {
            var searchResults = nationalitiesData
                 .Where(b => b.PkNationality.ToString().Contains(searchQuery)
                 || (b.Description != null && b.Description.Contains(searchQuery,
                 StringComparison.OrdinalIgnoreCase)))
                 .ToList();

            _view.DisplayNationality(searchResults);
        }

    }
}
