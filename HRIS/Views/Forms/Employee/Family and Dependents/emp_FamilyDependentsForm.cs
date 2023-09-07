using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee.Family_and_Dependents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Employee.Family_and_Dependents
{
    public partial class emp_FamilyDependentsForm : Form, IFamilyDependents_View
    {
        int empId = 0;
        private readonly employeefamilydependent_Presenter employeefamilydependent_Presenter;


        public emp_FamilyDependentsForm(int employeeid, bool isupdate)
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_family);
            empId = employeeid;

            employeefamilydependent_Presenter = new employeefamilydependent_Presenter(this);
            employeefamilydependent_Presenter.LoadFamilydepnedent_customize(empId);

        }

        public void DisplayFamilyDenpendent(List<Employeedependent> employeedependents)
        {


        }

        private void emp_FamilyDependentsForm_Load(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            emp_AddDependent emp_AddDependent = new emp_AddDependent(empId);
            emp_AddDependent.ShowDialog();
        }

        public void DisplayFamilyDenpendent_customize(List<object> employeedependents)
        {
            if (employeedependents != null && employeedependents.Count > 0)
            {
                dgrid_family.AutoGenerateColumns = false;
                dgrid_family.Columns["PkEmployeedependents_ID"].DataPropertyName = "PkEmployeedependents_ID";
                dgrid_family.Columns["Fullname"].DataPropertyName = "Fullname";
                dgrid_family.Columns["Birthdate"].DataPropertyName = "Birthdate";
                dgrid_family.Columns["Relationship"].DataPropertyName = "Relationship";
                dgrid_family.Columns["Civilsatatus"].DataPropertyName = "Civilsatatus";
                dgrid_family.Columns["contactno"].DataPropertyName = "contactno";
                dgrid_family.Columns["qualifiedD"].DataPropertyName = "qualifiedD";
                dgrid_family.DataSource = employeedependents;
            }
            else
            {
                dgrid_family.DataSource = null; // Clear the DataGridView if licenseInfo is empty
            }
        }
    }
}
