using HRIS.Class;
using HRIS.Models;
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
    public partial class emp_DocumentsForm : Form, IEmployeeDocumentView
    {
        public int EmpID = 0;
        //private int PKEmployeeid;
        private readonly EmployeeDocument_Presenter _presenterEmployeeDocs;
        public emp_DocumentsForm(int PkEmployeeID)

        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_documents);
            _presenterEmployeeDocs = new EmployeeDocument_Presenter(this);
            EmpID = PkEmployeeID;
            //PKEmployeeid = PKEmployeeid;
            loadEmployeeDocumentsData();

        }

        private void loadEmployeeDocumentsData()
        {
            _presenterEmployeeDocs.loadEmployeeDocsDetails(EmpID);
        }

        private void emp_DocumentsForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            var st = new Add_Docs(EmpID);
            st.ShowDialog();
        }

        public void DisplayEmployeeDocuments(List<Employeedocument> Employeedocuments)
        {

        }

        public void DisplayEmployeeDocumentsData(List<object> Employeedocuments)
        {
            //throw new NotImplementedException();
            dgrid_documents.DataSource = Employeedocuments;
            //changeDgridSize();
            label_total.Text = "Total count(s): " + dgrid_documents.RowCount.ToString();
        }
    }
}
