
using HRIS.Models;
using HRIS.Views.Forms.Employee;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Presenter
{
    public  class employee_Presenter
    {
        private readonly IEmployeeView _view;
        private readonly HrisContext _context;
        private List<object> employeesData;
        public employee_Presenter(IEmployeeView view)
        {
            _view = view;
            _context = new HrisContext();
            employeesData = new List<object>();
        }
        public void LoadEmployeewithWhere(int employeeid)
        {
            var p = _context.Employees.Where(c => c.PkEmployee == employeeid).ToList();
            _view.DisplayEmployeeAllDetails(p);
        }
        public void LoadAllSearchEmployee(string lastname, string firstname)
        {
            var query = from employee in _context.Employees
                        where (lastname == null || (employee.Lastname != null && employee.Lastname.Contains(lastname))) &&
                              (firstname == null || (employee.Firstname != null && employee.Firstname.Contains(firstname)))
                        select new
                        {
                            ID = employee.PkEmployee,
                            EmployeeID = employee.Idno,
                            Firstname = employee.Firstname,
                            MiddleName = employee.Middlename,
                            LastName = employee.Lastname,
                            Suffix = employee.Suffix,
                            Gender = employee.Gender,
                            Birthday = employee.Birthdate
                        };

            employeesData = query.ToList<object>();
            _view.DisplayEmployeeCustomView(employeesData);
        }
        public void loadEmployeeJoin_Active()
        {
            var query = from employee in _context.Employees
                        join province in _context.Provinces on employee.FkProvince equals province.PkProvince
                        join region in _context.Regions on province.FkRegion equals region.PkRegion
                        join townCity in _context.Towncities on employee.FkTowncity equals townCity.PkTowncity
                        join zipcode in _context.Zipcodes on townCity.PkTowncity equals zipcode.FkTowncity
                        join barangay in _context.Barangays on employee.FkBarangay equals barangay.PkBarangay
                        join workass in _context.Workassignments.Where(wa => wa.Enddate == null) on employee.PkEmployee equals workass.FkEmployee into workassGroup
                        from workass in workassGroup.DefaultIfEmpty()
                        join department in _context.Departments on workass.FkDepartment equals department.PkDepartment into departmentGroup
                        from department in departmentGroup.DefaultIfEmpty()
                        join position in _context.Positions on workass.FkPosition equals position.PkPosition into positionGroup
                        from position in positionGroup.DefaultIfEmpty()
                        where employee.Employeetype == "Employee" && workass.FkPosition != null && workass.Enddate == null
                        orderby employee.Lastname ascending
                        select new
                        {
                            ID = employee.PkEmployee,
                            employee.ProfilePicture,
                            EmployeeID = employee.Idno,
                            Name = employee.Lastname + ", " + employee.Firstname + " " + employee.Middlename,
                            Gender = employee.Gender,
                            Department = department.Description,
                            Position = position.PositionName,
                            Address = employee.Address1 + " " + employee.Address2 + " " + employee.Address3 + " " + barangay.Description
                            + " " + townCity.Description + " " + province.Description + " " + zipcode.Zipcode1 ,
                        };

           employeesData =  query.ToList<object>();
            _view.DisplayEmployeeCustomView(employeesData);

        }
        public void loadEmployeeJoin_InActive()
        {
            var query = from employee in _context.Employees
                        join province in _context.Provinces on employee.FkProvince equals province.PkProvince
                        join region in _context.Regions on province.FkRegion equals region.PkRegion
                        join townCity in _context.Towncities on employee.FkTowncity equals townCity.PkTowncity
                        join zipcode in _context.Zipcodes on townCity.PkTowncity equals zipcode.FkTowncity
                        join barangay in _context.Barangays on employee.FkBarangay equals barangay.PkBarangay
                        join workass in _context.Workassignments.Where(wa => wa.Enddate == null) on employee.PkEmployee equals workass.FkEmployee into workassGroup
                        from workass in workassGroup.DefaultIfEmpty()
                        join department in _context.Departments on workass.FkDepartment equals department.PkDepartment into departmentGroup
                        from department in departmentGroup.DefaultIfEmpty()
                        join position in _context.Positions on workass.FkPosition equals position.PkPosition into positionGroup
                        from position in positionGroup.DefaultIfEmpty()
                        where employee.Employeetype == "Employee" &&  workass.FkPosition == null || workass.Enddate != null
                        orderby employee.Lastname ascending
                        select new
                        {
                            ID = employee.PkEmployee,
                            employee.ProfilePicture,
                            EmployeeID = employee.Idno,
                            Name = employee.Lastname + ", " + employee.Firstname + " " + employee.Middlename,
                            Gender = employee.Gender,
                            Department = department.Description,
                            Position = position.PositionName,
                            Address = employee.Address1 + " " + employee.Address2 + " " + employee.Address3 + " " + barangay.Description
                                        + " " + townCity.Description + " " + province.Description + " " + zipcode.Zipcode1,
                        };

            employeesData = query.ToList<object>();
            _view.DisplayEmployeeCustomView(employeesData);

        }
        public void loadDoctorJoin(DataGridView dataGridView)
        {
            var query = from employee in _context.Employees
                        join province in _context.Provinces on employee.FkProvince equals province.PkProvince
                        join region in _context.Regions on province.FkRegion equals region.PkRegion
                        join townCity in _context.Towncities on employee.FkTowncity equals townCity.PkTowncity
                        join barangay in _context.Barangays on employee.FkBarangay equals barangay.PkBarangay
                        join workass in _context.Workassignments.Where(wa => wa.Enddate == null) on employee.PkEmployee equals workass.FkEmployee into workassGroup
                        from workass in workassGroup.DefaultIfEmpty()
                        join department in _context.Departments on workass.FkDepartment equals department.PkDepartment into departmentGroup
                        from department in departmentGroup.DefaultIfEmpty()
                        join position in _context.Positions on workass.FkPosition equals position.PkPosition into positionGroup
                        from position in positionGroup.DefaultIfEmpty()
                        where employee.Employeetype == "Doctor"
                        orderby employee.Lastname ascending
                        select new
                        {
                            ID = employee.PkEmployee,
                            employee.ProfilePicture,
                            EmployeeID = employee.Idno,
                            Name = employee.Lastname + ", " + employee.Firstname + " " + employee.Middlename,
                            Gender = employee.Gender,
                            IsActive = employee.IsActive,
                            Department = department.Description,
                            Position = position.PositionName,
                            Address = employee.Address1 + " " + employee.Address2 + " " + employee.Address3 + " " + barangay.Description
                                        + " " + townCity.Description + " " + province.Description + " " + region.Description,
                        };

            dataGridView.DataSource = query.ToList();
        }
        public void updateEmployee(Models.Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
            //loadEmployeeJoin();
            MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        public bool AddEmployee(Models.Employee employee)
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
        public void AddEmployeeWithForeignKey(Models.Employee employee) 
        { 

        }
        public void SearchData(string searchQuery)
        {
            var searchResults = employeesData
            .Where(item =>
            (item.GetType().GetProperty("EmployeeID")?.GetValue(item)?.ToString()?.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0) ||
            (item.GetType().GetProperty("Name")?.GetValue(item)?.ToString()?.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0) ||
            (item.GetType().GetProperty("Department")?.GetValue(item)?.ToString()?.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0)
            )
            .ToList();
            _view.DisplayEmployeeCustomView(searchResults.ToList());
        }
    }
}
