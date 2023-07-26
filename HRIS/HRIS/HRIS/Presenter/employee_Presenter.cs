using HRIS.Models;
using HRIS.Views.Forms.Employee;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public  class employee_Presenter
    {
        private readonly IEmployeeView _view;
        private readonly HrisContext _context;
        public employee_Presenter(IEmployeeView view)
        {
            _view = view;
            _context = new HrisContext();
        }
        public void LoadEmployeewithWhere(int employeeid)
        {
            var p = _context.Employees.Where(c => c.PkEmployee == employeeid).ToList();
            _view.DisplayEmployeeAllDetails(p);
        }
        public void loadEmployeeJoin()
        {
            var query = from employee in _context.Employees
                       
                        join province in _context.Provinces on employee.FkProvince equals province.PkProvince
                        join region in _context.Regions on province.FkRegion equals region.PkRegion
                        join townCity in _context.Towncities on employee.FkTowncity equals townCity.PkTowncity
                        join barangay in _context.Barangays on employee.FkBarangay equals barangay.PkBarangay
                        where employee.Employeetype == "Employee"
                        orderby employee.Lastname ascending
                        select new Employee
                        {
                            PkEmployee = employee.PkEmployee,
                            Idno = employee.Idno,
                            Lastname = employee.Lastname + ", " + employee.Firstname + " " + employee.Middlename,
                            Gender = employee.Gender,
                            IsActive = employee.IsActive,
                            Address1 = employee.Address1
                            + " " + employee.Address2 + " " + employee.Address3 + " " + barangay.Description 
                            + " " + townCity.Description + " " + province.Description + " " + region.Description,
                            ProfilePicture = employee.ProfilePicture,
                        };
            _view.DisplayEmployee(query.ToList());
        }
        public void loadDoctorJoin()
        {
            var query = from employee in _context.Employees

                        join province in _context.Provinces on employee.FkProvince equals province.PkProvince
                        join region in _context.Regions on province.FkRegion equals region.PkRegion
                        join townCity in _context.Towncities on employee.FkTowncity equals townCity.PkTowncity
                        join barangay in _context.Barangays on employee.FkBarangay equals barangay.PkBarangay
                        where employee.Employeetype == "Doctor"
                        orderby employee.Lastname ascending
                        select new Employee
                        {
                            PkEmployee = employee.PkEmployee,
                            Idno = employee.Idno,
                            Lastname = employee.Lastname + ", " + employee.Firstname + " " + employee.Middlename,
                            Gender = employee.Gender,
                            IsActive = employee.IsActive,
                            Address1 = employee.Address1
                            + " " + employee.Address2 + " " + employee.Address3 + " " + barangay.Description
                            + " " + townCity.Description + " " + province.Description + " " + region.Description,
                            ProfilePicture = employee.ProfilePicture,
                        };
            _view.DisplayEmployee(query.ToList());
        }

        public void updateEmployee(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
            loadEmployeeJoin();
            MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public bool AddEmployee(Employee employee)
        {
            bool isexist = false;
            // Check if the employee already exists
            bool employeeExists = _context.Employees.Any(e => e.Idno == employee.Idno);

            if (employeeExists)
            {
                isexist = true;
                MessageBox.Show("ID Number already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                MessageBox.Show("Successfully saved!","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //loadEmployeeJoin();

            }
            return isexist;
        }
        public void AddEmployeeWithForeignKey(Employee employee) 
        { 

        }

    }
}
