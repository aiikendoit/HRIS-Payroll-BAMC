using HRIS.Class;
using HRIS.Forms.Maintenance.Degreetype;
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

namespace HRIS.Views.Forms.Maintenance.Degreetype
{
    public partial class frm_degreeType : Form, IDegreeTypeView
    {
        private readonly degreetype_Presenter degreetype_Presenter;
        private DegreetypeForm degreetypeForm;
        private Models.Degreetype Selecteddegreetype;
        public bool isupdate = false;
        public frm_degreeType()
        {
            InitializeComponent();
            degreetype_Presenter = new degreetype_Presenter(this);
            this.Selecteddegreetype = new Models.Degreetype();
            this.degreetypeForm = new DegreetypeForm();
        }

        public void DisplayDegreetype(List<Models.Degreetype> degreetypes)
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
        public void putdata(DegreetypeForm degreetypeForm, Models.Degreetype degreetype)
        {
            if (isupdate)
            {
                btn_cancel.Select();
                this.degreetypeForm = degreetypeForm;
                this.Selecteddegreetype = degreetype;
                txt_degreetype.Text = Selecteddegreetype.Description;
                checkBox_isactive.Checked = Selecteddegreetype.IsActive;
                btn_save.Text = "Update";
            }
            else
            {
                this.degreetypeForm = degreetypeForm;
                this.Selecteddegreetype = degreetype;
                txt_degreetype.Text = Selecteddegreetype.Description;
                checkBox_isactive.Checked = Selecteddegreetype.IsActive;
                //disable control
                txt_degreetype.Enabled = false;
                checkBox_isactive.Enabled = false;
                btn_save.Visible = false;
            }
        }
        private void save()
        {
            if (UniversalStatic.IsEmpty(txt_degreetype)) return;
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Models.Degreetype
            {
                Description = txt_degreetype.Text,
                IsActive = checkBox_isactive.Checked,
                Createdby = createdby,
                FkSystemUser = id
            };
            degreetype_Presenter.AddDegreeType(cv);
            this.Close();
        }
        private void update()
        {

            var seldegretype = Selecteddegreetype as Models.Degreetype;

            seldegretype.Description = txt_degreetype.Text;
            seldegretype.IsActive = checkBox_isactive.Checked;
            degreetype_Presenter.UpdateDegreeType(seldegretype);
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
