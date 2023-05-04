using HRIS.Class;
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
    public partial class emp_FamilyDependentsForm : Form
    {
        public emp_FamilyDependentsForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_family);
        }

        private void emp_FamilyDependentsForm_Load(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            emp_AddDependent emp_AddDependent   = new emp_AddDependent();
            emp_AddDependent.ShowDialog();
        }
    }
}
