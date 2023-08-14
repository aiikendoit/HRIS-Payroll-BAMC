using HRIS.Models;
using HRIS.Views.Forms.Employee.Education;
using HRIS.Views.Forms.Employee.License_information;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class employeelicenseinformation_Presenter
    {
        private readonly IEmployeelicenseInformationView _view;
        private readonly HrisContext _context;
        private List<object> licenseInfoList;
        public employeelicenseinformation_Presenter(IEmployeelicenseInformationView view)
        {
            _view = view;
            _context = new HrisContext();
            licenseInfoList = new List<object>();
        }
        public void LoadLicenseInfo(int PKLicense)
        {
            var p = _context.Employeelicenses
                .Where(e => e.PkEmployeelicense == PKLicense)
                .ToList();
            _view.DisplayLicenseInformation(p);
        }
        public void LoadLicenseInformationCustom(int PKEmployeeID)
        {
            var query = from license in _context.Employeelicenses
                        join lictype in _context.Licensetypes on license.FkLicensetype equals lictype.PkLicensetype
                        where license.FkEmployee == PKEmployeeID && license.IsDeleted == false
                        orderby license.Expirydate descending
                        select new
                        {
                            ID = license.PkEmployeelicense,
                            LicenseType = lictype.Description,
                            LicenseNumber = license.Licensenumber,
                            ExpiryDate = license.Expirydate,
                            Remarks = license.Remarks,
                        };

            _view.DisplaylicenseInfoCustom(query.ToList<object>());
            licenseInfoList = query.ToList<object>();
        }
        public void AddEmployeeLicense(Employeelicense employeelicense)
        {
            try
            {
                _context.Employeelicenses.Add(employeelicense);
                _context.SaveChanges();
                MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        public void UpdateEmployeeLicense(Employeelicense employeelicense)
        {
            var existingEduc = _context.Employeelicenses.Find(employeelicense.PkEmployeelicense);

            if (existingEduc != null)
            {
                _context.Entry(existingEduc).State = EntityState.Detached;
                _context.Entry(employeelicense).State = EntityState.Modified;
                _context.SaveChanges();
                MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void DeleteEmployeeLicense(Employeelicense employeelicense)
        {
            var existingEduc = _context.Employeelicenses.Find(employeelicense.PkEmployeelicense);
            if (existingEduc != null)
            {
                _context.Entry(existingEduc).State = EntityState.Detached;
                _context.Entry(employeelicense).State = EntityState.Modified;
                _context.SaveChanges();
                MessageBox.Show("Successfully Deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void SearchData(string searchQuery)
        {
            var searchResults = licenseInfoList
            .Where(item =>
            (item.GetType().GetProperty("ID")?.GetValue(item)?.ToString()?.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0) ||
            (item.GetType().GetProperty("LicenseType")?.GetValue(item)?.ToString()?.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0) ||
            (item.GetType().GetProperty("LinceseNumber")?.GetValue(item)?.ToString()?.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0)
            )
            .ToList();
            _view.DisplaylicenseInfoCustom(searchResults.ToList());
        }
    }
}
