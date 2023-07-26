using HRIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Maintenance.EducationaLevel
{
    public interface IEducationLevelView
    {
        void DisplayEducationalLevel(List<Models.Educationallevel> Educationallevels);
    }
}
