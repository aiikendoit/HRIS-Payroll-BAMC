using HRIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using Microsoft.EntityFrameworkCore;

namespace HRIS.Views.Forms.Maintenance.CivilStatus
{
    public interface ICivilStatusView
    {
        void DisplayEmployees(List<Civilstatus> Civilstatuses);
        void ClearFields();
    }
}
