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

namespace HRIS.Forms.Hiring
{
    public partial class HiringForm : Form
    {
        public HiringForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_hiring);
        }

        private void HiringForm_Load(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            frm_HiringAdd frm_HiringAdd = new frm_HiringAdd();
            frm_HiringAdd.ShowDialog();
        }
    }
}
