using HRIS.Models;
using HRIS.Views.Forms.Maintenance.AddressFolder.RegionFolder;
using HRIS.Views.Forms.Maintenance.AddressFolder.TownCityFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class region_Presenter
    {
        private readonly IRegionView _view;
        private readonly HrisContext _context;
        public region_Presenter(IRegionView view)
        {
            _view = view;
            _context = new HrisContext();
        }
        public void loadRegion()
        {
            var p = _context.Regions.ToList().OrderBy(e => e.Description).ToList();
            _view.DisplayRegion(p);
        }
    }
}
