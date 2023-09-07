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
        private List<Models.BankName> bankdata;
        public bank_Presenter(IBankView view)
        {
            _view = view;
            _context = new HrisContext();
            bankdata = new List<BankName>();
        }
        public void LoadBank()
        {
            var p = _context.BankNames.ToList();
            bankdata = p;
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
            var existingbank = _context.BankNames.Find(bank.PkBankName);

            if (existingbank != null)
            {
                _context.Entry(existingbank).State = EntityState.Detached;
                _context.Entry(bank).State = EntityState.Modified;
                _context.BankNames.Update(bank);
                _context.SaveChanges();
                MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Workassignment not found");
            }
        }
        public void SearchData(string searchQuery)
        {
            var searchResults = bankdata
                 .Where(b => b.PkBankName.ToString().Contains(searchQuery)
                 || (b.Bankname1 != null && b.Bankname1.Contains(searchQuery,
                 StringComparison.OrdinalIgnoreCase)))
                 .ToList();

            _view.DisplayBank(searchResults);
        }
    }
}
