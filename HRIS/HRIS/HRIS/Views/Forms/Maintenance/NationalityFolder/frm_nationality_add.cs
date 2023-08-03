using HRIS.Class;
using HRIS.Forms.Maintenance.Degreetype;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.NationalityFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Views.Forms.Maintenance.ReligionFolder
{
    public partial class frm_nationality_add : Form, INationalityView
    {
        private readonly nationality_Presenter nationality_Presenter;
        private NationalityForm nationalityForm;
        private Models.Nationality Selectednationality;
        public bool isupdate = false;
        public frm_nationality_add()
        {
            InitializeComponent();
            nationality_Presenter = new nationality_Presenter(this);
            this.Selectednationality = new Models.Nationality();
            this.nationalityForm = new NationalityForm();
        }
        public void putdata(NationalityForm nationalityForm, Models.Nationality nationality)
        {
            if (isupdate)
            {
                btn_cancel.Select();
                this.nationalityForm = nationalityForm;
                this.Selectednationality = nationality;
                txt_nationality.Text = Selectednationality.Description;
                checkBox_isactive.Checked = Selectednationality.IsActive;
            }
            else
            {
                btn_cancel.Select();
                this.nationalityForm = nationalityForm;
                this.Selectednationality = nationality;
                txt_nationality.Text = Selectednationality.Description;
                checkBox_isactive.Checked = Selectednationality.IsActive;
                //disable control
                txt_nationality.Enabled = false;
                checkBox_isactive.Enabled = false;
                btn_save.Visible = false;
            }
        }
        private void save()
        {
            if (UniversalStatic.IsEmpty(txt_nationality)) return;
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Models.Nationality
            {
                Description = txt_nationality.Text,
                IsActive = checkBox_isactive.Checked,
                Createdby = createdby,
                FkSystemUser = id
            };
            nationality_Presenter.AddNationality(cv);
            this.Close();
        }
        private void update()
        {

            var selectedNationality = Selectednationality as Models.Nationality;

            selectedNationality.Description = txt_nationality.Text;
            selectedNationality.IsActive = checkBox_isactive.Checked;
            nationality_Presenter.UpdateNationality(selectedNationality);
            this.Close();
        }
        public void ClearFields()
        {

        }

        public void DisplayNationality(List<Nationality> Nationalities)
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
