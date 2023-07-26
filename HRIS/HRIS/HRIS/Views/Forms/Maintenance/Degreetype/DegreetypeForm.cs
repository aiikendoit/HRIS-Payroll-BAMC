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

namespace HRIS.Forms.Maintenance.Degreetype
{
    public partial class DegreetypeForm : Form
    {
        public DegreetypeForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_degreetype);
        }

        private void DegreetypeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
