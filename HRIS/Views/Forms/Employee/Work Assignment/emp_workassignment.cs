using HRIS.Class;
using HRIS.Forms.Employee.Work_Assignment;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee.Work_Assignment;
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
    public partial class emp_workassignment : Form, IWorkAssigmentView
    {
        private readonly workassignment_Presenter workassignment_Presenter;
        private string emp_id;
        private readonly HrisContext _context;
        public emp_workassignment(int PKEmployeeID, bool isUpdate)
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_workassignment);
            workassignment_Presenter = new workassignment_Presenter(this);
            _context = new HrisContext();
            loadWorkAssignment(Convert.ToInt32(PKEmployeeID));
            emp_id = PKEmployeeID.ToString();
            if (isUpdate == false)
            {
                btn_new.Visible = false;
                btn_edit.Visible = false;
                btn_delete.Visible = false;
            }
        }

        public void DisplayWorkAssignment(List<Workassignment> workassignments)
        {
            dgrid_workassignment.DataSource = workassignments;
        }

        private void loadWorkAssignment(int employeeid)
        {
            workassignment_Presenter.loadWorkAssignment(employeeid);
        }

        private void emp_workassignment_Load(object sender, EventArgs e)
        {

        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            emp_AddworkAssignment emp_AddworkAssignment = new emp_AddworkAssignment(emp_id);
            emp_AddworkAssignment.ShowDialog();
            loadWorkAssignment(Convert.ToInt32(emp_id));
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            int workassid = (int)dgrid_workassignment.SelectedRows[0].Cells[1].Value;
            emp_AddworkAssignment emp_AddworkAssignment = new emp_AddworkAssignment(emp_id);
            emp_AddworkAssignment.isUpdate = true;
            emp_AddworkAssignment.putdata(workassid);
            emp_AddworkAssignment.ShowDialog();
            loadWorkAssignment(Convert.ToInt32(emp_id));
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        public void DisplayWorkAssignmentCustom(List<object> workassingmentlist)
        {
            dgrid_workassignment.AutoGenerateColumns = false;
            if (workassingmentlist != null && workassingmentlist.Count > 0)
            {

                dgrid_workassignment.Columns["WorkEmploymentID"].DataPropertyName = "ID";
                dgrid_workassignment.Columns["WorkEmploymentDepartment"].DataPropertyName = "Department";
                dgrid_workassignment.Columns["WorkEmploymentPosition"].DataPropertyName = "Position";
                dgrid_workassignment.Columns["WorkEmploymentJobDescription"].DataPropertyName = "JobDescription";
                dgrid_workassignment.Columns["WorkEmploymentisManager"].DataPropertyName = "isManager";
                dgrid_workassignment.Columns["Startdate"].DataPropertyName = "Startdate";
                dgrid_workassignment.Columns["EndDate"].DataPropertyName = "Enddate";
                dgrid_workassignment.DataSource = workassingmentlist;
                txt_totalcount.Text = "Total record(s): " + workassingmentlist.Count;
            }
            else
            {
                dgrid_workassignment.DataSource = null; // Clear the DataGridView if licenseInfo is empty
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            int workassid = (int)dgrid_workassignment.SelectedRows[0].Cells[1].Value;
            emp_AddworkAssignment emp_AddworkAssignment = new emp_AddworkAssignment(emp_id);
            emp_AddworkAssignment.putdata(workassid);
            emp_AddworkAssignment.ShowDialog();
            loadWorkAssignment(Convert.ToInt32(emp_id));
        }

        private void dgrid_workassignment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgrid_workassignment.Columns[0].Width = 10;
            dgrid_workassignment.Columns[1].Width = 80;
            dgrid_workassignment.Columns[2].Width = 200;
            dgrid_workassignment.Columns["WorkEmploymentisManager"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgrid_workassignment.Columns[e.ColumnIndex].Name == "EndDate" && e.RowIndex >= 0)
            {
                DataGridViewCell statusCell = dgrid_workassignment.Rows[e.RowIndex].Cells["ColorStatus"];
                DataGridViewCell endDateCell = dgrid_workassignment.Rows[e.RowIndex].Cells["EndDate"];

                if (endDateCell.Value != null)
                {
                    DateTime endDate = (DateTime)endDateCell.Value; // Assuming the value is of type DateTime
                    DateTime currentDate = DateTime.Now;

                    if (endDate > currentDate)
                    {
                        // Set the background color to green if End Date is in the future
                        statusCell.Style.BackColor = Color.Green;
                        statusCell.Style.SelectionBackColor = Color.Green;
                        statusCell.ToolTipText = "Active";
                    }
                    else
                    {
                        // Set the background color to red if End Date is in the past
                        statusCell.Style.BackColor = Color.Red;
                        statusCell.Style.SelectionBackColor = Color.Red;
                        statusCell.ToolTipText = "Inactive";
                    }
                }
                else
                {
                    // Set the background color to green if End Date is null
                    statusCell.Style.BackColor = Color.Green;
                    statusCell.Style.SelectionBackColor = Color.Green;
                    statusCell.ToolTipText = "Active";
                }
            }
            // Flag to track if any active row is found
            bool hasActiveRow = false;
            // Iterate through the DataGridView rows
            foreach (DataGridViewRow row in dgrid_workassignment.Rows)
            {
                // Check if the row index is valid
                if (!row.IsNewRow)
                {
                    DataGridViewCell statusCell = row.Cells["ColorStatus"];

                    // Check if the background color of the "EmpStatus" cell is green
                    if (statusCell.Style.BackColor == Color.Green)
                    {
                        hasActiveRow = true;
                        break; // No need to continue checking, as we found an active row
                    }
                }
            }
            // Set the visibility of the btn_new button based on the flag
            btn_new.Visible = !hasActiveRow;
        }

        private void dgrid_workassignment_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrid_workassignment.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgrid_workassignment.SelectedRows[0];
                DataGridViewCell endDateCell = selectedRow.Cells["Enddate"];

                DateTime currentDate = DateTime.Now; // Current date

                if (endDateCell.Value != null)
                {
                    DateTime endDate = (DateTime)endDateCell.Value;

                    if (endDateCell.Value != null && endDate > currentDate)
                    {
                        // Enable the edit button if End Date is in the past or today
                        btn_edit.Enabled = true;
                        btn_edit.IconColor = Color.White;

                    }
                    else
                    {
                        // Disable the edit button if End Date is in the future or not null
                        btn_edit.Enabled = false;
                        btn_edit.IconColor = Color.DarkGray;
                    }
                }
                else
                {
                    // Enable the edit button if End Date is null
                    btn_edit.Enabled = true;
                    btn_edit.IconColor = Color.White;
                }
            }
        }
        private void delete(int licenseID)
        {
            var existingWorkAssigment = _context.Workassignments.Find(licenseID);
            if (existingWorkAssigment != null)
            {
                existingWorkAssigment.IsDeleted = true;
                workassignment_Presenter.DeleteWorkAssignment(existingWorkAssigment);
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int workassignmentid = (int)dgrid_workassignment.SelectedRows[0].Cells["WorkEmploymentID"].Value;
            string? employmentytpe = dgrid_workassignment.SelectedRows[0].Cells[2].Value.ToString();
            if (workassignmentid != 0)
            {
                if (MessageBox.Show("Are you sure to delete " + employmentytpe,
                    "Please confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    delete(workassignmentid);
                    loadWorkAssignment(Convert.ToInt32(emp_id));
                }
            }
        }
    }
}
