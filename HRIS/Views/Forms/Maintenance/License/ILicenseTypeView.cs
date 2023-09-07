using HRIS.Forms.Maintenance.License;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Maintenance.License
{
    public interface ILicenseTypeView
    {
        void DisplayLicensetype(List<Models.Licensetype> licenseTypes);
    }
}
