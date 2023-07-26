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

namespace HRIS.Forms.Employee.Employment
{
    public partial class emp_employmentForm : Form
    {
        public emp_employmentForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_employment);
        }

        private void emp_employmentForm_Load(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            emp_AddEmployment emp_AddEmployment = new emp_AddEmployment();
            emp_AddEmployment.ShowDialog();
        }
    }
}
