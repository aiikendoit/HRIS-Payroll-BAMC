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

namespace HRIS.Forms.Employee.Seminars
{
    public partial class emp_SeminarForm : Form
    {
        public emp_SeminarForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_seminar);
        }

        private void emp_SeminarForm_Load(object sender, EventArgs e)
        {

        }
    }
}
