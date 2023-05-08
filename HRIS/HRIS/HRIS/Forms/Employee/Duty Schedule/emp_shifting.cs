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

namespace HRIS.Forms.Employee
{
    public partial class emp_shifting : Form
    {
        public emp_shifting()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_employee);
        }

        private void emp_shifting_Load(object sender, EventArgs e)
        {

        }
    }
}
