using HRIS.Models;
using HRIS.Views.Forms.Maintenance.Bank;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class bank_Presenter
    {
        private readonly IBankView _view;
        private readonly HrisContext _context;

        public bank_Presenter(IBankView view)
        {
            _view = view;
            _context = new HrisContext();
        }
        public void LoadBank()
        {
            var p = _context.BankNames.ToList();
            _view.DisplayBank(p);
        }
        public void AddBank(BankName bank)
        {
            _context.BankNames.Add(bank);
            _context.SaveChanges();
            LoadBank();
        }

        public void UpdateBank(BankName bank)
        {

            _context.BankNames.Update(bank);
            _context.SaveChanges();
            LoadBank();
        }
    }
}
