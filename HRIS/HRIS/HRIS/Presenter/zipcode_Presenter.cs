using HRIS.Models;
using HRIS.Views.Forms.Maintenance.AddressFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class zipcode_Presenter
    {
        private readonly IZipcodeView _view;
        private readonly HrisContext _context;
        public zipcode_Presenter(IZipcodeView view)
        {
            _view = view;
            _context = new HrisContext();
        }
        public void loadZipcode(int? towncityid)
        {
            var p = _context.Zipcodes
                 .Where(e => e.FkTowncity == towncityid)
                 .OrderBy(e => e.Description)
                 .ToList();
            _view.DisplayZipcode(p);
        }
    }
}
