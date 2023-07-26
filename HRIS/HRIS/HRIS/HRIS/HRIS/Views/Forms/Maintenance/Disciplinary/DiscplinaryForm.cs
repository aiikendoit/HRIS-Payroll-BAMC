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

namespace HRIS.Forms.Maintenance.Disciplinary
{
    public partial class DiscplinaryForm : Form
    {
        public DiscplinaryForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_disciplinary);
        }

        private void DiscplinaryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
