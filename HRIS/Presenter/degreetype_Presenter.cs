using HRIS.Models;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using HRIS.Views.Forms.Maintenance.Degreetype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class degreetype_Presenter
    {
        private readonly IDegreeTypeView _view;
        private readonly HrisContext _context;
        private List<Degreetype> degreetypedata;

        public degreetype_Presenter(IDegreeTypeView view)
        {
            _view = view;
            _context = new HrisContext();
            degreetypedata = new List<Degreetype>();
        }
        public void LoadDegreeType()
        {
            var p = _context.Degreetypes.ToList();
            degreetypedata = _context.Degreetypes.ToList();
            _view.DisplayDegreetype(p);
        }
        public void AddDegreeType(Degreetype degreetype)
        {
            _context.Degreetypes.Add(degreetype);
            _context.SaveChanges();
            MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK,MessageBoxIcon.Information);
            LoadDegreeType();
        }
        public void UpdateDegreeType(Degreetype degreetype)
        {
            _context.Degreetypes.Update(degreetype);
            _context.SaveChanges();
            MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDegreeType();
        }
        public void SearchData(string searchQuery)
        {
            var searchResults = degreetypedata
                 .Where(b => b.PkDegreetype.ToString().Contains(searchQuery)
                 || (b.Description != null && b.Description.Contains(searchQuery,
                 StringComparison.OrdinalIgnoreCase)))
                 .ToList();

            _view.DisplayDegreetype(searchResults);
        }
    }
}
