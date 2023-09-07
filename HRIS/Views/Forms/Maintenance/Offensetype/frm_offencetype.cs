using HRIS.Class;
using HRIS.Forms.Maintenance.Degreetype;
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

namespace HRIS.Views.Forms.Maintenance.Offensetype
{
    public partial class frm_offencetype : Form, IOffenceTypeView
    {
        private readonly offencetype_Presenter offencetype_Presenter;
        private OffenceTypeForm OffenceTypeForm;
        private Models.Offensetype Selectedoffensetype;
        public bool isupdate = false;
        public frm_offencetype()
        {
            InitializeComponent();
            offencetype_Presenter = new offencetype_Presenter(this);
            this.Selectedoffensetype = new Models.Offensetype();
            this.OffenceTypeForm = new OffenceTypeForm();
        }
        public void putdata(OffenceTypeForm offenceTypeForm, Models.Offensetype offensetype)
        {
            if (isupdate)
            {
                btn_cancel.Select();
                this.OffenceTypeForm = offenceTypeForm;
                this.Selectedoffensetype = offensetype;
                txt_offenctype.Text = Selectedoffensetype.Description;
                txt_severity.Text = Selectedoffensetype.Severity.ToString();
                checkBox_isactive.Checked = Selectedoffensetype.IsActive;
            }
            else
            {
                btn_cancel.Select();
                this.OffenceTypeForm = offenceTypeForm;
                this.Selectedoffensetype = offensetype;
                txt_offenctype.Text = Selectedoffensetype.Description;
                txt_severity.Text = Selectedoffensetype.Severity.ToString();
                checkBox_isactive.Checked = Selectedoffensetype.IsActive;
                //disable control
                txt_offenctype.Enabled = false;
                txt_severity.Enabled = false;
                checkBox_isactive.Enabled = false;
                btn_save.Visible = false;
            }
        }
        private void save()
        {
            if (UniversalStatic.IsEmpty(txt_offenctype)) return;
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Models.Offensetype
            {
                Description = txt_offenctype.Text,
                Severity = Convert.ToInt32(txt_severity.Text),
                IsActive = checkBox_isactive.Checked,
                Createdby = createdby,
                FkSystemUser = id
            };
            offencetype_Presenter.AddOffencetype(cv);
            this.Close();
        }
        private void update()
        {

            var selectedoffence = Selectedoffensetype as Models.Offensetype;

            selectedoffence.Description = txt_offenctype.Text;
            selectedoffence.Severity = Convert.ToInt32(txt_severity.Text);
            selectedoffence.IsActive = checkBox_isactive.Checked;
            offencetype_Presenter.updateOffencetype(selectedoffence);
            this.Close();
        }

        public void DisplayOffencetype(List<Models.Offensetype> offensetypes)
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
