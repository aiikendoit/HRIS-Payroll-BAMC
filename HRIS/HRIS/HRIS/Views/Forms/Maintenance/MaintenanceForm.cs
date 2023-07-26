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
using HRIS.Forms.Maintenance.Leaves;
using HRIS.Forms.Maintenance.License;
using HRIS.Views.Forms.Maintenance.NationalityFolder;
using HRIS.Views.Forms.Maintenance.Positions;
using HRIS.Views.Forms.Maintenance.RelationShip;
using HRIS.Views.Forms.Maintenance.Religion;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Maintenance
{
    public partial class MaintenanceForm : Form
    {
        private Form currentchildform;
        string? address1, address2, address3, regionSelectedValue, provinceSelectedValue, towncitySelectedValue, barangaySelectedValue, zipcode;
        private IconButton currentbtn;
        public MaintenanceForm()
        {
            InitializeComponent();
            currentbtn = new IconButton();
            currentchildform = new Form();
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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                Image image = Image.FromFile(filePath); pictureBox2.Image = image;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_AddressMaintenance addrs = new frm_AddressMaintenance();
            addrs.ShowDialog();

            //if (addrs.issave == true)
            //{
            //    //set value
            //    address1 = addrs.address1.ToString();
            //    address2 = addrs.address2.ToString();
            //    address3 = addrs.address3.ToString();
            //    regionSelectedValue = addrs.regionSelectedvalue.ToString();
            //    provinceSelectedValue = addrs.provinceSelectedvalue.ToString();
            //    towncitySelectedValue = addrs.towncitySelectedvalue.ToString();
            //    barangaySelectedValue = addrs.barangaySelectedvalue.ToString();
            //    zipcode = addrs.zipcodeSelectedvalue.ToString();
            //    txt_completeaddress.Text = addrs.completeaddress.ToString();
            //}

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
            openchildform(new EducationalLevelForm());
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
    }
}
