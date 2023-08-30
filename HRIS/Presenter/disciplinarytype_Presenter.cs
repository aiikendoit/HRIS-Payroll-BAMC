using HRIS.Models;
using HRIS.Views.Forms.Maintenance.Degreetype;
using HRIS.Views.Forms.Maintenance.Disciplinary;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class disciplinarytype_Presenter
    {
        private readonly IDisciplinaryView _view;
        private readonly HrisContext _context;
        private List<Disciplinarytype> disciplinarytypes;

        private List<object> disciplinaryTypeListObject;
        public disciplinarytype_Presenter(IDisciplinaryView view)
        {
            _view = view;
            _context = new HrisContext();
            //disciplinarytypes = new List<Disciplinarytype>();

            disciplinaryTypeListObject = new List<object>();
        }
        public void LoadDisciplinary()
        {
            var p = _context.Disciplinarytypes.ToList();
            disciplinarytypes = _context.Disciplinarytypes.ToList();
            _view.DisplayDisciplinaryType(p);
        }
        public void AddDisciplinary(Disciplinarytype disciplinarytype)
        {
            _context.Disciplinarytypes.Add(disciplinarytype);
            _context.SaveChanges();
            MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDisciplinary();
        }
        public void UpdateDisciplinary(Disciplinarytype disciplinarytype)
        {
            _context.Disciplinarytypes.Update(disciplinarytype);
            _context.SaveChanges();
            MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDisciplinary();
        }
    }
}
