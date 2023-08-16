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
            dgv_hideCols();
        }

        private void dgv_hideCols()
        {
            dgrid_documents.Columns[0].Visible = false;
            dgrid_documents.Columns[1].Visible = false;
            dgrid_documents.Columns[2].Visible = false;
            dgrid_documents.Columns[6].Visible = false;
            dgrid_documents.Columns[7].Visible = false;
        }

        private void emp_DocumentsForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            var addNew = new Add_Docs(EmpID);
            addNew.ShowDialog();
            loadEmployeeDocumentsData();
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

        private void dgrid_documents_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //dgrid_documents.Columns[0].Width = 50;
            //dgrid_documents.Columns[2].Width = 250;
            //dgrid_documents.Columns[3].Width = 100;
            //dgrid_documents.Columns[1].HeaderText = "Educational Attainment";
            //dgrid_documents.Columns[2].HeaderText = "School Attended";
            dgrid_documents.Columns[3].HeaderText = "Description";
            dgrid_documents.Columns[4].HeaderText = "Remarks";
            dgrid_documents.Columns[5].HeaderText = "Created Date";
            
            

        }
    }
}
