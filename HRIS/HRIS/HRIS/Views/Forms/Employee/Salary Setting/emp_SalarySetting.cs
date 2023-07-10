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

namespace HRIS.Forms.Employee.Salary_Setting
{
    public partial class emp_SalarySetting : Form
    {
        public emp_SalarySetting()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_salarysetting);
        }

        private void emp_SalarySetting_Load(object sender, EventArgs e)
        {

        }
    }
}
