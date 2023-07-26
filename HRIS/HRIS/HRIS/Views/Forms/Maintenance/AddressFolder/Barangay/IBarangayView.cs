using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Maintenance.AddressFolder.Barangay
{
    public interface IBarangayView
    {
        void DisplayBarangay(List<Models.Barangay> Barangays);
        void clearfields();
    }
}
