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

namespace HRIS.Forms.Employee.Disciplinary_Action
{
    public partial class emp_DisciplinaryActionForm : Form
    {
        public emp_DisciplinaryActionForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_disciplinaryAction);
        }

        private void emp_DisciplinaryActionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
