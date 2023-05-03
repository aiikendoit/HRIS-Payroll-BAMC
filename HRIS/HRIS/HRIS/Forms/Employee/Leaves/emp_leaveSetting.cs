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

namespace HRIS.Forms.Employee.Leaves
{
    public partial class emp_leaveSetting : Form
    {
        public emp_leaveSetting()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_leavesetting);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            emp_addLeaveSetting emp_AddLeaveSetting = new emp_addLeaveSetting();
            emp_AddLeaveSetting.ShowDialog();
        }
    }
}
