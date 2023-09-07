using HRIS.Models;
using HRIS.Views.Forms.Maintenance.Degreetype;
using HRIS.Views.Forms.Maintenance.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class documenttype_Presenter
    {
        private readonly IDocumentTypeView _view;
        private readonly HrisContext _context;
        private List<Doctype> doctypedata;
        public documenttype_Presenter(IDocumentTypeView view)
        {
            _view = view;
            _context = new HrisContext();
            doctypedata = new List<Doctype>();
        }
        public void LoadDocumenttype()
        {
            var p = _context.Doctypes.ToList();
            doctypedata = _context.Doctypes.ToList();
            _view.DisplayDocumentype(p);
        }
        public void AddDocumentType(Doctype doctype)
        {
                _context.Doctypes.Add(doctype);
                _context.SaveChanges();
                MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDocumenttype();
        }
        public void UpdateDocumenttype(Doctype doctype)
        {
            _context.Doctypes.Update(doctype);
            _context.SaveChanges();
            MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDocumenttype();
        }
        public void SearchData(string searchQuery)
        {
            var searchResults = doctypedata
                 .Where(b => b.PkDoctype.ToString().Contains(searchQuery)
                 || (b.Description != null && b.Description.Contains(searchQuery,
                 StringComparison.OrdinalIgnoreCase)))
                 .ToList();

            _view.DisplayDocumentype(searchResults);
        }
    }
}
