using HRIS.Class.Userlogin;
using HRIS.Models;
using HRIS.Views.Forms.Employee.Employment;
using HRIS.Views.Forms.Employee.License_information;
using HRIS.Views.Forms.Userlogin;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class employeeemploymentstatus_Presenter
    {
        private readonly IEmployeeEmploymentView _view;
        private readonly HrisContext _context;
        private List<object> employmentlist;
        public employeeemploymentstatus_Presenter(IEmployeeEmploymentView view)
        {
            _view = view;
            _context = new HrisContext();
            employmentlist = new List<object>();
        }
        public void LoadEmployeeEmploymentStatus(int PKEmploymentStatus)
        {
            var p = _context.Employmentstatuses
                .Where(e => e.PkEmployment == PKEmploymentStatus)
                .ToList();
            _view.DisplayEmployeeEmploymentAll(p);
        }
        public void LoadEmployeeEmploymentStatusCustom(int PKEmployeeID)
        {
            var query = from empstatus in _context.Employmentstatuses
                        join emptype in _context.Employmenttypes on empstatus.FkEmploymenttype equals emptype.PkEmploymenttype
                        where empstatus.FkEmployee == PKEmployeeID && empstatus.IsDeleted == false
                        orderby empstatus.Startdate descending
                        select new
                        {
                            ID = empstatus.PkEmployment,
                            Employmenttype = emptype.Description,
                            Startdate = empstatus.Startdate,
                            Enddate = empstatus.Enddate,
                            Remarks = empstatus.Remarks,
                        };

            _view.DisplayEmployeeEmploymentCustom(query.ToList<object>());
            employmentlist = query.ToList<object>();
        }
        public void AddEmploymentStatus(Employmentstatus employmentstatus)
        {
            var ver = new UserConfirmation();
            ver.ShowDialog();
            if (ver.islogin)
            {
                try
                {
                    _context.Employmentstatuses.Add(employmentstatus);
                    _context.SaveChanges();
                    MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.ToString());
                }
            }
           
        }
        public void UpdateEmploymentStatus(Employmentstatus employmentstatus)
        {
            var ver = new UserConfirmation();
            ver.ShowDialog();
            if (ver.islogin)
            {
                var existingEmployment = _context.Employmentstatuses.Find(employmentstatus.PkEmployment);

                if (existingEmployment != null)
                {
                    _context.Entry(existingEmployment).State = EntityState.Detached;
                    _context.Entry(employmentstatus).State = EntityState.Modified;
                    _context.SaveChanges();
                    MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
               
        }
        public void DeleteEmploymentStatus(Employmentstatus employmentstatus)
        {
            var ver = new UserConfirmation();
            ver.ShowDialog();
            if (ver.islogin)
            {
                var existingEmployment = _context.Employmentstatuses.Find(employmentstatus.PkEmployment);
                if (existingEmployment != null)
                {
                    _context.Entry(existingEmployment).State = EntityState.Detached;
                    _context.Entry(employmentstatus).State = EntityState.Modified;
                    _context.SaveChanges();
                    MessageBox.Show("Successfully Deleted!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
               
        }
        public void SearchData(string searchQuery)
        {
            var searchResults = employmentlist
            .Where(item =>
            (item.GetType().GetProperty("ID")?.GetValue(item)?.ToString()?.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0) ||
            (item.GetType().GetProperty("Employmenttype")?.GetValue(item)?.ToString()?.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0)
            )
            .ToList();
            _view.DisplayEmployeeEmploymentCustom(searchResults.ToList());
        }
    }
}

