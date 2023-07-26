using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.ReligionFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Views.Forms.Maintenance.Religion
{
    public partial class frm_religion_Add : Form, IReligionView
    {
        private readonly religion_Presenter religion_Presenter;
        private ReligionForm religionForm;
        private Models.Religion selectedReligion;
        public frm_religion_Add()
        {
            InitializeComponent();
            religion_Presenter = new religion_Presenter(this);
           this.selectedReligion = new Models.Religion();
           this.religionForm = new ReligionForm();
           this.Select();

        }

        private void frm_religion_Add_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (btn_save.Text == "Save")
            {
                save();
            }
            if (btn_save.Text == "Update")
            {
                update();
            }
        }
        public void putdata(ReligionForm religionForm, Models.Religion selectedreligion)
        {
            this.religionForm = religionForm;
            this.selectedReligion = selectedreligion;
            txt_religion.Text = selectedreligion.Description;
            checkBox_isactive.Checked = selectedreligion.IsActive;
            btn_save.Text = "Update";
        }
        private void save()
        {
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Models.Religion
            {
                Description = txt_religion.Text,
                IsActive = checkBox_isactive.Checked,
                Createdby = createdby,
                FkSystemUser = id
            };
            religion_Presenter.AddReligion(cv);
            MessageBox.Show("Added Successfully!","Success");
            this.Close();
        }
        private void update()
        {
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var selectper = selectedReligion as Models.Religion;

            selectper.Description = txt_religion.Text;
            selectper.IsActive = checkBox_isactive.Checked;
            selectper.Createdby = createdby;
            selectper.FkSystemUser = id;

            religion_Presenter.UpdateReligion(selectper);
            MessageBox.Show("Updated Successfully!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }

        public void DisplayReligion(List<Models.Religion> Religions)
        {
            
        }

        public void ClearFields()
        {
            txt_religion.Text = string.Empty;
        }
    }
}
