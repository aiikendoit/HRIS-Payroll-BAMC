using HRIS.Models;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using HRIS.Views.Forms.Maintenance.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class department_Presenter
    {
        private readonly HrisContext _context;
        private readonly IDeparmentView _view;
        public department_Presenter(IDeparmentView view)
        {
            _view = view;
            _context = new HrisContext();
        }
        public void LoadDepartment()
        {
            var p = _context.Departments.ToList();
            _view.DisplayDepartment(p);
        }
    }
}
