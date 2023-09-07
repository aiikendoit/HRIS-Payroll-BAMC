using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee.Leaves;
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

namespace HRIS.Forms.Employee.Leaves
{
    public partial class emp_leaveSetting : Form, IEmployeeLeaveSettingView
    {
        private int empID = 0;
        private HrisContext _context;
        private readonly employee_leavesetting_Presenter employee_Leavesetting_Presenter;
        public emp_leaveSetting(int EmployeeID, bool isupdate)
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_leavesetting);
            employee_Leavesetting_Presenter = new employee_leavesetting_Presenter(this);
            _context = new HrisContext();
            empID = EmployeeID;
            if (isupdate == false)
            {
                btn_edit.Visible = false;
                btn_delete.Visible = false;
                btn_new.Visible = false;
            }
            loadsetting();
        }
        private void loadsetting()
        {
            employee_Leavesetting_Presenter.LoadLeaveSettingCustom(empID);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            emp_addLeaveSetting emp_AddLeaveSetting = new emp_addLeaveSetting(empID);
            emp_AddLeaveSetting.ShowDialog();
            loadsetting();
        }

        private void dgrid_leavesetting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void DisplayLeavesetting(List<Leavessetting> leavessettings)
        {
            //throw new NotImplementedException();
        }

        public void DisplayLeavesettingCustom(List<object> leavessettings)
        {
            if (leavessettings != null && leavessettings.Count > 0)
            {
                dgrid_leavesetting.AutoGenerateColumns = false;
                dgrid_leavesetting.Columns["leavesettingID"].DataPropertyName = "ID";
                dgrid_leavesetting.Columns["leavetype"].DataPropertyName = "Leavetype";
                dgrid_leavesetting.Columns["daysperyear"].DataPropertyName = "daysperyear";
                dgrid_leavesetting.Columns["effectivedate"].DataPropertyName = "Effectivitydate";
                dgrid_leavesetting.Columns["remarks"].DataPropertyName = "Remarks";
                dgrid_leavesetting.DataSource = leavessettings;
                txt_totalcount.Text = "Total record(s): " + leavessettings.Count;
            }
            else
            {
                dgrid_leavesetting.DataSource = null; // Clear the DataGridView if licenseInfo is empty
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var pkleavesettingid = dgrid_leavesetting.SelectedRows[0].Cells[1].Value;
            emp_addLeaveSetting emp_AddLeaveSetting = new emp_addLeaveSetting(empID);
            emp_AddLeaveSetting.isUpdate = true;
            emp_AddLeaveSetting.putdata(Convert.ToInt32(pkleavesettingid));
            emp_AddLeaveSetting.ShowDialog();
            loadsetting();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            var pkleavesettingid = dgrid_leavesetting.SelectedRows[0].Cells[1].Value;
            emp_addLeaveSetting emp_AddLeaveSetting = new emp_addLeaveSetting(empID);
            emp_AddLeaveSetting.putdata(Convert.ToInt32(pkleavesettingid));
            emp_AddLeaveSetting.ShowDialog();
            loadsetting();
        }
        private void delete()
        {
            var pkleavesettingid = dgrid_leavesetting.SelectedRows[0].Cells[1].Value;
            var existingLeavesetting = _context.Leavessettings.Find(pkleavesettingid);
            if (existingLeavesetting != null)
            {
                existingLeavesetting.IsDeleted = true;
                employee_Leavesetting_Presenter.DeleteLeavesetting(existingLeavesetting);
            }

        }
        private void Search()
        {
            string searchQuery = txt_search.Text;
            employee_Leavesetting_Presenter.SearchData(searchQuery);
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this data?", "Confirm", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                delete();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            loadsetting();
        }
    }
}
