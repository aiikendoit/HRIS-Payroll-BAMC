using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Views.Forms.Employee.Employee_Request
{
    public partial class frm_requestSelection : Form
    {
        public frm_requestSelection()
        {
            InitializeComponent();
        }

        private void btn_leaves_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var l = new frm_leaves();
            l.ShowDialog();
            
        }
    }
}
