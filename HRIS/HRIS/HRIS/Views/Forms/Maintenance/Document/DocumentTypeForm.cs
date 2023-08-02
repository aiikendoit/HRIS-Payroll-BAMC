using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Maintenance.Document
{
    public partial class DocumentTypeForm : Form, IDocumentTypeView
    {
        private readonly documenttype_Presenter documenttype_Presenter;
        public DocumentTypeForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_disciplinary);
            documenttype_Presenter = new documenttype_Presenter(this);
            documenttype_Presenter.LoadDocumenttype();
        }

        public void DisplayDocumentype(List<Doctype> documentTypes)
        {
            dgrid_disciplinary.DataSource = documentTypes;
            dgrid_disciplinary.Columns[0].HeaderText = "ID";
            dgrid_disciplinary.Columns["Description"].HeaderText = "Document type";
            dgrid_disciplinary.Columns["Createddate"].HeaderText = "Created date";
            dgrid_disciplinary.Columns["Createdby"].HeaderText = "Created by";
            dgrid_disciplinary.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgrid_disciplinary.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgrid_disciplinary.ColumnCount == 8)
            {
                dgrid_disciplinary.Columns.RemoveAt(7);
                dgrid_disciplinary.Columns.RemoveAt(6);
            }
            dgrid_disciplinary.AutoGenerateColumns = false;
            txt_totalcount.Text = "Total count(s): " + dgrid_disciplinary.RowCount.ToString();
        }

        private void DocumentType_Load(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            var dt = new frm_documenttype();
            dt.ShowDialog();
            documenttype_Presenter.LoadDocumenttype();
        }
    }
}
