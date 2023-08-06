using HRIS.Class;
using HRIS.Forms.Maintenance.Degreetype;
using HRIS.Forms.Maintenance.Document;
using HRIS.Models;
using HRIS.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Views.Forms.Maintenance.Document
{
    public partial class frm_documenttype : Form, IDocumentTypeView
    {
        private readonly documenttype_Presenter documenttype_Presenter;
        private DocumentTypeForm DocumentTypeForm;
        private Models.Doctype Seleteddoctype;
        public bool isupdate = false;
        public frm_documenttype()
        {
            InitializeComponent();
            documenttype_Presenter = new documenttype_Presenter(this);
            this.Seleteddoctype = new Models.Doctype();
            this.DocumentTypeForm = new DocumentTypeForm();
        }
        private void save()
        {
            if (UniversalStatic.IsEmpty(txt_documenttype)) return;
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Models.Doctype
            {
                Description = txt_documenttype.Text,
                IsActive = checkBox_isactive.Checked,
                IsCertiificate = checkBox_isCertificate.Checked,
                Createdby = createdby,
                FkSystemUser = id
            };
            documenttype_Presenter.AddDocumentType(cv);
            this.Close();
        }
        private void update() 
        {
            var selddoctype = Seleteddoctype as Models.Doctype;

            selddoctype.Description = txt_documenttype.Text;
            selddoctype.IsActive = checkBox_isactive.Checked;
            selddoctype.IsCertiificate = checkBox_isCertificate.Checked;
            documenttype_Presenter.UpdateDocumenttype(selddoctype);
            this.Close();
        }
        public void putdata(DocumentTypeForm documentTypeForm, Doctype doctype)
        {
            if (isupdate)
            {
                btn_cancel.Select();
                this.DocumentTypeForm = documentTypeForm;
                this.Seleteddoctype = doctype;
                txt_documenttype.Text = Seleteddoctype.Description;
                checkBox_isactive.Checked = Seleteddoctype.IsActive;
                checkBox_isCertificate.Checked = Seleteddoctype.IsCertiificate;
            }
            else
            {
                btn_cancel.Select();
                this.DocumentTypeForm = documentTypeForm;
                this.Seleteddoctype = doctype;
                txt_documenttype.Text = Seleteddoctype.Description;
                checkBox_isactive.Checked = Seleteddoctype.IsActive;
                checkBox_isCertificate.Checked = Seleteddoctype.IsCertiificate;
                //disable control
                txt_documenttype.Enabled = false;
                checkBox_isCertificate.Enabled = false;
                checkBox_isactive.Enabled = false;
                btn_save.Visible = false;
            }
        }
        public void DisplayDocumentype(List<Doctype> documentTypes)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isupdate)
            {
                update();
            }
            else
            {
                save();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
