using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee;
using HRIS.Views.Forms.Employee.Documents;
using HRIS.Views.Forms.Maintenance.Degreetype;
using HRIS.Views.Forms.Maintenance.SalarySetting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
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

            btn_viewDocs.Click += btn_viewDocs_Click;
        }

        private void loadEmployeeDocumentsData()
        {
            _presenterEmployeeDocs.loadEmployeeDocsDetails(EmpID);
            dgv_hideCols();
        }

        private void dgv_hideCols()
        {
            //dgrid_documents.Columns[0].Visible = false;
            //dgrid_documents.Columns[1].Visible = false;
            //dgrid_documents.Columns[2].Visible = false;
            //dgrid_documents.Columns[5].Visible = false;
            //dgrid_documents.Columns[8].Visible = false;
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

            if (Employeedocuments != null && Employeedocuments.Count > 0)
            {
                dgrid_documents.AutoGenerateColumns = false;
                dgrid_documents.Columns["Code"].DataPropertyName = "pk_employeedocument";
                dgrid_documents.Columns["DocType"].DataPropertyName = "fk_doctype";
                dgrid_documents.Columns["Description"].DataPropertyName = "Description";
                dgrid_documents.Columns["Remarks"].DataPropertyName = "remarks";

                dgrid_documents.DataSource = Employeedocuments;
            }
            else
            {
                dgrid_documents.DataSource = null; // Clear the DataGridView if licenseInfo is empty
            }

            //changeDgridSize();
            label_total.Text = "Total count(s): " + dgrid_documents.RowCount.ToString();
        }

        private void dgrid_documents_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //dgrid_documents.Columns[0].Width = 50;
            //dgrid_documents.Columns[1].Width = 250;
            //dgrid_documents.Columns[2].Width = 100;
            //dgrid_documents.Columns[0].HeaderText = "Code";
            //dgrid_documents.Columns[4].HeaderText = "Remarks";
            //dgrid_documents.Columns[7].HeaderText = "Created By";
            //dgrid_documents.Columns[6].HeaderText = "Created Date";
            //dgrid_documents.Columns[5].HeaderText = "Description";
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dgrid_documents.SelectedCells.Count > 0)
            {
                // Get the selected value from the DataGridView
                int selectedValue = Convert.ToInt32(dgrid_documents.SelectedCells[0].Value);
                // Pass the selected value to Form2's constructor
                Add_Docs form2 = new Add_Docs(selectedValue);
                form2.ShowDialog(); // Show Form2 as a dialog
            }

        }

        private void updateEmployeeDocsData()
        {

        }

        private void btn_viewDocs_Click(object sender, EventArgs e)
        {

            int PKEmployeeID = (int)dgrid_documents.SelectedRows[0].Cells[0].Value;
            if (PKEmployeeID != null)
            {
                var empDocs = new PreviewDocs(PKEmployeeID);
                //empDocs.putdata(this, selectedEmpDocs);
                empDocs.ShowDialog(this);

            }
        }
    }
}
