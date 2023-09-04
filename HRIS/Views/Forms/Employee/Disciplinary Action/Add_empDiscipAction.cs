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
using HRIS.Forms.Employee.Disciplinary_Action;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.AddressFolder.TownCityFolder;
using HRIS.Views.Forms.Maintenance.Disciplinary;
using HRIS.Views.Forms.Maintenance.Offensetype;
using Microsoft.EntityFrameworkCore;

namespace HRIS.Views.Forms.Employee.Disciplinary_Action
{
    public partial class Add_empDiscipAction : Form, IEmployeeDisciplinaryActionView, IDisciplinaryView, IOffenceTypeView
    {
        public int PKEmployee;
        private readonly EmployeeDisciplinary_presenter empDA_presenter;
        private readonly disciplinarytype_Presenter discType_presenter;
        private readonly offencetype_Presenter offenseType_presenter;

        private emp_DisciplinaryActionForm add_DisciplinaryActionForm;
        private readonly HrisContext _context;
        private Models.Employeedisciplinary selectedEmployeeDiscplnryActn;
        private Models.Disciplinarytype selectedDisciplinaryType;
        private Models.Offensetype selectedOffenseType;
        public bool isUpdate = false;//update button control
        private string selectedFilePath;//attached file

        private int PkEmployeedocument;//employee id for button column
        public Add_empDiscipAction(int EmpID)
        {
            InitializeComponent();
            empDA_presenter = new EmployeeDisciplinary_presenter(this);
            discType_presenter = new disciplinarytype_Presenter(this);
            offenseType_presenter = new offencetype_Presenter(this);

            _context = new HrisContext();
            PKEmployee = EmpID;

            discType_presenter.LoadDisciplinary();//load combobox disciplinary type
            offenseType_presenter.LoadOffensetype();//load combobox offense type

        }

        public void ClearFields()
        {

        }

        public void DisplayEmployeeDscAct_All(List<Employeedisciplinary> employeedisciplinaries)
        {

        }

        public void displayEmployeeDscAct_ListObject(List<object> employeedisciplinaries)
        {

        }

        public void DisplayDisciplinaryType(List<Disciplinarytype> disciplinaries)
        {

            comboBox_discplnryType.DataSource = disciplinaries;
            comboBox_discplnryType.ValueMember = "PkDisciplinarytype";
            comboBox_discplnryType.DisplayMember = "Disciplinarydescription";
        }

        public void DisplayDisciplinaryType_ListObject(List<object> disciplinaries)
        {

        }

        public void DisplayOffencetype(List<Offensetype> offensetypes)
        {
            comboBox_offenseType.DataSource = offensetypes;
            comboBox_offenseType.ValueMember = "PkOffensetype";
            comboBox_offenseType.DisplayMember = "Description";
        }

        private void button_attach_Click(object sender, EventArgs e)
        {
            //upload files
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tif;*.tiff;*.pdf)|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tif;*.tiff;*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                label_filePath.Text = selectedFilePath;
            }
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

        private void save()
        {
            try
            {

                //if (UniversalStatic.IsEmpty(txt_expiryreminder)) return;
                string? createdby = Properties.Settings.Default.completename;
                int id = Properties.Settings.Default.usercode;

                var cv = new Models.Employeedisciplinary
                {
                    FkEmployee = PKEmployee,
                    FkOffensetype = Convert.ToInt32(comboBox_offenseType.SelectedValue),
                    FkDisciplinarytype = Convert.ToInt32(comboBox_discplnryType.SelectedValue),
                    Description = textBox_Description.Text,
                    //Remarks = richTextBox_Remarks.Text,
                    Datestart = dateTimePicker_Start.Value,
                    Dateend = dateTimePicker_End.Value,
                    Createddate = DateTime.Now, //get current date
                    Createdby = createdby,
                    FkSystemUser = id
                };

                if (!string.IsNullOrEmpty(selectedFilePath)) // Make sure a file is selected
                {
                    byte[] fileData = File.ReadAllBytes(selectedFilePath);
                    cv.File = fileData; // Set the file data to the EmployeeDocs property
                }

                empDA_presenter.AddEmplDiscAct(cv);//add method for presenter

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

        private void update()
        {
            var updateEmpDiscipActn = _context.Employeedisciplinaries.Find(PkEmployeedocument);
            if (updateEmpDiscipActn != null)
            {
                updateEmpDiscipActn.FkEmployee = PKEmployee;
                updateEmpDiscipActn.FkOffensetype = Convert.ToInt32(comboBox_offenseType.SelectedValue);
                updateEmpDiscipActn.FkDisciplinarytype = Convert.ToInt32(comboBox_discplnryType.SelectedValue);
                updateEmpDiscipActn.Description = textBox_Description.Text;
                updateEmpDiscipActn.Datestart = dateTimePicker_Start.Value;//get shortdate start
                updateEmpDiscipActn.Dateend = dateTimePicker_End.Value;//get shortdate end


                //updateEmpDocs.Educationaldegree = txt_educationaldegree.Text;
                //updateEmpDocs.FkDegreetype = Convert.ToInt32(txt_degreetype.SelectedValue);

                empDA_presenter.UpdateEmpDiscAct(updateEmpDiscipActn);//presenter update method 
                this.Close();
            }
        }
        public void putdata(int employeeDisciplnryActn)
        {
            if (isUpdate)
            {
                //btn_cancel.Select();
                empDA_presenter.loadEmpDiscAcWhere(employeeDisciplnryActn);//load from presenter query
                PkEmployeedocument = employeeDisciplnryActn;
            }
            else
            {
                //btn_cancel.Select();
                empDA_presenter.loadEmpDiscAcWhere(employeeDisciplnryActn);
                //checkBox_isactive.Checked = SelectedTowncities.IsActive ?? false;
                comboBox_discplnryType.SelectedValue = selectedEmployeeDiscplnryActn.FkDisciplinarytype;//load combobox FK
                comboBox_offenseType.SelectedValue = selectedEmployeeDiscplnryActn.FkOffensetype;//load combobox FK
                //disable control
                comboBox_offenseType.Enabled = false;
                comboBox_discplnryType.Enabled = false;
                textBox_Description.Enabled = false;
                dateTimePicker_Start.Enabled = false;
                dateTimePicker_End.Enabled = false;
                button_attach.Enabled = false;
                btn_save.Visible = false;
            }
        }
    }
}
