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

        public relationship_Presenter(IRelationshipView view)
        {
            _view = view;
            _context = new HrisContext();
        }
        public void loadRelationShip()
        {
            var p = _context.Relationships.ToList();
            _view.DisplayRelationship(p);
        }
        public void AddRelationship(Relationship relationship)
        {
            _context.Relationships.Add(relationship);
            _context.SaveChanges();
            loadRelationShip();
        }
    }
}
