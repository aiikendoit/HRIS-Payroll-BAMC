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

namespace HRIS.Views.Employee.License_information
{
    public partial class emp_licenseInfoForm : Form
    {
        public emp_licenseInfoForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_license);
        }

        private void emp_licenseInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            emp_AddLicense emp_AddLicense = new emp_AddLicense();
            emp_AddLicense.ShowDialog();
        }
    }
}
