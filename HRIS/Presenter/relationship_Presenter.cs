using HRIS.Models;
using HRIS.Views.Forms.Maintenance.RelationShip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class relationship_Presenter
    {
        private readonly IRelationshipView _view;
        private readonly HrisContext _context;
        private List<Relationship> relationshipListData;
        public relationship_Presenter(IRelationshipView view)
        {
            _view = view;
            _context = new HrisContext();
            relationshipListData = new List<Relationship>();
        }
        public void loadRelationShip()
        {
            var p = _context.Relationships.ToList();
            relationshipListData = p;
            _view.DisplayRelationship(p);
        }
        public bool AddRelationship(Relationship relationship)
        {
            bool isexist = false;
            if (!_context.Relationships.Any(r => r.Description == relationship.Description))
            {
                _context.Relationships.Add(relationship);
                _context.SaveChanges();
                MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                isexist = true;
                MessageBox.Show("Relationship already existed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           
            }
            loadRelationShip();
            return isexist;
        }
        public void UpdateRelationship(Relationship relationship)
        {
            _context.Relationships.Update(relationship);
            _context.SaveChanges();
            MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadRelationShip();
        }

        public void SearchData(string searchQuery)
        {
            var searchResults = relationshipListData
                 .Where(b => b.PkRelationship.ToString().Contains(searchQuery)
                 || (b.Description != null && b.Description.Contains(searchQuery,
                 StringComparison.OrdinalIgnoreCase)))
                 .ToList();

            _view.DisplayRelationship(searchResults);
        }
    }
}
