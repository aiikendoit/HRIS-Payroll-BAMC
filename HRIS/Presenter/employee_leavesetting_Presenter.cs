using HRIS.Models;
using HRIS.Views.Forms.Employee.Leaves;
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
    public class employee_leavesetting_Presenter
    {
        private readonly IEmployeeLeaveSettingView _view;
        private readonly HrisContext _context;
        private List<object> leavesettingList;
        public employee_leavesetting_Presenter(IEmployeeLeaveSettingView view)
        {
            _view = view;
            _context = new HrisContext();
            leavesettingList = new List<object>();
        }
        public void LoadLeavesetting(int PKLeavesetting)
        {
            var p = _context.Leavessettings
                .Where(e => e.PkLeavessettings == PKLeavesetting)
                .ToList();
            _view.DisplayLeavesetting(p);
        }
        public void LoadLeaveSettingCustom(int employeeid)
        {
            var query = from leavesetting in _context.Leavessettings
                        join leavetype in _context.Leavetypes on leavesetting.FkLeavetype equals leavetype.PkLeavetype
                        where leavesetting.FkEmployee == employeeid && leavesetting.IsDeleted == false
                        orderby leavesetting.Effectivitydate descending
                        select new
                        {
                            ID = leavesetting.PkLeavessettings,
                            Leavetype = leavetype.Description,
                            daysperyear = leavesetting.Totaldays,
                            Effectivitydate = leavesetting.Effectivitydate,
                            Remarks = leavesetting.Remarks,
                        };

            _view.DisplayLeavesettingCustom(query.ToList<object>());
            leavesettingList = query.ToList<object>();
        }
        public void LoadLeavesetting_forLeaveFiling(int employeeid)
        {
            var query = from leavesetting in _context.Leavessettings
                        join leavetype in _context.Leavetypes on leavesetting.FkLeavetype equals leavetype.PkLeavetype
                        where leavesetting.FkEmployee == employeeid && leavesetting.IsDeleted == false
                        orderby leavesetting.Effectivitydate descending
                        select new
                        {
                            ID = leavesetting.PkLeavessettings,
                            PKLeavetype = leavetype.PkLeavetype,
                            Leavetype = leavetype.Description,
                            daysperyear = leavesetting.Totaldays,
                            Effectivitydate = leavesetting.Effectivitydate,
                            Remarks = leavesetting.Remarks,
                        };

            _view.DisplayLeavesettingCustom(query.ToList<object>());
            leavesettingList = query.ToList<object>();
        }
        public void AddLeaveSetting(Leavessetting leavessetting)
        {
            var ver = new UserConfirmation();
            ver.ShowDialog();
            if (ver.islogin)
            {
                try
                {
                    _context.Leavessettings.Add(leavessetting);
                    _context.SaveChanges();
                    MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            
        }
        public void UpdateLeavesetting(Leavessetting leavessetting)
        {
            var ver = new UserConfirmation();
            ver.ShowDialog();
            if (ver.islogin)
            {
                try
                {
                    var existingLeavesetting = _context.Leavessettings.Find(leavessetting.PkLeavessettings);

                    if (existingLeavesetting != null)
                    {
                        // Detach the entity to allow for updating
                        _context.Entry(existingLeavesetting).State = EntityState.Detached;

                        // Update the properties of the detached entity
                        // For example:
                        existingLeavesetting.Totaldays = leavessetting.Totaldays;
                        existingLeavesetting.Effectivitydate = leavessetting.Effectivitydate;
                        existingLeavesetting.Remarks = leavessetting.Remarks;

                        // Mark the entity as modified and save changes
                        _context.Entry(existingLeavesetting).State = EntityState.Modified;
                        _context.SaveChanges();

                        MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
                }
            }
            

        }
        public void DeleteLeavesetting(Leavessetting leavessetting)
        {
            var ver = new UserConfirmation();
            ver.ShowDialog();
            if (ver.islogin)
            {
                try
                {
                    var existingLeavesetting = _context.Leavessettings.Find(leavessetting.PkLeavessettings);

                    if (existingLeavesetting != null)
                    {
                        // Detach the entity to allow for updating
                        _context.Entry(existingLeavesetting).State = EntityState.Detached;

                        // Update the properties of the detached entity
                        // For example:
                        existingLeavesetting.IsDeleted = leavessetting.IsDeleted;

                        // Mark the entity as modified and save changes
                        _context.Entry(existingLeavesetting).State = EntityState.Modified;
                        _context.SaveChanges();

                        MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
                }
            }
            

        }
        public void SearchData(string searchQuery)
        {
            var searchResults = leavesettingList
            .Where(item =>
            (item.GetType().GetProperty("ID")?.GetValue(item)?.ToString()?.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0) ||
            (item.GetType().GetProperty("Leavetype")?.GetValue(item)?.ToString()?.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0)
            )
            .ToList();
            _view.DisplayLeavesettingCustom(searchResults.ToList());
        }
    }
}
