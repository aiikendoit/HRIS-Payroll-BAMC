using HRIS.Forms.Maintenance.CivilStatus;
using HRIS.Forms.Maintenance.EducationaLevel;
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

namespace HRIS.Views.Forms.Maintenance.EducationaLevel
{
    public partial class frm_educationllevel_add : Form, IEducationLevelView
    {
        private readonly educationlevel_Presenter educationlevel_Presenter;
        private EducationalLevelForm educationalLevelForm;
        private Models.Educationallevel selected_educationallevel;
        public frm_educationllevel_add()
        {
            InitializeComponent();
            educationlevel_Presenter = new educationlevel_Presenter(this);
            this.educationalLevelForm = new EducationalLevelForm();
            this.selected_educationallevel = new Educationallevel();

        }

        public void DisplayEducationalLevel(List<Educationallevel> Educationallevels)
        {
            //
        }
        private void save()
        {
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Models.Educationallevel
            {
                Description = txt_educationallevel.Text,
                Isactive = checkBox_isactive.Checked,
                //Createdby = createdby,
                //FkSystemUser = id
            };
            educationlevel_Presenter.AddEducationalLevel(cv);
            MessageBox.Show("Added Successfully!");
            this.Close();
        }
        private void update()
        {
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var selectper = selected_educationallevel as Educationallevel;

            selectper.Description = txt_educationallevel.Text;
            selectper.Isactive = checkBox_isactive.Checked;
            selectper.Createdby = createdby;
            selectper.FkSystemUser = id;

            educationlevel_Presenter.UpdateEducationalLevel(selectper);
            MessageBox.Show("Updated Successfully!");
            this.Close();
        }
        public void putdata(EducationalLevelForm educationalLevelForm, Models.Educationallevel educationallevel)
        {
            this.educationalLevelForm = educationalLevelForm;
            this.selected_educationallevel = educationallevel;
            txt_educationallevel.Text = selected_educationallevel.Description;
            checkBox_isactive.Checked = selected_educationallevel.Isactive;
            btn_save.Text = "Update";
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
    }
}
