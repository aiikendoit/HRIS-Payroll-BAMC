using HRIS.Models;
using HRIS.Views.Forms.Maintenance.License;
using HRIS.Views.Forms.Maintenance.SalarySetting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class salarysetting_Presenter
    {
        private readonly ISalarySettingView _view;
        private readonly HrisContext _context;
        private List<Models.Salarytype> salarytypesData;
        public salarysetting_Presenter(ISalarySettingView view)
        {
            _view = view;
            _context = new HrisContext();
            salarytypesData = new List<Models.Salarytype>();
        }
        public void LoadSalarysetting()
        {
            var p = _context.Salarytypes.ToList();
            salarytypesData = p;
            _view.DisplaySalarysetting(p);
        }
        public bool AddSalarysetting(Salarytype salarytype)
        {
            bool isexist = false;
            if (!_context.Salarytypes.Any(r => r.Description == salarytype.Description))
            {
                _context.Salarytypes.Add(salarytype);
                _context.SaveChanges();
                MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                isexist = true;
                MessageBox.Show("License type already existed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            LoadSalarysetting();
            return isexist;
        }
        public void UpdateSalarysetting(Salarytype salarytype)
        {
            _context.Salarytypes.Update(salarytype);
            _context.SaveChanges();
            MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadSalarysetting();
        }
        public void SearchData(string searchQuery)
        {
            var searchResults = salarytypesData
                 .Where(b => b.PkSalarytype.ToString().Contains(searchQuery)
                 || (b.Description != null && b.Description.Contains(searchQuery,
                 StringComparison.OrdinalIgnoreCase)))
                 .ToList();

            _view.DisplaySalarysetting(searchResults);
        }
    }
    
}
