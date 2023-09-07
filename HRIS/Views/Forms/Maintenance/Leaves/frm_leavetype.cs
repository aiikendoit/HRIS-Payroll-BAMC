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

namespace HRIS.Views.Forms.Maintenance.Leaves
{
    public partial class frm_leavetype : Form, ILeaveTypeView
    {
        private readonly leavetype_Presenter leavetype_Presenter;
        private LeaveTypeForm LeaveTypeForm;
        private Models.Leavetype Selectedleavetype;
        public bool isupdate = false;
        public frm_leavetype()
        {
            InitializeComponent();
            leavetype_Presenter = new leavetype_Presenter(this);
            this.Selectedleavetype = new Models.Leavetype();
            this.LeaveTypeForm = new LeaveTypeForm();
        }
        public void putdata(LeaveTypeForm leaveTypeForm, Models.Leavetype leavetype)
        {
            if (isupdate)
            {
                btn_cancel.Select();
                this.LeaveTypeForm = leaveTypeForm;
                this.Selectedleavetype = leavetype;
                txt_leavetype.Text = Selectedleavetype.Description;
                checkBox_isactive.Checked = Selectedleavetype.Isactive;
                checkBox_isPaid.Checked = Selectedleavetype.IsPaid;
            }
            else
            {
                btn_cancel.Select();
                this.LeaveTypeForm = leaveTypeForm;
                this.Selectedleavetype = leavetype;
                txt_leavetype.Text = Selectedleavetype.Description;
                checkBox_isactive.Checked = Selectedleavetype.Isactive;
                checkBox_isPaid.Checked = Selectedleavetype.IsPaid;
                //disable control
                txt_leavetype.Enabled = false;
                checkBox_isactive.Enabled = false;
                checkBox_isPaid.Enabled = false;
                btn_save.Visible = false;
            }
        }
        private void save()
        {
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Models.Leavetype
            {
                Description = txt_leavetype.Text,
                Isactive = checkBox_isactive.Checked,
                IsPaid = checkBox_isPaid.Checked,
                Createdby = createdby,
                FkSystemUser = id
            };
            leavetype_Presenter.AddLeavetype(cv);
            this.Close();
        }
        private void update()
        {

            var selectedleave = Selectedleavetype as Models.Leavetype;

            selectedleave.Description = txt_leavetype.Text;
            selectedleave.Isactive = checkBox_isactive.Checked;
            selectedleave.IsPaid = checkBox_isPaid.Checked;
            leavetype_Presenter.UpdateLeavetype(selectedleave);
            this.Close();
        }
        public void DisplayLeavetype(List<Leavetype> leavetypeList)
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
