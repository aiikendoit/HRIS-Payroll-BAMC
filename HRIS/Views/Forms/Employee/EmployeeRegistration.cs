using FontAwesome.Sharp;
using HRIS.Class;
using HRIS.Forms.Doctors;
using HRIS.Forms.Employee.Benefits;
using HRIS.Forms.Employee.Disciplinary_Action;
using HRIS.Forms.Employee.Documents;
using HRIS.Forms.Employee.Employment;
using HRIS.Forms.Employee.Family_and_Dependents;
using HRIS.Forms.Employee.Leaves;
using HRIS.Forms.Employee.License_information;
using HRIS.Forms.Employee.Salary_Setting;
using HRIS.Forms.Employee.Seminars;
using HRIS.Forms.Employee.Training;
using HRIS.Forms.Maintenance;
using HRIS.Forms.Maintenance.CivilStatus;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee;
using HRIS.Views.Forms.Maintenance.Bank;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using HRIS.Views.Forms.Maintenance.EducationaLevel;
using HRIS.Views.Forms.Maintenance.NationalityFolder;
using HRIS.Views.Forms.Maintenance.RelationShip;
using HRIS.Views.Forms.Maintenance.ReligionFolder;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Timer = System.Windows.Forms.Timer;

namespace HRIS.Forms.Employee
{

