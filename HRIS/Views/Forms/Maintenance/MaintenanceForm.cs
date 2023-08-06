using FontAwesome.Sharp;
using HRIS.Class;
using HRIS.Forms.Maintenance.Bank;
using HRIS.Forms.Maintenance.Barangay;
using HRIS.Forms.Maintenance.CivilStatus;
using HRIS.Forms.Maintenance.Degreetype;
using HRIS.Forms.Maintenance.Department;
using HRIS.Forms.Maintenance.Disciplinary;
using HRIS.Forms.Maintenance.Document;
using HRIS.Forms.Maintenance.EducationaLevel;
using HRIS.Forms.Maintenance.Employment;
using HRIS.Forms.Maintenance.Leaves;
using HRIS.Forms.Maintenance.License;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance;
using HRIS.Views.Forms.Maintenance.AddressFolder.ProvincesFolder;
using HRIS.Views.Forms.Maintenance.Leaves;
using HRIS.Views.Forms.Maintenance.NationalityFolder;
using HRIS.Views.Forms.Maintenance.Offensetype;
using HRIS.Views.Forms.Maintenance.Positions;
using HRIS.Views.Forms.Maintenance.RelationShip;
using HRIS.Views.Forms.Maintenance.Religion;
using HRIS.Views.Forms.Maintenance.SalarySetting;
using HRIS.Views.Forms.Maintenance.WageFactor;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Maintenance
{
    public partial class MaintenanceForm : Form, ICompanyInformationView
    {
        private Form currentchildform;
        string? address1, address2, address3;
        int regionSelectedValue, provinceSelectedValue, towncitySelectedValue, barangaySelectedValue, zipcodeSelectedValue;
        private IconButton currentbtn;
        private int companyid;
        private readonly HrisContext _context;
        private readonly companyInformation_Presenter companyInformation_Presenter;
        public MaintenanceForm()
        {
            InitializeComponent();
            currentbtn = new IconButton();
            currentchildform = new Form();
            companyInformation_Presenter = new companyInformation_Presenter(this);
            _context = new HrisContext();
            loadInfo();
        }

        private void MaintenanceForm_Load(object sender, EventArgs e)
        {

        }
        #region "Codes"

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
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif|All Files (*.*)|*.*";
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                Image image = Image.FromFile(filePath); picture_logo.Image = image;
                picture_logo.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void iconButton18_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new ReligionForm());
        }

        private void btn_basicinformation_Click(object sender, EventArgs e)
        {
            reset();
            activatebutton(sender, ColorPalette.color5);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new BarangayForm());
        }

        private void btn_bank_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new BankForm());
        }

        private void btn_civilstatus_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new CivilStatusForm());
        }

        private void btn_degreetype_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new DegreetypeForm());
        }

        private void btn_department_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new DepartmentForm());
        }

        private void btn_disciplinary_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new DiscplinaryForm());
        }

        private void btn_documenttype_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new DocumentTypeForm());
        }

        private void btn_educationalLevel_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new EducationalLevelForm());
        }

        private void btn_employmenttype_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new EmploymentTypeForm());
        }

        private void btn_leavenoticeType_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new LeaveNoticeTypeForm());
        }

        private void btn_licenseType_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new LicenseType());
        }

        private void btn_nationality_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new NationalityForm());
        }

        private void btn_relationship_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new RelationshipForm());
        }

        private void iconButton16_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new PositionForm());
        }

        private void txt_emailaddress_Leave(object sender, EventArgs e)
        {
            string email = txt_emailaddress.Text;
            bool isValid = UniversalStatic.IsValidEmail(email);
            if (isValid == false)
            {
                MessageBox.Show("Email is not valid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_emailaddress.Select();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (UniversalStatic.IsEmpty(txt_organizationname)) return;
            if (UniversalStatic.IsEmpty(txt_owner)) return;
            if (UniversalStatic.IsEmpty(txt_website)) return;
            if (UniversalStatic.IsEmpty(txt_emailaddress)) return;
            if (UniversalStatic.IsEmpty(txt_telephone)) return;

            if (btn_save.Text == "Save")
            {
                save();
            }
            if (btn_save.Text == "Update")
            {
                update();
            }

        }
        private void save()
        {
            try
            {
                //Stored image data
                Image profileImage = picture_logo.Image;
                byte[] imageData;
                using (MemoryStream ms = new MemoryStream())
                {
                    profileImage.Save(ms, profileImage.RawFormat);
                    imageData = ms.ToArray();
                }
                //******************
                var comInfo = new Models.CompanyInfo()
                {
                    Organizationname = txt_organizationname.Text,
                    Owner = txt_owner.Text,
                    Website = txt_website.Text,
                    Emailaddress = txt_emailaddress.Text,
                    Telephone = txt_telephone.Text,
                    Fax = txt_fax.Text,
                    Address1 = address1,
                    Address2 = address2,
                    Address3 = address3,
                    FkBarangay = barangaySelectedValue,
                    FkTowncity = towncitySelectedValue,
                    FkProvince = provinceSelectedValue,
                    FkZipcode = zipcodeSelectedValue,
                    Logo = imageData
                };
                companyInformation_Presenter.AddCompanyInformation(comInfo);
                loadInfo();
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
        }
        private void update()
        {
            try
            {
                var existingCompanyInfo = _context.CompanyInfos.Find(companyid);
                //Stored image data
                Image profileImage = picture_logo.Image;
                byte[] imageData;
                using (MemoryStream ms = new MemoryStream())
                {
                    profileImage.Save(ms, profileImage.RawFormat);
                    imageData = ms.ToArray();
                }
                //******************
                if (existingCompanyInfo != null)
                {
                    existingCompanyInfo.Organizationname = txt_organizationname.Text;
                    existingCompanyInfo.Owner = txt_owner.Text;
                    existingCompanyInfo.Website = txt_website.Text;
                    existingCompanyInfo.Emailaddress = txt_emailaddress.Text;
                    existingCompanyInfo.Telephone = txt_telephone.Text;
                    existingCompanyInfo.Fax = txt_fax.Text;
                    existingCompanyInfo.Address1 = address1;
                    existingCompanyInfo.Address2 = address2;
                    existingCompanyInfo.Address3 = address3;
                    existingCompanyInfo.FkBarangay = barangaySelectedValue;
                    existingCompanyInfo.FkTowncity = towncitySelectedValue;
                    existingCompanyInfo.FkProvince = provinceSelectedValue;
                    existingCompanyInfo.FkZipcode = zipcodeSelectedValue;
                    existingCompanyInfo.Logo = imageData;
                    companyInformation_Presenter.UpdateWorkAssignment(existingCompanyInfo);

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
        private void loadInfo()
        {
            if (companyInformation_Presenter.LoadCompanyInfo())
            {
                btn_save.Text = "Update";
                btn_cancel.Select();
            }

        }

        public void DisplayCompanyInfo(CompanyInfo? p)
        {
            try
            {
                if (p != null)
                {
                    Models.CompanyInfo com = p;
                    companyid = com.PkCompanyInfo;
                    txt_organizationname.Text = com.Organizationname;
                    txt_owner.Text = com.Owner;
                    txt_website.Text = com.Website;
                    txt_emailaddress.Text = com.Emailaddress;
                    txt_telephone.Text = com.Telephone;
                    txt_fax.Text = com.Fax;
                    txt_completeaddress.Text = com.Address1 + " " + com.Address2 + " " + com.Address3
                        + " " + com.FkBarangayNavigation?.Description + " " + com.FkTowncityNavigation?.Description
                        + " " + com.FkProvinceNavigation?.Description + " " + com.FkZipcodeNavigation?.Zipcode1;
                    address1 = com?.Address1;
                    address2 = com?.Address2;
                    address3 = com?.Address3;
                    provinceSelectedValue = com?.FkProvince != null ? (int)com.FkProvince : 0;
                    towncitySelectedValue = com?.FkTowncity != null ? (int)com.FkTowncity : 0;
                    barangaySelectedValue = com?.FkBarangay != null ? (int)com.FkBarangay : 0;
                    zipcodeSelectedValue = com?.FkZipcode != null ? (int)com.FkZipcode : 0;
                    if (com?.Logo != null)
                    {
                        Byte[] img;
                        img = com.Logo;
                        MemoryStream memoryStream = new MemoryStream(img);
                        picture_logo.Image = Image.FromStream(memoryStream);
                    }
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
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_leaveType_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new LeaveTypeForm());
        }

        private void btn_offencetype_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new OffenceTypeForm());
        }

        private void btn_province_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new ProvinceForm());
        }

        private void btn_salarysetting_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new SalarySettingForm());
        }

        private void btn_wagefactor_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new WageFactorForm());
        }
    }
}
