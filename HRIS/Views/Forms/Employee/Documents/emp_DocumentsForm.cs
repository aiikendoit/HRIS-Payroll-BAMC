using HRIS.Class;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee;
using HRIS.Views.Forms.Employee.Documents;
using HRIS.Views.Forms.Maintenance.SalarySetting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Employee.Documents
{
    public partial class emp_DocumentsForm : Form
    {
        public emp_DocumentsForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_documents);
        }

        private void emp_DocumentsForm_Load(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            var st = new Add_Docs();
            st.ShowDialog();
            //salarysetting_Presenter.LoadSalarysetting();
        }
    }
}
