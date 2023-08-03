using HRIS.Forms.Maintenance.Degreetype;
using HRIS.Forms.Maintenance.Leaves;
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

namespace HRIS.Views.Forms.Maintenance.Leaves
{
    public partial class frm_leavenoticetype : Form, ILeaveNoticeTypeView
    {
        private readonly leavenoticetype_Presenter leavenoticetype_Presenter;
        private LeaveNoticeTypeForm LeaveNoticeTypeForm;
        private Models.Leavenoticetype Selectedleavenoticetype;
        public bool isupdate = false;
        public frm_leavenoticetype()
        {
            InitializeComponent();
            leavenoticetype_Presenter = new leavenoticetype_Presenter(this);
            this.Selectedleavenoticetype = new Leavenoticetype();
            this.LeaveNoticeTypeForm = new LeaveNoticeTypeForm();
        }
        public void putdata(LeaveNoticeTypeForm leaveNoticeTypeForm, Models.Leavenoticetype leavenoticetype)
        {
            if (isupdate)
            {
                btn_cancel.Select();
                this.LeaveNoticeTypeForm = leaveNoticeTypeForm;
                this.Selectedleavenoticetype = leavenoticetype;
                txt_leavenoticetype.Text = Selectedleavenoticetype.Description;
                checkBox_isactive.Checked = Selectedleavenoticetype.Isactive;
            }
            else
            {
                btn_cancel.Select();
                this.LeaveNoticeTypeForm = leaveNoticeTypeForm;
                this.Selectedleavenoticetype = leavenoticetype;
                txt_leavenoticetype.Text = Selectedleavenoticetype.Description;
                checkBox_isactive.Checked = Selectedleavenoticetype.Isactive;
                //disable control
                txt_leavenoticetype.Enabled = false;
                checkBox_isactive.Enabled = false;
                btn_save.Visible = false;
            }
        }
        private void save()
        {
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Models.Leavenoticetype
            {
                Description = txt_leavenoticetype.Text,
                Isactive = checkBox_isactive.Checked,
                Createdby = createdby,
                FkSystemUser = id
            };
            leavenoticetype_Presenter.AddLeavenoticetype(cv);
            this.Close();
        }
        private void update()
        {

            var selectedtype = Selectedleavenoticetype as Models.Leavenoticetype;

            selectedtype.Description = txt_leavenoticetype.Text;
            selectedtype.Isactive = checkBox_isactive.Checked;
            leavenoticetype_Presenter.updateleavenotice(selectedtype);
            this.Close();
        }
        public void DisplayLeaveNoticeType(List<Leavenoticetype> leaves)
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
