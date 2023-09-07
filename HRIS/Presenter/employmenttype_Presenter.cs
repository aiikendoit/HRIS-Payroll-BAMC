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
        private List<object> employmentList;
        public employmenttype_Presenter(IEmploymentTypeView view)
        {
            _view = view;
            _context = new HrisContext();
            employmenttypeData = new List<Employmenttype>();
            employmentList = new List<object>();
        }
        public void LoadEmployment()
        {
            var p = _context.Employmenttypes.ToList();
            employmenttypeData = p;
            _view.DisplayEmployment(p);
        }
        public void LoadEmploymentListCustom()
        {
            var query = from employment in _context.Employmenttypes
                        orderby employment.Description descending
                        select new
                        {
                            ID = employment.PkEmploymenttype,
                            isActive = employment.IsActive,
                            Description = employment.Description,
                            isOrganic = employment.IsOrganic,
                            isInOrganic = employment.IsInOrganic,
                            CreatedDate = employment.Createddate,
                        };
            _view.DsiplayEmploymentCustom(query.ToList<object>());
            employmentList = query.ToList<object>();
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
