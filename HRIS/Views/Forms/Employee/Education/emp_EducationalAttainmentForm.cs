﻿using HRIS.Class;
using HRIS.Forms.Employee.Education;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee.Education;
using HRIS.Views.Forms.Maintenance.Degreetype;
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
        private DataView dataView;

        public emp_EducationalAttainment(int PKEmployeeID)
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_educationalattainment);
            educationalattainment_Emp_Presenter = new educationalattainment_emp_Presenter(this);
            dataView = new DataView();
            PKEmployeeid = PKEmployeeID;
            loadEducationAttainment();
        }


        private void emp_EducationalAttainment_Load(object sender, EventArgs e)
        {

        }
        private void loadEducationAttainment()
        {
            educationalattainment_Emp_Presenter.loadAttainment(dgrid_educationalattainment, PKEmployeeid);

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
        private void search()
        {
            string searchTerm = txt_search.Text.ToLower();
            dgrid_educationalattainment.SuspendLayout();

            foreach (DataGridViewRow row in dgrid_educationalattainment.Rows)
            {
                bool rowVisible = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm))
                    {
                        rowVisible = true;
                        break;
                    }
                }
                row.Visible = rowVisible;
            }
            dgrid_educationalattainment.ResumeLayout();
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

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}
