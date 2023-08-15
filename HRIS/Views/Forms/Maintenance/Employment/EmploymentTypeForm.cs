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
            dgrid_employmenttype.AutoGenerateColumns = false;
            dgrid_employmenttype.DataSource = employments;
            if (employments != null && employments.Count > 0)
            {

                dgrid_employmenttype.Columns["EmploymentID"].DataPropertyName = "PkEmploymenttype";
                dgrid_employmenttype.Columns["EmploymentDescription"].DataPropertyName = "Description";
                dgrid_employmenttype.Columns["isActive"].DataPropertyName = "isActive";
                dgrid_employmenttype.Columns["isOrganic"].DataPropertyName = "isOrganic";
                dgrid_employmenttype.Columns["isInOrganic"].DataPropertyName = "isInOrganic";
                dgrid_employmenttype.Columns["Createddate"].DataPropertyName = "Createddate";
            }
            else
            {
                dgrid_employmenttype.DataSource = null;
            }

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

        private void btn_refresh_Click(object sender, EventArgs e)
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

        public void DsiplayEmploymentCustom(List<object> Employmentlist)
        {
        }

        private void dgrid_employmenttype_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgrid_employmenttype.Columns[0].Width = 10;
            dgrid_employmenttype.Columns["isOrganic"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgrid_employmenttype.Columns["isInOrganic"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgrid_employmenttype.Columns[e.ColumnIndex].Name == "isActive" && e.RowIndex >= 0)
            {
                DataGridViewCell statusCell = dgrid_employmenttype.Rows[e.RowIndex].Cells["isActive"];
                DataGridViewCell isActiveCell = dgrid_employmenttype.Rows[e.RowIndex].Cells["isActive"];

                if (isActiveCell.Value != null && isActiveCell.Value is bool isActive)
                {
                    if (isActive)
                    {
                        // Set the background color to green if isActive is true
                        statusCell.Style.BackColor = Color.Green;
                        statusCell.Style.ForeColor = Color.Green;
                        statusCell.Style.SelectionBackColor = Color.Green;
                        statusCell.Style.SelectionForeColor = Color.Green;
                        statusCell.ToolTipText = "Active";
                    }
                    else
                    {
                        // Set the background color to red if isActive is false
                        statusCell.Style.BackColor = Color.Red;
                        statusCell.Style.ForeColor = Color.Red;
                        statusCell.Style.SelectionBackColor = Color.Red;
                        statusCell.Style.SelectionForeColor = Color.Red;
                        statusCell.ToolTipText = "Inactive";
                    }
                }
                else
                {
                    // Set the background color to green if isActive is null
                    statusCell.Style.BackColor = Color.Green;
                    statusCell.Style.SelectionBackColor = Color.Green;
                    statusCell.Style.SelectionForeColor = Color.Green;
                    statusCell.Style.ForeColor = Color.Green;
                    statusCell.ToolTipText = "Active";
                }
            }

        }
    }
}