    public partial class EmployeeRegistration : Form, ICivilStatusView,
        IReligionView, INationalityView, IEducationLevelView, IRelationshipView, IEmployeeView, IBankView
    {
        private readonly civilStatus_Presenter civilStatus_Presenter;
        private readonly religion_Presenter religion_Presenter;
        private readonly nationality_Presenter nationality_Presenter;
        private readonly educationlevel_Presenter educationlevel_Presenter;
        private readonly relationship_Presenter relationship_Presenter;
        private readonly employee_Presenter employee_Presenter;
        private readonly bank_Presenter bank_Presenter;
        private readonly HrisContext _context;
        private EmployeeForm employeeForm;
        private DoctorForm doctorForm;
        private Models.Employee selectedEmployee;
        Boolean sidebarclick = false;
        private Form currentchildform;
        private IconButton currentbtn;
        String headername;
        private int employeeid;
        string? address1, address2, address3;
        int regionSelectedValue, provinceSelectedValue, towncitySelectedValue, barangaySelectedValue, zipcodeSelectedValue;
        public bool isUpdate = false;

        public EmployeeRegistration(string headername)
        {
            InitializeComponent();
            currentbtn = new IconButton();
            currentchildform = new Form();
            btn_basicinformation.ForeColor = ColorPalette.color5;
            btn_basicinformation.IconColor = ColorPalette.color5;
            this.headername = headername;
            label_Headername.Text = headername;
            civilStatus_Presenter = new civilStatus_Presenter(this);
            religion_Presenter = new religion_Presenter(this);
            nationality_Presenter = new nationality_Presenter(this);
            educationlevel_Presenter = new educationlevel_Presenter(this);
            relationship_Presenter = new relationship_Presenter(this);
            employee_Presenter = new employee_Presenter(this);

            bank_Presenter = new bank_Presenter(this);
            _context = new HrisContext();
            this.employeeForm = new EmployeeForm();
            this.selectedEmployee = new Models.Employee();
            this.doctorForm = new DoctorForm();
            //***********
            // Load data into combobox
            loadallCombobox();

        }
        public void loadallCombobox()
        {
            civilStatus_Presenter.LoadCivilStatus();
            religion_Presenter.LoadReligion();
            nationality_Presenter.loadNationality();
            educationlevel_Presenter.LoadEducationallevel();
            relationship_Presenter.loadRelationShip();
            bank_Presenter.LoadBank();
        }

        private void EmployeeRegistration_Load(object sender, EventArgs e)
        {
        }

        #region "Procedure"
        private void collapsemenu()
        {
            if (panelmenu.Width == 177)
            {
                //setting the width of a panel to 60
                int width = 160;
                while (width >= 70)
                {
                    width -= 10;
                    panelmenu.Width = width;
                }

                //looping through each button to make text to null
                foreach (Button menubutton in panelmenu.Controls)
                {
                    menubutton.Text = "";
                    menubutton.ImageAlign = ContentAlignment.MiddleLeft;
                    menubutton.Padding = new Padding(10, 0, 0, 0);
                }

                sidebarclick = true;
            }
            else
            {

                panelmenu.Width = 177;

                //looping through each button to make text to null
                foreach (Button menubutton in panelmenu.Controls)
                {
                    menubutton.Text = menubutton.Tag.ToString();
                    menubutton.ImageAlign = ContentAlignment.MiddleLeft;
                    menubutton.Padding = new Padding(10, 0, 0, 0);
                }
                sidebarclick = false;
            }
        }
        private void mousehover()
        {
            if (panelmenu.Width < 177)
            {
                panelmenu.Width = 177;
                //looping through each button to make text to null
                foreach (Button menubutton in panelmenu.Controls)
                {
                    menubutton.Text = menubutton.Tag.ToString();
                    menubutton.ImageAlign = ContentAlignment.MiddleLeft;
                    menubutton.Padding = new Padding(10, 0, 0, 0);
                }
            }

        }
        private void mouseleave()
        {
            panelmenu.Width = 60;
            //looping through each button to make text to null
            foreach (Button menubutton in panelmenu.Controls)
            {
                menubutton.Text = "";
                menubutton.ImageAlign = ContentAlignment.MiddleLeft;
                menubutton.Padding = new Padding(10, 0, 0, 0);
            }
        }
        private void openchildform(Form childform)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();
            }
            currentchildform = childform;
            currentchildform.TopLevel = false;
            currentchildform.FormBorderStyle = FormBorderStyle.None;
            currentchildform.Dock = DockStyle.Fill;
            currentchildform.Size = new Size(MainPanel.Width, MainPanel.Height);
            MainPanel.Controls.Add(currentchildform);
            MainPanel.BringToFront();
            childform.BringToFront();
            childform.Show();

        }
        private void activatebutton(Object senderbtn, Color customcolor)
        {
            disablebutton();
            currentbtn = (IconButton)senderbtn;
            currentbtn.BackColor = Color.FromArgb(0, 127, 152);
            currentbtn.ForeColor = customcolor;
            currentbtn.IconColor = customcolor;
        }
        private void disablebutton()
        {
            if (currentbtn != null)
            {
                currentbtn.ForeColor = Color.White;
                currentbtn.IconColor = Color.White;
                btn_basicinformation.ForeColor = Color.White;
                btn_basicinformation.IconColor = Color.White;
            }

        }
        private void reset()
        {
            disablebutton();
            panel_basicinfo.BringToFront();
        }
        #endregion

        public void disablecontrolforView()
        {
            foreach (Control control in this.panel_basicinfo.Controls)
            {
                if (!(control is Label))
                {
                    control.Enabled = false;
                }
            }
            btn_save.Visible = false;
            btn_cancel.Visible = false;
        }
        private void btn_sidebardrawer_Click(object sender, EventArgs e)
        {
            collapsemenu();
        }

        private void _MouseHover_(object sender, EventArgs e)
        {
            mousehover();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();
            }
            reset();
            activatebutton(sender, ColorPalette.color5);

        }

        private void btn_education_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_EducationalAttainment(employeeid));
        }

        private void btn_shifting_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_shifting());
        }

        private void btn_workassignment_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_workassignment(employeeid));
        }
        private void btn_basicinfo_Click(object sender, EventArgs e)
        {
            reset();
            activatebutton(sender, ColorPalette.color5);
        }


        private void _Activatebutton(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_licenseInfoForm(employeeid));
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_employmentForm(employeeid));
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_leaveSetting());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_leaveRecordsForm());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_FamilyDependentsForm());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_SeminarForm());
        }

        private void _training_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_TrainingForm());
        }

        private void _salarysetting_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_SalarySetting());
        }

        private void _DisciplinaryAction_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_DisciplinaryActionForm());
        }

        private void _benefits_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_Benefits());
        }

        private void _documents_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_DocumentsForm());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_addressinfo_Click(object sender, EventArgs e)
        {
            frm_AddressMaintenance addrs = new frm_AddressMaintenance();
            string? add1, add2, add3;
            int provinceid, townid, barangayid, zipcodeid;
            provinceid = provinceSelectedValue;
            townid = towncitySelectedValue;
            barangayid = barangaySelectedValue;
            zipcodeid = zipcodeSelectedValue;
            add1 = address1;
            add2 = address2;
            add3 = address3;
            addrs.putdata(add1 ?? string.Empty, add2 ?? string.Empty, add3 ?? string.Empty, provinceid, townid, barangayid, zipcodeid);
            addrs.ShowDialog();
            //set value
            if (addrs.issave == true)
            {
                address1 = addrs.address1.ToString();
                address2 = addrs.address2.ToString();
                address3 = addrs.address3.ToString();
                regionSelectedValue = addrs.regionSelectedvalue;
                provinceSelectedValue = addrs.provinceSelectedvalue;
                towncitySelectedValue = addrs.towncitySelectedvalue;
                barangaySelectedValue = addrs.barangaySelectedvalue;
                zipcodeSelectedValue = addrs.zipcodeSelectedvalue;
                if (addrs.completeaddress != "")
                {
                    txt_completeaddress.Text = addrs.completeaddress.ToString();
                }
            }

        }

        public void ClearFields()
        {
            //
        }

        public void DisplayCivilStatus(List<Civilstatus> Civilstatuses)
        {
            txt_civilstatus.DataSource = Civilstatuses;
            txt_civilstatus.DisplayMember = "Description";
            txt_civilstatus.ValueMember = "PkCivilstatus";
        }

        public void DisplayReligion(List<Religion> Religions)
        {
            txt_religion.DataSource = Religions;
            txt_religion.DisplayMember = "Description";
            txt_religion.ValueMember = "PkReligion";
        }

        public void DisplayNationality(List<Nationality> Nationalities)
        {
            txt_natinality.DataSource = Nationalities;
            txt_natinality.DisplayMember = "Description";
            txt_natinality.ValueMember = "PkNationality";
        }

        public void DisplayEducationalLevel(List<Educationallevel> Educationallevels)
        {
            txt_educatinlevel.DataSource = Educationallevels;
            txt_educatinlevel.DisplayMember = "Description";
            txt_educatinlevel.ValueMember = "PkEducationallevel";
        }

        public void DisplayRelationship(List<Relationship> relationships)
        {
            txt_relationship_combobox.DataSource = relationships;
            txt_relationship_combobox.DisplayMember = "Description";
            txt_relationship_combobox.ValueMember = "PKRelationship";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                if (UniversalStatic.IsEmpty(txt_idno)) return;
                if (UniversalStatic.IsEmpty(txt_lastname)) return;
                if (UniversalStatic.IsEmpty(txt_firstname)) return;
                if (UniversalStatic.IsEmpty(txt_completeaddress)) return;
                if (txt_bank.Text != "Not Applicable") { if (UniversalStatic.IsEmpty(txt_accountnumber)) return; }
                updateEmployee();

            }
            else
            {
                if (UniversalStatic.IsEmpty(txt_idno)) return;
                if (UniversalStatic.IsEmpty(txt_lastname)) return;
                if (UniversalStatic.IsEmpty(txt_firstname)) return;
                if (UniversalStatic.IsEmpty(txt_completeaddress)) return;
                if (txt_bank.Text != "Not Applicable") { if (UniversalStatic.IsEmpty(txt_accountnumber)) return; }
                addEmployee();
            }

        }
        public void putdata(int employeeid, string position, string department)
        {
            if (isUpdate)
            {
                //Edit
                employee_Presenter.LoadEmployeewithWhere(employeeid);
                txt_idno.Enabled = false;
                txt_position.Text = position;
                txt_department.Text = department;
            }
            else
            {
                //view
                employee_Presenter.LoadEmployeewithWhere(employeeid);
                txt_idno.Enabled = false;
                txt_position.Text = position;
                txt_department.Text = department;
                //Disable control
                btn_save.Visible = false;
                btn_cancel.Visible = false;
                foreach (Control control in this.panel_basicinfo.Controls)
                {
                    if (!(control is Label) && !(control is Button))
                    {
                        control.Enabled = false;
                    }
                }
            }

        }
        public void putDataNewEmployee(string lastname, string firtname)
        {
            txt_lastname.Text = lastname;
            txt_firstname.Text = firtname;
        }
        public void putdataDoctor(int employeeid, string position, string department)
        {
            employee_Presenter.LoadEmployeewithWhere(employeeid);
            txt_idno.Enabled = false;
            txt_position.Text = position + " | " + department;
        }

        public void DisplayEmployee(List<Models.Employee> employees)
        {


        }

        public void DisplayBank(List<BankName> banks)
        {
            txt_bank.DataSource = banks;
            txt_bank.DisplayMember = "BankName1";
            txt_bank.ValueMember = "PKBankName";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                Image image = Image.FromFile(filePath);
                profilepic.Image = image;
                picture_avatar.Image = image;
                profilepic.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        DataGridView dataGridView = new DataGridView();

        private void addEmployee()
        {

            string isgen = string.Empty;
            if (radioButton_male.Checked) { isgen = "Male"; }
            if (radioButton_female.Checked) { isgen = "Female"; }
            //Stored image data
            Image profileImage = profilepic.Image;
            byte[] imageData;
            using (MemoryStream ms = new MemoryStream())
            {
                profileImage.Save(ms, profileImage.RawFormat);
                imageData = ms.ToArray();
            }
            //******************
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            try
            {
                var cv = new Models.Employee
                {
                    Idno = txt_idno.Text,
                    Biometricno = txt_biometric.Text,
                    Rfid = txt_rfid.Text,
                    Lastname = txt_lastname.Text,
                    Firstname = txt_firstname.Text,
                    Middlename = txt_middlename.Text,
                    Suffix = txt_suffix.Text,
                    Extensionname = txt_extensionname.Text,
                    Birthdate = txt_birthdate.Value,
                    Gender = isgen,
                    FkProvince = provinceSelectedValue,
                    FkTowncity = towncitySelectedValue,
                    FkBarangay = barangaySelectedValue,
                    Address1 = address1,
                    Address2 = address2,
                    Address3 = address3,
                    FkZipcode = zipcodeSelectedValue,
                    FkCivilstatus = Convert.ToInt32(txt_civilstatus.SelectedValue),
                    FkReligion = Convert.ToInt32(txt_religion.SelectedValue),
                    FkNationality = Convert.ToInt32(txt_natinality.SelectedValue),
                    Bloodtype = txt_bloodtype.Text,
                    Telephoneno = txt_telephoneno.Text,
                    Cellno = txt_cellno.Text,
                    Email = txt_emailaddress.Text,
                    FkEducationallevel = Convert.ToInt32(txt_educatinlevel.SelectedValue),
                    FkBankName = Convert.ToInt32(txt_bank.SelectedValue),
                    Accountno = txt_accountnumber.Text,
                    Contactperson = txt_emergencyContactName.Text,
                    FkRelationship = Convert.ToInt32(txt_relationship_combobox.SelectedValue),
                    Contactno = txt_emergencyContactno.Text,
                    Sssno = txt_sss.Text,
                    Pagibigno = txt_pagibig.Text,
                    Phicno = txt_philhealth.Text,
                    Tinno = txt_tinnumber.Text,
                    IsActive = checkBox_isactive.Checked,
                    ProfilePicture = imageData,
                    Createdby = createdby,
                    FkSystemUser = id,
                    Employeetype = label_Headername.Text
                };
                if (employee_Presenter.AddEmployee(cv) != true)
                {
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    // Display the inner exception details
                    MessageBox.Show($"An error occurred while saving the entity changes. Inner exception: {ex.InnerException.Message}");
                }
                else
                {
                    // Display the exception message if there is no inner exception
                    MessageBox.Show($"An error occurred while saving the entity changes. Exception: {ex.Message}");
                }
            }



        }

        private void updateEmployee()
        {
            // Select the first row in the DataGridView
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Rows[0].Selected = true;
            if (dataGridView.SelectedRows.Count > 0)
            {
                string isgen = string.Empty;
                if (radioButton_male.Checked)
                {
                    isgen = "Male";
                }
                if (radioButton_female.Checked)
                {
                    isgen = "Female";
                }
                //******************
                string? createdby = Properties.Settings.Default.completename;
                int id = Properties.Settings.Default.usercode;
                // Get the selected employee from the UI control
                var selectedPerson = dataGridView.SelectedRows[0].DataBoundItem as Models.Employee;
                if (selectedPerson != null)
                {
                    selectedPerson.Middlename = txt_middlename.Text;
                    selectedPerson.Idno = txt_idno.Text;
                    selectedPerson.Biometricno = txt_biometric.Text;
                    selectedPerson.Rfid = txt_rfid.Text;
                    selectedPerson.Lastname = txt_lastname.Text;
                    selectedPerson.Firstname = txt_firstname.Text;
                    selectedPerson.Middlename = txt_middlename.Text;
                    selectedPerson.Suffix = txt_suffix.Text;
                    selectedPerson.Extensionname = txt_extensionname.Text;
                    selectedPerson.Birthdate = txt_birthdate.Value;
                    selectedPerson.Gender = isgen;
                    selectedPerson.FkProvince = provinceSelectedValue;
                    selectedPerson.FkTowncity = towncitySelectedValue;
                    selectedPerson.FkBarangay = barangaySelectedValue;
                    selectedPerson.Address1 = address1;
                    selectedPerson.Address2 = address2;
                    selectedPerson.Address3 = address3;
                    selectedPerson.FkZipcode = zipcodeSelectedValue;
                    selectedPerson.FkCivilstatus = Convert.ToInt32(txt_civilstatus.SelectedValue);
                    selectedPerson.FkReligion = Convert.ToInt32(txt_religion.SelectedValue);
                    selectedPerson.FkNationality = Convert.ToInt32(txt_natinality.SelectedValue);
                    selectedPerson.Bloodtype = txt_bloodtype.Text;
                    selectedPerson.Telephoneno = txt_telephoneno.Text;
                    selectedPerson.Cellno = txt_cellno.Text;
                    selectedPerson.Email = txt_emailaddress.Text;
                    selectedPerson.FkEducationallevel = Convert.ToInt32(txt_educatinlevel.SelectedValue);
                    selectedPerson.FkBankName = Convert.ToInt32(txt_bank.SelectedValue);
                    selectedPerson.Accountno = txt_accountnumber.Text;
                    selectedPerson.Contactperson = txt_emergencyContactName.Text;
                    selectedPerson.FkRelationship = Convert.ToInt32(txt_relationship_combobox.SelectedValue);
                    selectedPerson.Contactno = txt_emergencyContactno.Text;
                    selectedPerson.Sssno = txt_sss.Text;
                    selectedPerson.Pagibigno = txt_pagibig.Text;
                    selectedPerson.Phicno = txt_philhealth.Text;
                    selectedPerson.Tinno = txt_tinnumber.Text;
                    selectedPerson.IsActive = checkBox_isactive.Checked;
                    //Process image
                    MemoryStream memoryStream = new MemoryStream();
                    profilepic.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    selectedPerson.ProfilePicture = memoryStream.ToArray();
                    //*****
                    selectedPerson.Createdby = createdby;
                    selectedPerson.FkSystemUser = id;
                    selectedPerson.Employeetype = label_Headername.Text;
                    employee_Presenter.updateEmployee(selectedPerson);

                }
            }

        }

        public void DisplayEmployeeAllDetails(List<Models.Employee> employees)
        {
            try
            {
                if (employees != null && employees.Count > 0)
                {
                    Models.Employee employee = employees[0];
                    // Navigation
                    Barangay? barangay = employee.FkBarangayNavigation;
                    txt_employeeid.Text = employee.Idno;
                    txt_firstname.Text = employee.Firstname;
                    txt_lastname.Text = employee.Lastname;
                    txt_idno.Text = employee.Idno;
                    txt_biometric.Text = employee.Biometricno;
                    txt_rfid.Text = employee.Rfid;
                    txt_lastname.Text = employee.Lastname;
                    txt_firstname.Text = employee.Firstname;
                    txt_middlename.Text = employee.Middlename;
                    txt_suffix.Text = employee.Suffix;
                    txt_extensionname.Text = employee.Extensionname;
                    txt_birthdate.Value = employee?.Birthdate ?? DateTime.MinValue;
                    string? gendertype = employee?.Gender;
                    if (gendertype == "Male") { radioButton_male.Checked = true; }
                    if (gendertype == "Female") { radioButton_female.Checked = true; }
                    address1 = employee?.Address1;
                    address2 = employee?.Address2;
                    address3 = employee?.Address3;
                    provinceSelectedValue = employee?.FkProvince != null ? (int)employee.FkProvince : 0;
                    towncitySelectedValue = employee?.FkTowncity != null ? (int)employee.FkTowncity : 0;
                    barangaySelectedValue = employee?.FkBarangay != null ? (int)employee.FkBarangay : 0;
                    zipcodeSelectedValue = employee?.FkZipcode != null ? (int)employee.FkZipcode : 0;
                    txt_completeaddress.Text = employee?.Address1 + " " + employee?.Address2 + " " + employee?.Address3
                        + " " + employee?.FkBarangayNavigation?.Description
                        + " " + employee?.FkTowncityNavigation?.Description
                        + " " + employee?.FkProvinceNavigation?.Description
                         + " " + employee?.FkZipcodeNavigation?.Zipcode1;

                    txt_civilstatus.SelectedValue = employee?.FkCivilstatus;
                    txt_religion.SelectedValue = employee?.FkReligion;
                    txt_natinality.SelectedValue = employee?.FkNationality;
                    txt_bloodtype.Text = employee?.Bloodtype;
                    txt_telephoneno.Text = employee?.Telephoneno;
                    txt_cellno.Text = employee?.Cellno;
                    txt_emailaddress.Text = employee?.Email;
                    txt_educatinlevel.SelectedValue = employee?.FkEducationallevel;
                    txt_bank.SelectedValue = employee?.FkBankName;
                    txt_accountnumber.Text = employee?.Accountno;
                    txt_emergencyContactName.Text = employee?.Contactperson;
                    txt_relationship_combobox.SelectedValue = employee?.FkRelationship;
                    txt_emergencyContactno.Text = employee?.Contactno;
                    txt_sss.Text = employee?.Sssno;
                    txt_pagibig.Text = employee?.Pagibigno;
                    txt_philhealth.Text = employee?.Phicno;
                    txt_tinnumber.Text = employee?.Tinno;
                    checkBox_isactive.Checked = employee?.IsActive ?? false;
                    if (employee?.ProfilePicture != null)
                    {
                        Byte[] img;
                        img = employee.ProfilePicture;
                        MemoryStream memoryStream = new MemoryStream(img);
                        profilepic.Image = Image.FromStream(memoryStream);
                        picture_avatar.Image = Image.FromStream(memoryStream);
                    }
                    string? mdname = employee?.Middlename;
                    char md;
                    if (mdname != null && mdname.Length > 0)
                    {
                        md = mdname[0];
                        mdname = md.ToString() + ". ";
                    }
                    txt_Headercompletename.Text = employee?.Firstname + " " + mdname + employee?.Lastname;
                    employeeid = employee?.PkEmployee ?? 0;
                    btn_save.Text = "Update";
                    btn_cancel.Select();
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"An error occurred while saving the entity changes. Inner exception: {ex.InnerException.Message}");
                }
                else
                {
                    MessageBox.Show($"An error occurred while saving the entity changes. Exception: {ex.Message}");
                }
            }
            dataGridView.DataSource = employees;
            this.Controls.Add(dataGridView);
        }

        public void DisplayEmployeeCustomView(List<object> employees)
        {
            throw new NotImplementedException();
        }
    }
}
