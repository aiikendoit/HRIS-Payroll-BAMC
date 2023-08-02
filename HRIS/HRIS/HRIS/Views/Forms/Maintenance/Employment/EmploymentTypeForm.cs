using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.Degreetype;
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

namespace HRIS.Forms.Maintenance.Employment
{
    public partial class EmploymentTypeForm : Form, IEmploymentTypeView
    {
        private readonly employmenttype_Presenter employmenttype_Presenter;
        public EmploymentTypeForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_employmenttype);
            employmenttype_Presenter = new employmenttype_Presenter(this);
            employmenttype_Presenter.LoadEmployment();
        }

        public void DisplayEmployment(List<Employmenttype> employments)
        {
            dgrid_employmenttype.DataSource = employments;
            dgrid_employmenttype.Columns[0].HeaderText = "ID";
            dgrid_employmenttype.Columns["Description"].HeaderText = "Employment type";
            dgrid_employmenttype.Columns["Createddate"].HeaderText = "Created date";
            dgrid_employmenttype.Columns["Createdby"].HeaderText = "Created by";
            dgrid_employmenttype.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgrid_employmenttype.ColumnCount == 8)
            {
                dgrid_employmenttype.Columns.RemoveAt(7);
                dgrid_employmenttype.Columns.RemoveAt(6);
                dgrid_employmenttype.Columns.RemoveAt(5);
            }
            dgrid_employmenttype.AutoGenerateColumns = false;
            txt_totalcount.Text = "Total count(s): " + dgrid_employmenttype.RowCount.ToString();
        }
        private void search()
        {
            string searchQuery = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                employmenttype_Presenter.LoadEmployment();
            }
            else
            {
                employmenttype_Presenter.SearchData(searchQuery);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            employmenttype_Presenter.LoadEmployment();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            var emtype = new frm_employmenttype();
            emtype.ShowDialog();
            employmenttype_Presenter.LoadEmployment();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var selEmpType = dgrid_employmenttype.SelectedRows[0].DataBoundItem as Models.Employmenttype;
            if (selEmpType != null)
            {
                var degtype = new frm_employmenttype();
                degtype.isupdate = true;
                degtype.putdata(this, selEmpType);
                degtype.ShowDialog(this);
                employmenttype_Presenter.LoadEmployment();
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            var selEmpType = dgrid_employmenttype.SelectedRows[0].DataBoundItem as Models.Employmenttype;
            if (selEmpType != null)
            {
                var degtype = new frm_employmenttype();
                degtype.putdata(this, selEmpType);
                degtype.ShowDialog(this);
                employmenttype_Presenter.LoadEmployment();
            }
        }
    }
}
