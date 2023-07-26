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
        private readonly INationalityView _nationalityView;
        private readonly HrisContext _context;

        public nationality_Presenter(INationalityView view)
        {
            _nationalityView = view;
            _context = new HrisContext();
        }
        public void loadNationality()
        {
            var p = _context.Nationalities.ToList();
            _nationalityView.DisplayNationality(p);
        }
        public void AddNationality(Nationality nationality)
        {
            _context.Nationalities.Add(nationality);
            _context.SaveChanges();
            _nationalityView.ClearFields();
            loadNationality();
        }
        public void UpdateNationality(Nationality nationality)
        {
            _context.Nationalities.Update(nationality);
            _context.SaveChanges();
            _nationalityView.ClearFields();
            loadNationality();
        }
        public void DeleteNationality(Nationality nationality)
        {
            _context.Nationalities.Remove(nationality);
            _context.SaveChanges();
            _nationalityView.ClearFields();
            loadNationality();
        }

    }
}
