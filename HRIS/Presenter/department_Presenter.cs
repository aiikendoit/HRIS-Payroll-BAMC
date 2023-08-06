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
        private List<Department> departmentdata;
        public department_Presenter(IDeparmentView view)
        {
            _view = view;
            _context = new HrisContext();
            departmentdata = new List<Department>();
        }
        public void LoadDepartment()
        {
            var p = _context.Departments.ToList();
            departmentdata = p;
            _view.DisplayDepartment(p);
        }
        public void AddDepartment(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
            MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDepartment();
        }
        public void UpdateDepartment(Department department)
        {
            _context.Departments.Update(department);
            _context.SaveChanges();
            MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDepartment();
        }
        public void SearchData(string searchQuery)
        {
            var searchResults = departmentdata
                 .Where(b => b.PkDepartment.ToString().Contains(searchQuery)
                 || (b.Description != null && b.Description.Contains(searchQuery,
                 StringComparison.OrdinalIgnoreCase)))
                 .ToList();

            _view.DisplayDepartment(searchResults);
        }
    }
}
