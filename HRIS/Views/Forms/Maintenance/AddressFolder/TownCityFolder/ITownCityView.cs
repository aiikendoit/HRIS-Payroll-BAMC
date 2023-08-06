using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Maintenance.AddressFolder.TownCityFolder
{
    public interface ITownCityView
    {
        void DisplayTownCity(List<Models.Towncity> Towncities);
        void DisplayProvince(int provinces);
        void ClearFields();
    }
}
