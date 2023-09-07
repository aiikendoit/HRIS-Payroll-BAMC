using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee.Family_and_Dependents;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using HRIS.Views.Forms.Maintenance.RelationShip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Employee.Family_and_Dependents
{
    public partial class emp_AddDependent : Form, IRelationshipView, ICivilStatusView, IFamilyDependents_View
    {

        private readonly relationship_Presenter relationship_Presenter;
        private readonly civilStatus_Presenter civilStatus_Presenter;
        private readonly employeefamilydependent_Presenter employeefamilydependent_Presenter;
        int empId = 0;

        public emp_AddDependent(int employeeid)
        {
            InitializeComponent();
            relationship_Presenter = new relationship_Presenter(this);
            relationship_Presenter.loadRelationShip();

            NumberFormatInfo numberFormat = new NumberFormatInfo();
            numberFormat.NumberGroupSeparator = "";
            txt_Contactnumber.NumberFormatInfo = numberFormat;

            employeefamilydependent_Presenter = new employeefamilydependent_Presenter(this);

            civilStatus_Presenter = new civilStatus_Presenter(this);
            civilStatus_Presenter.LoadCivilStatus();

            empId = employeeid;
        }

        public void ClearFields()
        {
        }
        public void DisplayRelationship(List<Relationship> relationships)
        {
            //Relationship relationshipCombo = relationships[0];
            combo_relationship.DataSource = relationships;
            combo_relationship.ValueMember = "PkRelationship";
            combo_relationship.DisplayMember = "Description";

        }
        public void DisplayCivilStatus(List<Civilstatus> Civilstatuses)
        {
            combo_civilstatus.DataSource = Civilstatuses;
            combo_civilstatus.ValueMember = "PkCivilstatus";
            combo_civilstatus.DisplayMember = "Description";
        }

        private void save()
        {
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Employeedependent
            {
                FkEmployee = empId,
                FkRelationship = Convert.ToInt32(combo_relationship.SelectedValue),
                Lastname = txt_Lastname.Text,
                Firstname = txt_Firstname.Text,
                Middlename = txt_Middlename.Text,
                Suffix = txt_Suffixname.Text,
                Birthdate = dpicker_BDate.Value,
                FkCivilstatus = Convert.ToInt32(combo_civilstatus.SelectedValue),
                Contactno = Convert.ToInt32(txt_Contactnumber.Text),
                Address = txt_address.Text,
                IsQualifiedDependent = checkbox_QD.Checked,
                Createdby = createdby,


            };
            employeefamilydependent_Presenter.AddEmployeeFamilyDependent(cv);

        }








        public void DisplayFamilyDenpendent(List<Employeedependent> employeedependents)
        {
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            save();
        }

        public void DisplayFamilyDenpendent_customize(List<object> employeedependents)
        {
            throw new NotImplementedException();
        }
    }
}
