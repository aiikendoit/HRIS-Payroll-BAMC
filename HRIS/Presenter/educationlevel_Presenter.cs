using HRIS.Models;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using HRIS.Views.Forms.Maintenance.EducationaLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class educationlevel_Presenter
    {
        private readonly IEducationLevelView _view;
        private readonly HrisContext _context;
        private List<Educationallevel> educationaldata;
        public educationlevel_Presenter(IEducationLevelView view)
        {
            _view = view;
            _context = new HrisContext();
            educationaldata = new List<Educationallevel>();
        }
        public void LoadEducationallevel()
        {
            var p = _context.Educationallevels
             .OrderBy(e => e.PkEducationallevel == 1000 ? 0 : 1)
             .ThenBy(e => e.Description)
             .ToList();
            educationaldata = p;
            _view.DisplayEducationalLevel(p);


        }
        public void AddEducationalLevel(Models.Educationallevel educationallevel)
        {
            _context.Educationallevels.Add(educationallevel);
            _context.SaveChanges();
            MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadEducationallevel();
        }
        public void UpdateEducationalLevel(Models.Educationallevel educationallevel)
        {
            _context.Educationallevels.Update(educationallevel);
            _context.SaveChanges();
            MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadEducationallevel();
        }
        public void SearchData(string searchQuery)
        {
            var searchResults = educationaldata
                 .Where(b => b.PkEducationallevel.ToString().Contains(searchQuery)
                 || (b.Description != null && b.Description.Contains(searchQuery,
                 StringComparison.OrdinalIgnoreCase)))
                 .ToList();
            _view.DisplayEducationalLevel(searchResults);
        }
    }
}
