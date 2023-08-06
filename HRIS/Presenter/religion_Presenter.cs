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
        private List<Religion> religionsData;
        public religion_Presenter(IReligionView view)
        {
            _religionview = view;
            _context = new HrisContext();
            religionsData = new List<Religion>();
        }
        public void LoadReligion()
        {
            var p = _context.Religions.ToList();
            religionsData = p;
            _religionview.DisplayReligion(p);
        }

        public bool AddReligion(Religion religion)
        {
            bool isexist = false;
            if (!_context.Religions.Any(r => r.Description == religion.Description))
            {
                _context.Religions.Add(religion);
                _context.SaveChanges();
                MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _religionview.ClearFields();
            }
            else
            {
                isexist = true;
                MessageBox.Show("Religion already existed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
               
            LoadReligion();
            return isexist;
        }

        public void UpdateReligion(Religion religion)
        {

            _context.Religions.Update(religion);
            _context.SaveChanges();
            MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _religionview.ClearFields();
            LoadReligion();
        }
        public void SearchData(string searchQuery)
        {
            var searchResults = religionsData
                 .Where(b => b.PkReligion.ToString().Contains(searchQuery)
                 || (b.Description != null && b.Description.Contains(searchQuery,
                 StringComparison.OrdinalIgnoreCase)))
                 .ToList();

            _religionview.DisplayReligion(searchResults);
        }

    }
}
