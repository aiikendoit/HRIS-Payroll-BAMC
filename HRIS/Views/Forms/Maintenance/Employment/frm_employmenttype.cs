using HRIS.Forms.Maintenance.Degreetype;
using HRIS.Forms.Maintenance.Employment;
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

namespace HRIS.Views.Forms.Maintenance.Employment
{
    public partial class frm_employmenttype : Form, IEmploymentTypeView
    {
        private readonly employmenttype_Presenter employmenttype_Presenter;
        private EmploymentTypeForm EmploymentTypeForm;
        private Models.Employmenttype Selectedemploymenttype;
        public bool isupdate = false;
        public frm_employmenttype()
        {
            InitializeComponent();
            employmenttype_Presenter = new employmenttype_Presenter(this);
            this.Selectedemploymenttype = new Models.Employmenttype();
            this.EmploymentTypeForm = new EmploymentTypeForm();
        }
        public void putdata(EmploymentTypeForm employmentTypeForm, Models.Employmenttype employmenttype)
        {
            if (isupdate)
            {
                btn_cancel.Select();
                this.EmploymentTypeForm = employmentTypeForm;
                this.Selectedemploymenttype = employmenttype;
                txt_employmenttype.Text = Selectedemploymenttype.Description;
                checkBox_isactive.Checked = Selectedemploymenttype.IsActive;
                checkBox_organicemployee.Checked = Selectedemploymenttype.IsOrganic;
                checkBox_inorganicemployee.Checked = Selectedemploymenttype.IsInOrganic;
            }
            else
            {
                btn_cancel.Select();
                this.EmploymentTypeForm = employmentTypeForm;
                this.Selectedemploymenttype = employmenttype;
                txt_employmenttype.Text = Selectedemploymenttype.Description;
                checkBox_isactive.Checked = Selectedemploymenttype.IsActive;
                checkBox_organicemployee.Checked = Selectedemploymenttype.IsOrganic;
                checkBox_inorganicemployee.Checked = Selectedemploymenttype.IsInOrganic;
                //disable control
                txt_employmenttype.Enabled = false;
                checkBox_isactive.Enabled = false;
                btn_save.Visible = false;
            }
        }
        private void save()
        {
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Models.Employmenttype
            {
                Description = txt_employmenttype.Text,
                IsActive = checkBox_isactive.Checked,
                IsOrganic = checkBox_organicemployee.Checked,
                IsInOrganic = checkBox_inorganicemployee.Checked,
                Createdby = createdby,
                FkSystemUser = id
            };
            employmenttype_Presenter.AddEmploymenttype(cv);
            this.Close();
        }
        private void update()
        {

            var selEmType = Selectedemploymenttype as Models.Employmenttype;

            selEmType.Description = txt_employmenttype.Text;
            selEmType.IsActive = checkBox_isactive.Checked;
            selEmType.IsOrganic = checkBox_organicemployee.Checked;
            selEmType.IsInOrganic = checkBox_inorganicemployee.Checked;
            employmenttype_Presenter.UpdateEmployment(selEmType);
            this.Close();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DisplayEmployment(List<Employmenttype> employments)
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

        public void DsiplayEmploymentCustom(List<object> Employmentlist)
        {
            // throw new NotImplementedException();
        }
    }
}
