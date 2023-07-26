using HRIS.Models;
using HRIS.Views.Forms.Employee.Work_Assignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class workassignment_Presenter
    {
        private readonly HrisContext _context;
        private readonly IWorkAssigmentView _view;
        public  workassignment_Presenter(IWorkAssigmentView view)
        {
            _view = view;
            _context = new HrisContext();
        }
        public void loadWorkAssignment()
        {
            var p = _context.Workassignments.ToList();
            _view.DisplayWorkAssignment(p);
        }
        public void AddWorkAssignment(Workassignment workassignment)
        {
            _context.Workassignments.Add(workassignment);
            _context.SaveChanges();
            loadWorkAssignment();
        }
    }
}
