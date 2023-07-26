using HRIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Maintenance.NationalityFolder
{
    public interface INationalityView
    {
        void DisplayNationality(List<Models.Nationality> Nationalities);
        void ClearFields();
    }
}
