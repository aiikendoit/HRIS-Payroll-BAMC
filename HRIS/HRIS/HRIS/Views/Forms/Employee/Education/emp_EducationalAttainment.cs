using HRIS.Class;
using HRIS.Forms.Employee.Education;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Employee
{
    public partial class emp_EducationalAttainment : Form
    {
        public emp_EducationalAttainment()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_employee);
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            emp_AddEducationalAttainment neweduc = new emp_AddEducationalAttainment();
            neweduc.ShowDialog();
        }

        private void emp_EducationalAttainment_Load(object sender, EventArgs e)
        {

        }
    }
}
