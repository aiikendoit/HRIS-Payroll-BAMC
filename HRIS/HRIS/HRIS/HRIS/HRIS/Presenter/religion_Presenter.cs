using HRIS.Models;
using HRIS.Views.Forms.Maintenance.ReligionFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    
    public class religion_Presenter
    {
        private readonly IReligionView _religionview;
        private readonly HrisContext _context;
        public religion_Presenter(IReligionView view)
        {
            _religionview = view;
            _context = new HrisContext();
        }
        public void LoadReligion()
        {
            var p = _context.Religions.ToList();
            _religionview.DisplayReligion(p);
        }

        public void AddReligion(Religion religion)
        {
            _context.Religions.Add(religion);
            _context.SaveChanges();
            _religionview.ClearFields();
            LoadReligion();
        }

        public void UpdateReligion(Religion religion)
        {

            _context.Religions.Update(religion);
            _context.SaveChanges();
            _religionview.ClearFields();
            LoadReligion();
        }

        public void DeleteReligion(Religion religion)
        {
            _context.Religions.Remove(religion);
            _context.SaveChanges();
            _religionview.ClearFields();
            LoadReligion();
        }
    }
}
