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
        public int EmpID = 0;
        public emp_DocumentsForm(int PkEmployeeID)

        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_documents);
            EmpID = PkEmployeeID;
        }

        private void emp_DocumentsForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            var st = new Add_Docs(EmpID);
            st.ShowDialog();
        }


    }
}
