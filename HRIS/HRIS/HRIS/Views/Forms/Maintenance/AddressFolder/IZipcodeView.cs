using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Maintenance.AddressFolder
{
    public interface IZipcodeView
    {
        void DisplayZipcode(List<Models.Zipcode> Zipcodes);
    }
}
