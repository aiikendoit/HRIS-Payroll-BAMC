using HRIS.Class;
using HRIS.Views.Employee.Work_Assignment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Views.Employee
{
    public partial class emp_workassignment : Form
    {
        public emp_workassignment()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_workassignment);
        }

        private void emp_workassignment_Load(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            emp_AddworkAssignment emp_AddworkAssignment = new emp_AddworkAssignment();
            emp_AddworkAssignment.ShowDialog();
        }
    }
}
