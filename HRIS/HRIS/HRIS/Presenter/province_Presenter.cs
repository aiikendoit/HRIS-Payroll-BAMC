using HRIS.Models;
using HRIS.Views.Forms.Maintenance.AddressFolder.ProvincesFolder;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class province_Presenter
    {
        private readonly IProvinceView _view;
        private readonly HrisContext _context;
        public province_Presenter(IProvinceView view)
        {
            _view = view;
            _context = new HrisContext();
        }
        public void loadProvince(int? regionid)
        {
            var p = _context.Provinces
                 .Where(e => e.FkRegion == regionid)
                 .OrderBy(e => e.Description)
                 .ToList();
            _view.DisplayProvinces(p);
        }
        
    }
}
