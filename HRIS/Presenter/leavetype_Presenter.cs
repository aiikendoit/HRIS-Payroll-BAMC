using HRIS.Models;
using HRIS.Views.Forms.Maintenance.Degreetype;
using HRIS.Views.Forms.Maintenance.Leaves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class leavetype_Presenter
    {
        private readonly ILeaveTypeView _view;
        private readonly HrisContext _context;
        private List<Leavetype> leavetypesData;
        public leavetype_Presenter(ILeaveTypeView view)
        {
            _view = view;
            _context = new HrisContext();
            leavetypesData = new List<Leavetype>();
        }
        public void LoadLeaveType()
        {
            var p = _context.Leavetypes.ToList();
            leavetypesData = p;
            _view.DisplayLeavetype(p);
        }
        public void LoadLeavetype_forrequest(int employeeid)
        {
            var p = from leavetype in _context.Leavetypes
                    join levesetting in _context.Leavessettings on leavetype.PkLeavetype equals levesetting.FkLeavetype
                    where levesetting.FkEmployee == employeeid && levesetting.IsDeleted == false
                    select leavetype;
            _view.DisplayLeavetype(p.ToList());
        }
        public void AddLeavetype(Leavetype leavetype)
        {
            _context.Leavetypes.Add(leavetype);
            _context.SaveChanges();
            MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadLeaveType();
        }
        public void UpdateLeavetype(Leavetype leavetype)
        {
            _context.Leavetypes.Update(leavetype);
            _context.SaveChanges();
            MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadLeaveType();
        }
        public void SearchData(string searchQuery)
        {
            var searchResults = leavetypesData
                 .Where(b => b.PkLeavetype.ToString().Contains(searchQuery)
                 || (b.Description != null && b.Description.Contains(searchQuery,
                 StringComparison.OrdinalIgnoreCase)))
                 .ToList();

            _view.DisplayLeavetype(searchResults);
        }
    }
}
