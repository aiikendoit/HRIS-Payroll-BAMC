using HRIS.Class;
using HRIS.Forms.Employee.Education;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee.Education;
using HRIS.Views.Forms.Maintenance.Degreetype;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Employee
{
    public partial class emp_EducationalAttainment : Form, I_emp_EducationalAttainmentView
    {
        private int PKEmployeeid;
        private readonly educationalattainment_emp_Presenter educationalattainment_Emp_Presenter;
        private readonly HrisContext _context;
        private DataView dataView;

        public emp_EducationalAttainment(int PKEmployeeID)
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_educationalattainment);
            educationalattainment_Emp_Presenter = new educationalattainment_emp_Presenter(this);
            _context = new HrisContext();
            dataView = new DataView();
            PKEmployeeid = PKEmployeeID;
            loadEducationAttainment();
        }


        private void emp_EducationalAttainment_Load(object sender, EventArgs e)
        {

        }
        private void loadEducationAttainment()
        {
            educationalattainment_Emp_Presenter.LoadAttainment(PKEmployeeid);

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            emp_AddEducationalAttainment neweduc = new emp_AddEducationalAttainment(PKEmployeeid);
            neweduc.ShowDialog();
            loadEducationAttainment();
        }

        public void DisplayEmployeeEducAttainment(List<Educationalattainment> employee_educAttainment)
        {

        }

        private void dgrid_educationalattainment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgrid_educationalattainment.Columns[0].Width = 50;
            dgrid_educationalattainment.Columns[2].Width = 250;
            dgrid_educationalattainment.Columns[3].Width = 100;
            dgrid_educationalattainment.Columns[1].HeaderText = "Educational Attainment";
            dgrid_educationalattainment.Columns[2].HeaderText = "School Attended";
            dgrid_educationalattainment.Columns[3].HeaderText = "Year Graduated";
            dgrid_educationalattainment.Columns[4].HeaderText = "Educational Degree";
            dgrid_educationalattainment.Columns[5].HeaderText = "Degree type";
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var educid = dgrid_educationalattainment.SelectedRows[0].Cells[0].Value;
            emp_AddEducationalAttainment educ = new emp_AddEducationalAttainment(PKEmployeeid);
            educ.isUpdate = true;
            educ.putdata(Convert.ToInt32(educid));
            educ.ShowDialog();
            loadEducationAttainment();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            var educid = dgrid_educationalattainment.SelectedRows[0].Cells[0].Value;
            emp_AddEducationalAttainment educ = new emp_AddEducationalAttainment(PKEmployeeid);
            educ.putdata(Convert.ToInt32(educid));
            educ.ShowDialog();
            loadEducationAttainment();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            loadEducationAttainment();
        }
        private void search()
        {
            string searchQuery = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                loadEducationAttainment();
            }
            else
            {
                educationalattainment_Emp_Presenter.SearchData(searchQuery);
            }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        public void DisplayAttainmentCustom(List<object> employee_attainment)
        {
            dgrid_educationalattainment.DataSource = employee_attainment;
        }
        private void delete(int educID)
        {
            var existingEduc = _context.Educationalattainments.Find(educID);
            if (existingEduc != null)
            {
                existingEduc.IsDeleted = true;
                educationalattainment_Emp_Presenter.DeleteEducationAttainment(existingEduc);
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int educID = (int)dgrid_educationalattainment.SelectedRows[0].Cells[0].Value;
            string? educattainment = dgrid_educationalattainment.SelectedRows[0].Cells[1].Value.ToString();
            if (educID != 0)
            {
                if (MessageBox.Show("Are you sure to delete " + educattainment,
                    "Please confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    delete(educID);
                    loadEducationAttainment();
                }
            }
        }
    }
}
