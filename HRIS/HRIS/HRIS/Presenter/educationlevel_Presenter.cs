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
        public educationlevel_Presenter(IEducationLevelView view)
        {
            _view = view;
            _context = new HrisContext();
        }
        public void LoadEducationallevel()
        {
            var p = _context.Educationallevels.ToList();
            _view.DisplayEducationalLevel(p);
        }
        public void AddEducationalLevel(Models.Educationallevel educationallevel)
        {
            _context.Educationallevels.Add(educationallevel);
            _context.SaveChanges();
            LoadEducationallevel();
        }
        public void UpdateEducationalLevel(Models.Educationallevel educationallevel)
        {
            _context.Educationallevels.Update(educationallevel);
            _context.SaveChanges();
            LoadEducationallevel();
        }
    }
}
