﻿using HRIS.Class;
using HRIS.Forms.Employee.License_information;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee;
using HRIS.Views.Forms.Employee.Documents;
using HRIS.Views.Forms.Maintenance.AddressFolder.TownCityFolder;
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
        public int EmpID;
        //private int PKEmployeeid;
        private readonly EmployeeDocument_Presenter _presenterEmployeeDocs;
        public emp_DocumentsForm(int PkEmployeeID, bool isUpdate)

        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_documents);
            _presenterEmployeeDocs = new EmployeeDocument_Presenter(this);
            EmpID = PkEmployeeID;
            //PKEmployeeid = PKEmployeeid;
            loadEmployeeDocumentsData();

            // btn_viewDocs.Click += btn_viewDocs_Click;
            if (isUpdate == false)
            {
                btn_new.Visible = false;
                btn_Edit.Visible = false;
                btn_viewDocs.Visible = true;
            }

            btn_Edit.Visible = false;
            btn_viewDocs.Visible = false;
        }

        private void loadEmployeeDocumentsData()//where ID
        {
            _presenterEmployeeDocs.loadEmployeeDocsDetails(EmpID);
            editButtonColumn.Text = "Edit"; // Set default text for the button
            editButtonColumn.UseColumnTextForButtonValue = true; // This will display the text in the button cells
            viewButtonColumn.Text = "View";
            viewButtonColumn.UseColumnTextForButtonValue = true;
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
            var PkEmployeedocument = dgrid_documents.SelectedRows[0].Cells[0].Value;
            Add_Docs empDoc = new Add_Docs(EmpID);
            empDoc.isUpdate = true;
            empDoc.putdata(Convert.ToInt32(PkEmployeedocument));
            empDoc.ShowDialog();
            loadEmployeeDocumentsData();

        }

        private void updateEmployeeDocsData()
        {

        }

        private void btn_viewDocs_Click(object sender, EventArgs e)
        {
            int PKEmployeeID = (int)dgrid_documents.SelectedRows[0].Cells[0].Value;
            //if (PKEmployeeID != 0)
            //{
            var empDocs = new PreviewDocs(PKEmployeeID);
            empDocs.ShowDialog();
            //}
        }
        private void search()
        {
            string searchQuery = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                loadEmployeeDocumentsData();
            }
            else
            {
                _presenterEmployeeDocs.SearchData(searchQuery);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            loadEmployeeDocumentsData();
        }

        private void dgrid_documents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgrid_documents.Rows[e.RowIndex];

                if (e.ColumnIndex == editButtonColumn.Index)
                {
                    var PkEmployeedocument = dgrid_documents.SelectedRows[0].Cells[0].Value;
                    Add_Docs empDoc = new Add_Docs(EmpID);
                    empDoc.isUpdate = true;
                    empDoc.putdata(Convert.ToInt32(PkEmployeedocument));
                    empDoc.ShowDialog();
                    loadEmployeeDocumentsData();
                }
                else if (e.ColumnIndex == viewButtonColumn.Index)
                {
                    int PKEmployeeID = (int)row.Cells[0].Value;
                    var empDocs = new PreviewDocs(PKEmployeeID);
                    empDocs.ShowDialog(this);
                }
            }
        }
    }
}
