using HRIS.Class;
using HRIS.Forms.Maintenance.Degreetype;
using HRIS.Forms.Maintenance.Disciplinary;
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

namespace HRIS.Views.Forms.Maintenance.Disciplinary
{
    public partial class frm_disciplinary : Form, IDisciplinaryView
    {
        private readonly disciplinarytype_Presenter disciplinarytype_Presenter;
        private DiscplinaryForm discplinaryForm;
        private Models.Disciplinarytype selecteddisciplinarytype;
        public bool isupdate = false;
        public frm_disciplinary()
        {
            InitializeComponent();
            disciplinarytype_Presenter = new disciplinarytype_Presenter(this);
            this.discplinaryForm = new DiscplinaryForm();
            this.selecteddisciplinarytype = new Models.Disciplinarytype();
        }

        public void DisplayDisciplinaryType(List<Disciplinarytype> disciplinaries)
        {

        }
        private void save()
        {
            if (UniversalStatic.IsEmpty(txt_disciplinarytype)) return;
            if (UniversalStatic.IsEmpty(txt_description)) return;
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var dp = new Models.Disciplinarytype
            {
                Disciplinarytypename = txt_disciplinarytype.Text,
                Disciplinarydescription = txt_description.Text,
                IsActive = checkBox_isactive.Checked,
                Createdby = createdby,
                FkSystemUser = id
            };
            disciplinarytype_Presenter.AddDisciplinary(dp);
            this.Close();
        }
        private void update()
        {
            var selectedDiscp = selecteddisciplinarytype as Models.Disciplinarytype;

            selecteddisciplinarytype.Disciplinarytypename = txt_disciplinarytype.Text;
            selecteddisciplinarytype.Disciplinarydescription = txt_description.Text;
            selecteddisciplinarytype.IsActive = checkBox_isactive.Checked;
            disciplinarytype_Presenter.UpdateDisciplinary(selectedDiscp);
            this.Close();
        }
        public void putdata(DiscplinaryForm discplinaryForm, Disciplinarytype disciplinarytype)
        {
            if (isupdate)
            {
                btn_cancel.Select();
                this.discplinaryForm = discplinaryForm;
                this.selecteddisciplinarytype = disciplinarytype;
                txt_disciplinarytype.Text = selecteddisciplinarytype.Disciplinarytypename;
                txt_description.Text = selecteddisciplinarytype.Disciplinarydescription;
                checkBox_isactive.Checked = selecteddisciplinarytype.IsActive;
            }
            else
            {
                btn_cancel.Select();
                this.discplinaryForm = discplinaryForm;
                this.selecteddisciplinarytype = disciplinarytype;
                txt_disciplinarytype.Text = selecteddisciplinarytype.Disciplinarytypename;
                txt_description.Text = selecteddisciplinarytype.Disciplinarydescription;
                checkBox_isactive.Checked = selecteddisciplinarytype.IsActive;
                //disable control
                btn_save.Visible = false;
                txt_description.Enabled = false;
                txt_disciplinarytype.Enabled = false;
                checkBox_isactive.Enabled = false;
            }
        }
        private void frm_disciplinary_Load(object sender, EventArgs e)
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
    }
}
