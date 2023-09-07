using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Maintenance.WageFactor
{
    public interface IWageFactorView
    {
        void DisplayWageFactor(List<Models.Wagefactor> wageFactorList);
    }
}
