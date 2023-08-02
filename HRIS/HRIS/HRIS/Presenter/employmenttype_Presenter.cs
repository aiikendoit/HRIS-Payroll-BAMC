using HRIS.Models;
using HRIS.Views.Forms.Maintenance.Degreetype;
using HRIS.Views.Forms.Maintenance.Employment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class employmenttype_Presenter
    {
        private readonly IEmploymentTypeView _view;
        private readonly HrisContext _context;
        private List<Employmenttype> employmenttypeData;
        public employmenttype_Presenter(IEmploymentTypeView view)
        {
            _view = view;
            _context = new HrisContext();
            employmenttypeData = new List<Employmenttype>();
        }
        public void LoadEmployment()
        {
            var p = _context.Employmenttypes.ToList();
            employmenttypeData = p;
            _view.DisplayEmployment(p);
        }
        public void AddEmploymenttype(Employmenttype employmenttype)
        {
            _context.Employmenttypes.Add(employmenttype);
            _context.SaveChanges();
            MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadEmployment();
        }
        public void UpdateEmployment(Employmenttype employmenttype)
        {
            _context.Employmenttypes.Update(employmenttype);
            _context.SaveChanges();
            MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadEmployment();
        }
        public void SearchData(string searchQuery)
        {
            var searchResults = employmenttypeData
                 .Where(b => b.PkEmploymenttype.ToString().Contains(searchQuery)
                 || (b.Description != null && b.Description.Contains(searchQuery,
                 StringComparison.OrdinalIgnoreCase)))
                 .ToList();
            _view.DisplayEmployment(searchResults);
        }
    }
}
