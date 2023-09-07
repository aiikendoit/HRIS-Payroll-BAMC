using HRIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Maintenance.RelationShip
{
    public interface IRelationshipView
    {
        void DisplayRelationship(List<Relationship> relationships);
    }
}
