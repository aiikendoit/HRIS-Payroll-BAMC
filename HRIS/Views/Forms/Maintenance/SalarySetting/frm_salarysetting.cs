using HRIS.Class;
using HRIS.Forms.Maintenance.License;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.Employment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Views.Forms.Maintenance.SalarySetting
{
    public partial class frm_salarysetting : Form, ISalarySettingView, IEmploymentTypeView
    {
        private readonly salarysetting_Presenter salarysetting_Presenter;
        private readonly employmenttype_Presenter employmenttype_Presenter;
        private SalarySettingForm SalarySettingForm;
        private Models.Salarytype Selectedsalarytype;
        public bool isupdate = false;
        public frm_salarysetting()
        {
            InitializeComponent();
            salarysetting_Presenter = new salarysetting_Presenter(this);
            employmenttype_Presenter = new employmenttype_Presenter(this);
            this.Selectedsalarytype = new Models.Salarytype();
            this.SalarySettingForm = new SalarySettingForm();
            employmenttype_Presenter.LoadEmployment();
            //check
            
        }
        public void putdata(SalarySettingForm salarySettingForm, Models.Salarytype salarytype)
        {
            if (isupdate)
            {
                btn_cancel.Select();
                this.SalarySettingForm = salarySettingForm;
                this.Selectedsalarytype = salarytype;
                txt_employmenttype.SelectedValue = Selectedsalarytype.FkEmploymenttype;
                txt_salarytype.Text = Selectedsalarytype.Description;
                checkBox_isactive.Checked = Selectedsalarytype.IsActive;
                checkBox_13month.Checked = Selectedsalarytype.IsThirteenMonth;
                checkBox_bonus.Checked = Selectedsalarytype.IsBonus;
                checkBox_cola.Checked = Selectedsalarytype.IsCola;
                checkBox_isBasicpay.Checked = Selectedsalarytype.IsBasicPay;
                checkBox_taxable.Checked = Selectedsalarytype.IsTaxable;
            }
            else
            {
                btn_cancel.Select();
                this.SalarySettingForm = salarySettingForm;
                this.Selectedsalarytype = salarytype;
                txt_employmenttype.SelectedValue = Selectedsalarytype.FkEmploymenttype;
                txt_salarytype.Text = Selectedsalarytype.Description;
                checkBox_isactive.Checked = Selectedsalarytype.IsActive;
                checkBox_13month.Checked = Selectedsalarytype.IsThirteenMonth;
                checkBox_bonus.Checked = Selectedsalarytype.IsBonus;
                checkBox_cola.Checked = Selectedsalarytype.IsCola;
                checkBox_isBasicpay.Checked = Selectedsalarytype.IsBasicPay;
                checkBox_taxable.Checked = Selectedsalarytype.IsTaxable;
                //disable control
                txt_employmenttype.Enabled = false;
                txt_salarytype.Enabled = false;
                foreach (Control control in this.Controls)
                {
                    if (control is CheckBox checkbox)
                    {
                        checkbox.Enabled = false;
                    }
                }
                btn_save.Visible = false;
            }
        }
        private void save()
        {
            if (UniversalStatic.IsEmpty(txt_salarytype)) return;
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Models.Salarytype
            {
                FkEmploymenttype = Convert.ToInt32(txt_employmenttype.SelectedValue),
                Description = txt_salarytype.Text,
                IsActive = checkBox_isactive.Checked,
                IsBasicPay = checkBox_isBasicpay.Checked,
                IsBonus = checkBox_bonus.Checked,
                IsCola = checkBox_cola.Checked,
                IsPercentage = Checkbox_isPercentage.Checked,
                IsTaxable = checkBox_taxable.Checked,
                IsThirteenMonth = checkBox_13month.Checked,
                Createdby = createdby,
                FkSystemUser = id
            };
            salarysetting_Presenter.AddSalarysetting(cv);
            this.Close();
        }
        private void update()
        {

            var selectedsalary = Selectedsalarytype as Models.Salarytype;

            selectedsalary.Description = txt_salarytype.Text;
            selectedsalary.IsActive = checkBox_isactive.Checked;
            selectedsalary.IsBasicPay = checkBox_isBasicpay.Checked;
            selectedsalary.IsBonus = checkBox_bonus.Checked;
            selectedsalary.IsCola = checkBox_cola.Checked;
            selectedsalary.IsPercentage = Checkbox_isPercentage.Checked;
            selectedsalary.IsTaxable = checkBox_taxable.Checked;
            selectedsalary.IsThirteenMonth = checkBox_13month.Checked;
            salarysetting_Presenter.UpdateSalarysetting(selectedsalary);
            this.Close();
        }
        public void DisplaySalarysetting(List<Salarytype> salarytypes)
        {

        }

        public void DisplayEmployment(List<Employmenttype> employments)
        {
            txt_employmenttype.DataSource = employments;
            txt_employmenttype.ValueMember = "PKEmploymenttype";
            txt_employmenttype.DisplayMember = "Description";

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
