using HRIS.Forms.Maintenance.CivilStatus;
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
using System.Windows.Forms.VisualStyles;

namespace HRIS.Views.Forms.Maintenance.CivilStatus
{
    public partial class frm_civilstatus_add : Form, ICivilStatusView
    {
        private readonly civilStatus_Presenter civilStatus_Presenter;
        private CivilStatusForm civilStatusForm;
        private Civilstatus selectedCivilStatus;
        public frm_civilstatus_add()
        {
            InitializeComponent();
            this.civilStatusForm = new CivilStatusForm();
            this.selectedCivilStatus = new Civilstatus();
            civilStatus_Presenter = new civilStatus_Presenter(this);
            btn_save.Select();
        }

        public void ClearFields()
        {
            txt_civilstatus.Clear();
        }

        public void DisplayEmployees(List<Civilstatus> Civilstatuses)
        {

        }
        public void putdata(CivilStatusForm civilStatusForm, Civilstatus civilstatus)
        {
            this.civilStatusForm = civilStatusForm;
            this.selectedCivilStatus = civilstatus;
            txt_civilstatus.Text = selectedCivilStatus.Description;
            checkBox_isactive.Checked = selectedCivilStatus.IsActive;
            btn_save.Text = "Update";
        }
        private void save()
        {
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Civilstatus
            {
                Description = txt_civilstatus.Text,
                IsActive = checkBox_isactive.Checked,
                Createdby = createdby,
                FkSystemUser = id
            };
            civilStatus_Presenter.AddCivilStatus(cv);
            MessageBox.Show("Added Successfully!");
            this.Close();
        }
        private void update()
        {
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var selectper = selectedCivilStatus as Civilstatus;

            selectper.Description = txt_civilstatus.Text;
            selectper.IsActive = checkBox_isactive.Checked;
            selectper.Createdby = createdby;
            selectper.FkSystemUser = id;

            civilStatus_Presenter.UpdateCivilStatus(selectper);
            MessageBox.Show("Updated Successfully!");
            this.Close();
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

        private void frm_civilstatus_add_Load(object sender, EventArgs e)
        {

        }
    }
}
