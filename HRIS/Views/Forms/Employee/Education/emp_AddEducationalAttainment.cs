using HRIS.Class;
using HRIS.Forms.Maintenance.Degreetype;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee.Education;
using HRIS.Views.Forms.Maintenance.Degreetype;
using HRIS.Views.Forms.Maintenance.EducationaLevel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HRIS.Forms.Employee.Education
{
    public partial class emp_AddEducationalAttainment : Form, IEducationLevelView, IDegreeTypeView, I_emp_EducationalAttainmentView
    {
        public int PKEmploye;
        private readonly HrisContext _context;
        private readonly educationalattainment_emp_Presenter _presenter;
        private readonly educationlevel_Presenter educationlevel_Presenter;
        private readonly degreetype_Presenter degreetype_Presenter;
        private emp_EducationalAttainment emp_EducationalAttainmentForm;
        private Models.Educationalattainment Selectededucationalattainment;
        public bool isUpdate = false;
        private int educID;
        public emp_AddEducationalAttainment(int PKEmployeeID)
        {
            InitializeComponent();
            _context = new HrisContext();
            educationlevel_Presenter = new educationlevel_Presenter(this);
            degreetype_Presenter = new degreetype_Presenter(this);
            _presenter = new educationalattainment_emp_Presenter(this);
            this.emp_EducationalAttainmentForm = new emp_EducationalAttainment(PKEmployeeID);
            this.Selectededucationalattainment = new Models.Educationalattainment();

           
            PKEmploye = PKEmployeeID;
            //load data to combobox
            educationlevel_Presenter.LoadEducationallevel();
            degreetype_Presenter.LoadDegreeType();
            //***********
        }

        public void DisplayDegreetype(List<Degreetype> degreetypes)
        {
            txt_degreetype.DataSource = degreetypes;
            txt_degreetype.ValueMember = "PkDegreetype";
            txt_degreetype.DisplayMember = "Description";
        }

        public void DisplayEducationalLevel(List<Educationallevel> Educationallevels)
        {
            txt_educationalAttainment.DataSource = Educationallevels;
            txt_educationalAttainment.ValueMember = "PkEducationallevel";
            txt_educationalAttainment.DisplayMember = "Description";
        }
        public void putdata(int EducAttainmentID)
        {
            if (isUpdate)
            {
                btn_cancel.Select();
                _presenter.LoadEducAttainment(EducAttainmentID);
                educID = EducAttainmentID;
            }
            else
            {
                btn_cancel.Select();
                _presenter.LoadEducAttainment(EducAttainmentID);
                //disable control
                txt_educationalAttainment.Enabled = false;
                txt_schoolattended.Enabled = false;
                txt_yeargraduated.Enabled = false;
                txt_educationaldegree.Enabled = false;
                txt_degreetype.Enabled = false;
                btn_save.Visible = false;
            }
        }
        private void save()
        {
            if (UniversalStatic.IsEmpty(txt_schoolattended)) return;
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Models.Educationalattainment
            {
                FkEmployee = PKEmploye,
                FkEducationallevel = Convert.ToInt32(txt_educationalAttainment.SelectedValue),
                Schoolattended = txt_schoolattended.Text,
                Yeargraduated = txt_yeargraduated.Value,
                Educationaldegree = txt_educationaldegree.Text,
                FkDegreetype = Convert.ToInt32(txt_degreetype.SelectedValue),
                Createdby = createdby,
                FkSystemUser = id
            };
            _presenter.AddEducAttainment(cv);
            this.Close();
        }
        private void update()
        {

            var existingeduc = _context.Educationalattainments.Find(educID);
            if (existingeduc != null)
            {
                existingeduc.FkEmployee = PKEmploye;
                existingeduc.FkEducationallevel = Convert.ToInt32(txt_educationalAttainment.SelectedValue);
                existingeduc.Schoolattended = txt_schoolattended.Text;
                existingeduc.Yeargraduated = txt_yeargraduated.Value.Date;
                existingeduc.Educationaldegree = txt_educationaldegree.Text;
                existingeduc.FkDegreetype = Convert.ToInt32(txt_degreetype.SelectedValue);
                _presenter.UpdateEducAttainment(existingeduc);
                this.Close();
            }
                
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void emp_AddEducationalAttainment_Load(object sender, EventArgs e)
        {

        }

        public void DisplayEmployeeEducAttainment(List<Educationalattainment> employee_educAttainment)
        {
            try
            {
                Models.Educationalattainment educ = employee_educAttainment[0];
                txt_degreetype.SelectedValue = educ.FkDegreetype;
                txt_educationalAttainment.SelectedValue = educ.FkEducationallevel;
                txt_schoolattended.Text  = educ.Schoolattended;
                txt_yeargraduated.Value = educ.Yeargraduated;
                txt_educationaldegree.Text = educ.Educationaldegree;
                txt_degreetype.SelectedValue = educ.FkDegreetype;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isUpdate)
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
