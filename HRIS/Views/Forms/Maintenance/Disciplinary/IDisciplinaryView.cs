using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Maintenance.Disciplinary
{
    public interface IDisciplinaryView
    {
        void DisplayDisciplinaryType(List<Models.Disciplinarytype> disciplinaries);
        void DisplayDisciplinaryType_ListObject(List<object> disciplinaries);
    }
}
