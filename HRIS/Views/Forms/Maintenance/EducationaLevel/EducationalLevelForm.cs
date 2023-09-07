using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using HRIS.Views.Forms.Maintenance.EducationaLevel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Maintenance.EducationaLevel
{
    public partial class EducationalLevelForm : Form, IEducationLevelView
    {
        private readonly educationlevel_Presenter educationlevel_Presenter;
        public EducationalLevelForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_educationalLevel);
            educationlevel_Presenter = new educationlevel_Presenter(this);
            educationlevel_Presenter.LoadEducationallevel();

        }

        public void DisplayEducationalLevel(List<Educationallevel> Educationallevels)
        {
            dgrid_educationalLevel.DataSource = Educationallevels;
            dgrid_educationalLevel.Columns[0].HeaderText = "ID";
            dgrid_educationalLevel.Columns[1].HeaderText = "Educational level";
            dgrid_educationalLevel.Columns["Createddate"].HeaderText = "Created date";
            dgrid_educationalLevel.Columns["Createdby"].HeaderText = "Created by";
            dgrid_educationalLevel.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgrid_educationalLevel.ColumnCount == 10)
            {
                //Remove unnecessary column
                dgrid_educationalLevel.Columns.RemoveAt(9);
                dgrid_educationalLevel.Columns.RemoveAt(8);
                dgrid_educationalLevel.Columns.RemoveAt(7);
                dgrid_educationalLevel.Columns.RemoveAt(6);
                dgrid_educationalLevel.Columns.RemoveAt(5);
            }
            dgrid_educationalLevel.AutoGenerateColumns = false;
            txt_totalcount.Text = "Total record(s): " + dgrid_educationalLevel.RowCount.ToString();
        }

        private void EducationalLevelForm_Load(object sender, EventArgs e)
        {

        }
        private void search()
        {
            string searchQuery = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                educationlevel_Presenter.LoadEducationallevel();
            }
            else
            {
                educationlevel_Presenter.SearchData(searchQuery);
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            var p = new frm_educationllevel_add();
            p.ShowDialog();
            educationlevel_Presenter.LoadEducationallevel();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var selectcivilstatus = dgrid_educationalLevel.SelectedRows[0].DataBoundItem as Models.Educationallevel;
            if (selectcivilstatus != null)
            {
                var educ = new frm_educationllevel_add();
                educ.isupdate = true;
                educ.putdata(this, selectcivilstatus);
                educ.ShowDialog(this);
                educationlevel_Presenter.LoadEducationallevel();
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            var selectcivilstatus = dgrid_educationalLevel.SelectedRows[0].DataBoundItem as Models.Educationallevel;
            if (selectcivilstatus != null)
            {
                var educ = new frm_educationllevel_add();
                educ.putdata(this, selectcivilstatus);
                educ.ShowDialog(this);
                educationlevel_Presenter.LoadEducationallevel();
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            educationlevel_Presenter.LoadEducationallevel();
        }
    }
}
