using HRIS.Models;
using HRIS.Views.Forms.Maintenance.Bank;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using Microsoft.EntityFrameworkCore;
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
<<<<<<< HEAD
            var existingBankname = _context.BankNames.Find(bank.PkBankName);
            if (existingBankname != null)
            {
                _context.Entry(existingBankname).State = EntityState.Detached;
                _context.Entry(bank).State = EntityState.Modified;
                _context.SaveChanges();
               //MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
=======
            var existingbank = _context.BankNames.Find(bank.PkBankName);

            if (existingbank != null)
            {
                _context.Entry(existingbank).State = EntityState.Detached;
                _context.Entry(bank).State = EntityState.Modified;
                _context.BankNames.Update(bank);
                _context.SaveChanges();
                MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
            }
            else
            {
                MessageBox.Show("Workassignment not found");
            }
<<<<<<< HEAD

            //_context.BankNames.Update(bank);
            //_context.SaveChanges();
            //LoadBank();
=======
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
        }
    }
}
