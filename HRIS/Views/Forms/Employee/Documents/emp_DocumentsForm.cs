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
    }
}
