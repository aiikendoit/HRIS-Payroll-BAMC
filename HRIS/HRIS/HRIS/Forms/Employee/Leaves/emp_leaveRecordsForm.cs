using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRIS.Class;

namespace HRIS.Forms.Employee.Leaves
{
    public partial class emp_leaveRecordsForm : Form
    {
        public emp_leaveRecordsForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_leaverecords);
        }

        private void emp_leaveRecordsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
