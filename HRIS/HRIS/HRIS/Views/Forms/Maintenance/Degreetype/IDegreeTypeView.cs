using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Maintenance.Degreetype
{
    public interface IDegreeTypeView
    {
        void DisplayDegreetype(List<Models.Degreetype> degreetypes);
    }
}
