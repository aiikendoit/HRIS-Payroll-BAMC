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

namespace HRIS.Views.Forms.Employee.Employee_Request
{
    public partial class EmployeeRequestForm : Form
    {
        public EmployeeRequestForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_educationalattainment);
        }

        private void EmployeeRequestForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Request");
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Approved");
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Rejected");
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            var r = new frm_requestSelection();
            r.ShowDialog();
        }
    }
}
