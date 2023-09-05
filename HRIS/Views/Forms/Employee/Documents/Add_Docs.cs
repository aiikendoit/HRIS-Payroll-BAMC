using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using HRIS.Class;
using HRIS.Forms.Employee.Documents;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.AddressFolder.TownCityFolder;
using HRIS.Views.Forms.Maintenance.Document;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HRIS.Views.Forms.Employee.Documents
{
    public partial class Add_Docs : Form, IEmployeeView, IDocumentTypeView, IEmployeeDocumentView
    {
        //int EmpID = 0;
        public int PKEmployee;

        private readonly employee_Presenter emp_Presenter;
        private readonly documenttype_Presenter doctype_Presenter;
        private readonly EmployeeDocument_Presenter empDocs_Presenter;
        private readonly HrisContext _context;

        private emp_DocumentsForm _docsForm;
        private Models.Employeedocument SelectedEmployeeDocs;

        public bool isUpdate = false;
        private string selectedFilePath;//attached file

        private int PkEmployeedocument;
        public Add_Docs(int EmpID)
        {
            InitializeComponent();
            doctype_Presenter = new documenttype_Presenter(this);
            emp_Presenter = new employee_Presenter(this);
            empDocs_Presenter = new EmployeeDocument_Presenter(this);
            _context = new HrisContext();
            PKEmployee = EmpID;
            doctype_Presenter.LoadDocumenttype();

        }

        public void DisplayDocumentype(List<Doctype> documentTypes)//load combobox
        {
            comboBox_DocType.DataSource = documentTypes;
            comboBox_DocType.ValueMember = "PkDoctype";
            comboBox_DocType.DisplayMember = "Description";
        }

        public void DisplayEmployee(List<Models.Employee> employees)
        {

        }

        public void DisplayEmployeeAllDetails(List<Models.Employee> employees)
        {

        }

        public void DisplayEmployeeCustomView(List<object> employees)
        {
            //throw new NotImplementedException();
        }

        private void Add_Docs_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                update();
            }
            else
            {
                save();
            }
        }

        private void update()
        {
            //var updateEmpDocs = _context.Employeedocuments.Find(PkEmployeedocument);
            //if (updateEmpDocs != null)
            //{
            //    updateEmpDocs.FkEmployee = PKEmployee;
            //    updateEmpDocs.FkDoctype = Convert.ToInt32(comboBox_DocType.SelectedValue);
            //    updateEmpDocs.Description = textBox_Description.Text;
            //    updateEmpDocs.Remarks = richTextBox_Remarks.Text;
            //    if (!string.IsNullOrEmpty(selectedFilePath)) // Check if a new file is selected for update
            //    {
            //        byte[] fileData = File.ReadAllBytes(selectedFilePath);
            //        updateEmpDocs.EmployeeDocs = fileData; // Update the file data
            //        //no filepath query, no retrieve data
            //    }

            //    empDocs_Presenter.updateEmployeeDocs(updateEmpDocs);
            //    this.Close();
            //}

            var updateEmpDocs = _context.Employeedocuments.Find(PkEmployeedocument);
            if (updateEmpDocs != null)
            {
                _context.Entry(updateEmpDocs).State = EntityState.Detached; // Detach the existing entity
                

                updateEmpDocs.FkEmployee = PKEmployee;
                updateEmpDocs.FkDoctype = Convert.ToInt32(comboBox_DocType.SelectedValue);
                updateEmpDocs.Description = textBox_Description.Text;
                updateEmpDocs.Remarks = richTextBox_Remarks.Text;
                if (!string.IsNullOrEmpty(selectedFilePath)) // Check if a new file is selected for update
                {
                    byte[] fileData = File.ReadAllBytes(selectedFilePath);
                    updateEmpDocs.EmployeeDocs = fileData; // Update the file data
                                                           //no filepath query, no retrieve data
                }

                _context.Entry(updateEmpDocs).State = EntityState.Modified; // Attach and mark the new entity as modified

                empDocs_Presenter.updateEmployeeDocs(updateEmpDocs);
                this.Close();
            }
        }

        private void save()
        {
            try
            {

                //if (UniversalStatic.IsEmpty(txt_expiryreminder)) return;
                string? createdby = Properties.Settings.Default.completename;
                int id = Properties.Settings.Default.usercode;

                var cv = new Models.Employeedocument
                {
                    FkEmployee = PKEmployee,
                    FkDoctype = Convert.ToInt32(comboBox_DocType.SelectedValue),
                    Description = textBox_Description.Text,
                    Remarks = richTextBox_Remarks.Text,
                    Createddate = DateTime.Now, //get current date
                    Createdby = createdby,
                    FkSystemUser = id
                };

                if (!string.IsNullOrEmpty(selectedFilePath)) // Make sure a file is selected
                {
                    byte[] fileData = File.ReadAllBytes(selectedFilePath);
                    cv.EmployeeDocs = fileData; // Set the file data to the EmployeeDocs property
                }

                empDocs_Presenter.add_EmployeeDocs(cv);

                var confirmResult = MessageBox.Show("Are you sure to add this item ??",
                                     "Confirm Add!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // If 'Yes', do something here.
                    MessageBox.Show("Added Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    // If 'No', do something here.

                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

        public void DisplayEmployeeDocuments(List<Employeedocument> Employeedocuments)
        {
            try
            {
                Models.Employeedocument empDocs = Employeedocuments[0];
                comboBox_DocType.SelectedValue = empDocs.FkDoctype;
                //txt_educationalAttainment.SelectedValue = educ.FkEducationallevel;
                textBox_Description.Text = empDocs.Description;
                richTextBox_Remarks.Text = empDocs.Remarks;
                //txt_educationaldegree.Text = educ.Educationaldegree;
                //txt_degreetype.SelectedValue = educ.FkDegreetype;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAttachedFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tif;*.tiff;*.pdf)|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tif;*.tiff;*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                label_FilePath.Text = selectedFilePath;
            }
        }

        public void DisplayEmployeeDocumentsData(List<object> Employeedocuments)
        {

        }

        public void DisplayEmployeeInActive(List<object> employees)
        {

        }

        public void putdata(int employeedocument)
        {
            if (isUpdate)
            {
                //btn_cancel.Select();
                empDocs_Presenter.loadEmployeeDocs(employeedocument);//load from presenter query
                PkEmployeedocument = employeedocument;
            }
            else
            {
                //btn_cancel.Select();
                empDocs_Presenter.loadEmployeeDocs(employeedocument);
                //checkBox_isactive.Checked = SelectedTowncities.IsActive ?? false;
                comboBox_DocType.SelectedValue = SelectedEmployeeDocs.FkDoctype;
                //disable control
                comboBox_DocType.Enabled = false;
                textBox_Description.Enabled = false;
                richTextBox_Remarks.Enabled = false;
                buttonAttachedFile.Enabled = false;
                btn_save.Visible = false;
            }
        }
    }
}
