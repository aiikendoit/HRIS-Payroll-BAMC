using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Employee.License_information
{
    public interface IEmployeelicenseInformationView
    {
        void DisplayLicenseInformation(List<Models.Employeelicense> employeelicenses);
        void DisplaylicenseInfoCustom(List<object> licenseInfo);
    }
}
