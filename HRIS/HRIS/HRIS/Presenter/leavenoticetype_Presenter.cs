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
    public class leavenoticetype_Presenter
    {
        private readonly ILeaveNoticeTypeView _view;
        private readonly HrisContext _context;
        private List<Leavenoticetype> leavenoticetypedata;
        public leavenoticetype_Presenter(ILeaveNoticeTypeView view)
        {
            _view = view;
            _context = new HrisContext();
            leavenoticetypedata = new List<Leavenoticetype>();
        }
        public void Loadleavenotice()
        {
            var p = _context.Leavenoticetypes.ToList();
            leavenoticetypedata = p;
            _view.DisplayLeaveNoticeType(p);
        }
        public void AddLeavenoticetype(Leavenoticetype leavenoticetype)
        {
            _context.Leavenoticetypes.Add(leavenoticetype);
            _context.SaveChanges();
            MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Loadleavenotice();
        }
        public void updateleavenotice(Leavenoticetype leavenoticetype)
        {
            _context.Leavenoticetypes.Update(leavenoticetype);
            _context.SaveChanges();
            MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Loadleavenotice();
        }
        public void SearchData(string searchQuery)
        {
            var searchResults = leavenoticetypedata
                 .Where(b => b.PkLeavenoticetype.ToString().Contains(searchQuery)
                 || (b.Description != null && b.Description.Contains(searchQuery,
                 StringComparison.OrdinalIgnoreCase)))
                 .ToList();

            _view.DisplayLeaveNoticeType(searchResults);
        }
    }
}
