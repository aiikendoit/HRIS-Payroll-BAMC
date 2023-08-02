using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using HRIS.Views.Forms.Maintenance.Department;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Maintenance.Department
{
    public partial class DepartmentForm : Form, IDeparmentView
    {
        private readonly department_Presenter department_Presenter;
        public DepartmentForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_department);
            department_Presenter = new department_Presenter(this);
            department_Presenter.LoadDepartment();


        }

        public void DisplayDepartment(List<Models.Department> departments)
        {
            dgrid_department.DataSource = departments;
            dgrid_department.Columns[0].HeaderText = "ID";
            dgrid_department.Columns["Description"].HeaderText = "Department";
            dgrid_department.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (dgrid_department.ColumnCount == 9)
            {

                //Remove unnecessary column
                dgrid_department.Columns.RemoveAt(8);
                dgrid_department.Columns.RemoveAt(7);
                dgrid_department.Columns.RemoveAt(6);
                dgrid_department.Columns.RemoveAt(4);
            }
            dgrid_department.AutoGenerateColumns = false;
            txt_totacount.Text = "Total record(s): " + dgrid_department.RowCount.ToString();
        }
        private void search()
        {
            string searchQuery = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                department_Presenter.LoadDepartment();
            }
            else
            {
                department_Presenter.SearchData(searchQuery);
            }
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {

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
            department_Presenter.LoadDepartment();
        }

        private void dgrid_department_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgrid_department.Columns[0].Width = 80;
            dgrid_department.Columns["Description"].Width = 250;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var selectedDepartment = dgrid_department.SelectedRows[0].DataBoundItem as Models.Department;
            if (selectedDepartment != null)
            {
                var dept = new frm_department();
                dept.isupdate = true;
                dept.putdata(this, selectedDepartment);
                dept.ShowDialog(this);
                if (txt_search.Text != String.Empty)
                {
                    department_Presenter.LoadDepartment();
                    search();
                }
                else
                {
                    department_Presenter.LoadDepartment();
                }
               
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            var selectedDepartment = dgrid_department.SelectedRows[0].DataBoundItem as Models.Department;
            if (selectedDepartment != null)
            {
                var dept = new frm_department();
                dept.putdata(this, selectedDepartment);
                dept.ShowDialog(this);
                if (txt_search.Text != String.Empty)
                {
                    department_Presenter.LoadDepartment();
                    search();
                }
                else
                {
                    department_Presenter.LoadDepartment();
                }
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            var dept = new frm_department();
            dept.ShowDialog(this);
            department_Presenter.LoadDepartment();
        }
    }
}
