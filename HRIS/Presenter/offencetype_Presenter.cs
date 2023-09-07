using HRIS.Models;
using HRIS.Views.Forms.Maintenance.Degreetype;
using HRIS.Views.Forms.Maintenance.Offensetype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class offencetype_Presenter
    {
        private readonly IOffenceTypeView _view;
        private readonly HrisContext _context;
        private List<Offensetype> offensetypesData;

        public offencetype_Presenter(IOffenceTypeView view)
        {
            _view = view;
            _context = new HrisContext();
            offensetypesData = new List<Offensetype>();
        }
        public void LoadOffensetype()
        {
            var p = _context.Offensetypes.ToList();
            offensetypesData = p;
            _view.DisplayOffencetype(p);
        }
        public void AddOffencetype(Offensetype offensetype)
        {
            _context.Offensetypes.Add(offensetype);
            _context.SaveChanges();
            MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadOffensetype();
        }
        public void updateOffencetype(Offensetype offensetype)
        {
            _context.Offensetypes.Update(offensetype);
            _context.SaveChanges();
            MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadOffensetype();
        }
        public void SearchData(string searchQuery)
        {
            var searchResults = offensetypesData
                 .Where(b => b.PkOffensetype.ToString().Contains(searchQuery)
                 || (b.Description != null && b.Description.Contains(searchQuery,
                 StringComparison.OrdinalIgnoreCase)))
                 .ToList();

            _view.DisplayOffencetype(searchResults);
        }
    }
}
