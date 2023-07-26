using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Maintenance.Bank
{
    public interface IBankView
    {
        void DisplayBank(List<Models.BankName> banks);
    }
}
