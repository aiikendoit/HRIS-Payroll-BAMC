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

namespace HRIS.Forms.Maintenance.Barangay
{
    public partial class BarangayForm : Form
    {
        public BarangayForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_barangay);
        }

        private void BarangayForm_Load(object sender, EventArgs e)
        {

        }
    }
}
