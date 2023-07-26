using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Maintenance.AddressFolder.RegionFolder
{
    public interface IRegionView
    {
        void DisplayRegion(List<Models.Region> Regions);
        
    }
}
