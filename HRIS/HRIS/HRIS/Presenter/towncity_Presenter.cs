using HRIS.Models;
using HRIS.Views.Forms.Maintenance.AddressFolder.TownCityFolder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class towncity_Presenter
    {
        
        private readonly ITownCityView _view;
        private readonly HrisContext _context;
        public towncity_Presenter(ITownCityView view)
        {
            _view = view;
            _context = new HrisContext();
        }
        public void loadTowncity(int? provinceid)
        {
            var p = _context.Towncities
                .Where(e => e.FkProvince == provinceid) 
                .OrderBy(e => e.Description) 
                .ToList();
            _view.DisplayTownCity(p);
        }
    }
}
