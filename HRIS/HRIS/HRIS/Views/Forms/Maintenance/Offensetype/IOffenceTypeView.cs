using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Maintenance.Offensetype
{
    public interface IOffenceTypeView
    {
        void DisplayOffencetype(List<Models.Offensetype> offensetypes);
    }
}
