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

namespace HRIS.Forms.Maintenance.Bank
{
    public partial class BankForm : Form
    {
        public BankForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_bank);
        }

        private void BankForm_Load(object sender, EventArgs e)
        {

        }
    }
}
