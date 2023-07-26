using HRIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Maintenance.ReligionFolder
{
    public interface IReligionView
    {
        void DisplayReligion(List<Models.Religion> Religions);
        void ClearFields();
    }
}
