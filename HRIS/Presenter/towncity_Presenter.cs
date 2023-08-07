using HRIS.Models;
using HRIS.Views.Forms.Maintenance.AddressFolder.ProvincesFolder;
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
        private List<Towncity> _TowncityListData;
        public towncity_Presenter(ITownCityView view)
        {
            _view = view;
            _context = new HrisContext();
            _TowncityListData = new List<Towncity>();
        }
        public void loadTowncity(int? provinceid)
        {
            var p = _context.Towncities
                .Where(e => e.FkProvince == provinceid) 
                .OrderBy(e => e.Description) 
                .ToList();
            
            _view.DisplayTownCity(p);
        }
        public void loadtowncityWhere(int? towncityid)
        {
            //get the foreign key of province
            int fkprovince = _context.Towncities
                .Where(e => e.PkTowncity == towncityid)
                .Select(e => e.FkProvince)
                .FirstOrDefault();
            //get all the towncity with province id
            var p = _context.Towncities
                .Where(e => e.FkProvince == fkprovince)
                .OrderBy(e => e.Description)
                .ToList();
            _view.DisplayTownCity(p);
            //get province id
            int provinceid = _context.Provinces
                .Where(e => e.PkProvince == fkprovince)
                .Select(e => e.PkProvince)
                .FirstOrDefault();
            _view.DisplayProvince(provinceid);
        }
        public void loadTownCity_All()
        {
            var p = _context.Towncities
                .OrderBy(e => e.Description)
                .ToList();
            _TowncityListData = p.ToList();
            _view.DisplayTownCity(p);
        }

        internal void SearchData(string searchQuery)
        {
            var searchResults = _TowncityListData
                 .Where(b => b.PkTowncity.ToString().Contains(searchQuery)
                 || (b.Description != null && b.Description.Contains(searchQuery,
                 StringComparison.OrdinalIgnoreCase)))
                 .ToList();

            _view.DisplayTownCity(searchResults);
        }
    }
}
