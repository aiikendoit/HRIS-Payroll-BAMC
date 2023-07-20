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

namespace HRIS.Forms.Employee.Training
{
    public partial class emp_TrainingForm : Form
    {
        public emp_TrainingForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_training);
        }

        private void emp_TrainingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
