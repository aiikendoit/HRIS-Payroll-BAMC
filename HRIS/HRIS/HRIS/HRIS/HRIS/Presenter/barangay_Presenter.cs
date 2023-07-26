using HRIS.Models;
using HRIS.Views.Forms.Maintenance.AddressFolder.Barangay;
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
    }
}
