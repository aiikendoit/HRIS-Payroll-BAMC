using HRIS.Models;
using HRIS.Views.Forms.Employee.Family_and_Dependents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class employeefamilydependent_Presenter
    {
        private readonly IFamilyDependents_View _view;
        private readonly HrisContext _context;
        private List<Employeedependent> employeedependentdata;


        public employeefamilydependent_Presenter(IFamilyDependents_View view)
        {
            _view = view;
            _context = new HrisContext();
            employeedependentdata = new List<Employeedependent>();
        }
        public void LoadFamilydepnedent()
        {
            var p = _context.Employeedependents.ToList();
            employeedependentdata = p;
            _view.DisplayFamilyDenpendent(p);
        }
        public void AddEmployeeFamilyDependent(Employeedependent employeedependent)
        {
            _context.Employeedependents.Add(employeedependent);
            _context.SaveChanges();
            //_view.ClearFields();
            LoadFamilydepnedent();
        }


    }
}
