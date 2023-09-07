using HRIS.Models;
using HRIS.Views.Forms.Maintenance.Degreetype;
using HRIS.Views.Forms.Maintenance.WageFactor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class wagefactor_Presenter
    {
        private readonly IWageFactorView _view;
        private readonly HrisContext _context;
        private List<Wagefactor> wagefactorsData;

        public wagefactor_Presenter(IWageFactorView view)
        {
            _view = view;
            _context = new HrisContext();
            wagefactorsData = new List<Wagefactor>();
        }
        public void LoadWagefactor()
        {
            var p = _context.Wagefactors.ToList();
            wagefactorsData = p;
            _view.DisplayWageFactor(p);
        }
        public void AddWageFactor(Wagefactor wagefactor)
        {
            _context.Wagefactors.Add(wagefactor);
            _context.SaveChanges();
            MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadWagefactor();
        }
        public void UpdateWageFactor(Wagefactor wagefactor)
        {
            _context.Wagefactors.Update(wagefactor);
            _context.SaveChanges();
            MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadWagefactor();
        }
        public void SearchData(string searchQuery)
        {
            var searchResults = wagefactorsData
                 .Where(b => b.PkWagefactor.ToString().Contains(searchQuery)
                 || (b.Amount != null && b.Amount.ToString().Contains(searchQuery,
                 StringComparison.OrdinalIgnoreCase)))
                 .ToList();

            _view.DisplayWageFactor(searchResults);
        }
    }
}
