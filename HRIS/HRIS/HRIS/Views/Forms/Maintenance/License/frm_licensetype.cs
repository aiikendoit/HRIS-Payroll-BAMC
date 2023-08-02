using HRIS.Class;
using HRIS.Forms.Maintenance.Degreetype;
using HRIS.Forms.Maintenance.License;
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

namespace HRIS.Views.Forms.Maintenance.License
{
    public partial class frm_licensetype : Form, ILicenseTypeView
    {
        private readonly licensetype_Presenter licensetype_Presenter;
        private LicenseType licenseTypeForm;
        private Models.Licensetype selectedlicensetype;
        public bool isupdate = false;
        public frm_licensetype()
        {
            InitializeComponent();
            licensetype_Presenter = new licensetype_Presenter(this);
            this.selectedlicensetype = new Models.Licensetype();
            this.licenseTypeForm = new LicenseType();
        }
        public void putdata(LicenseType licenseTypeForm, Models.Licensetype licensetype)
        {
            if (isupdate)
            {
                btn_cancel.Select();
                this.licenseTypeForm = licenseTypeForm;
                this.selectedlicensetype = licensetype;
                txt_leavetype.Text = selectedlicensetype.Description;
                checkBox_isactive.Checked = selectedlicensetype.IsActive;
            }
            else
            {
                btn_cancel.Select();
                this.licenseTypeForm = licenseTypeForm;
                this.selectedlicensetype = licensetype;
                txt_leavetype.Text = selectedlicensetype.Description;
                checkBox_isactive.Checked = selectedlicensetype.IsActive;
                //disable control
                txt_leavetype.Enabled = false;
                checkBox_isactive.Enabled = false;
                btn_save.Visible = false;
            }
        }
        private void save()
        {
            if (UniversalStatic.IsEmpty(txt_leavetype)) return;
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Models.Licensetype
            {
                Description = txt_leavetype.Text,
                IsActive = checkBox_isactive.Checked,
                Createdby = createdby,
                FkSystemUser = id
            };
            licensetype_Presenter.Addlicensetype(cv);
            this.Close();
        }
        private void update()
        {

            var selecteleave = selectedlicensetype as Models.Licensetype;

            selecteleave.Description = txt_leavetype.Text;
            selecteleave.IsActive = checkBox_isactive.Checked;
            licensetype_Presenter.UpdateLicense(selecteleave);
            this.Close();
        }
        public void DisplayLicensetype(List<Licensetype> licenseTypes)
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
