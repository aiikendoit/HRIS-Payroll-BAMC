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
        private List<object> employeedependentdata_customize;


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
        public void LoadFamilydepnedent_customize(int PKEmployeeID)
        {
            var query = from Employeedependents in _context.Employeedependents
                        join Relationship in _context.Relationships on Employeedependents.FkRelationship equals Relationship.PkRelationship
                        join Civilstatus in _context.Civilstatuses on Employeedependents.FkCivilstatus equals Civilstatus.PkCivilstatus
                        where Employeedependents.FkEmployee == PKEmployeeID
                        orderby string.Concat(Employeedependents.Lastname, Employeedependents.Firstname) ascending
                        select new
                        {
                            PkEmployeedependents_ID = Employeedependents.PkEmployeedependents,
                            Fullname = Employeedependents.Lastname + " " + Employeedependents.Firstname,
                            Birthdate = Employeedependents.Birthdate,
                            Relationship = Relationship.Description,
                            Civilsatatus = Civilstatus.Description,
                            contactno = Employeedependents.Contactno,
                            qualifiedD = Employeedependents.IsQualifiedDependent,
                        };

            _view.DisplayFamilyDenpendent_customize(query.ToList<object>());
            employeedependentdata_customize = query.ToList<object>();

        }


        public void AddEmployeeFamilyDependent(Employeedependent employeedependent)
        {
            _context.Employeedependents.Add(employeedependent);
            _context.SaveChanges();
            MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //_view.ClearFields();
            LoadFamilydepnedent();
        }


    }
}
