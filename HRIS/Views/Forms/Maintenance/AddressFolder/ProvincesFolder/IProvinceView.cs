using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Maintenance.AddressFolder.ProvincesFolder
{
    public interface IProvinceView
    {
        void DisplayProvinces(List<Models.Province> Provinces);
        void ClearFields();
    }
}
