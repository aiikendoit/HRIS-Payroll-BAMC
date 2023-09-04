using HRIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Employee.Family_and_Dependents
{
    public interface IFamilyDependents_View
    {
        void DisplayFamilyDenpendent(List<Employeedependent> employeedependents);
    }
}
