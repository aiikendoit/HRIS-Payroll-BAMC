using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
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

namespace HRIS.Views.Forms.Maintenance.Leaves
{
    public partial class LeaveTypeForm : Form, ILeaveTypeView
    {
        private readonly leavetype_Presenter leavetype_Presenter;
        public LeaveTypeForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_Leavetype);
            leavetype_Presenter = new leavetype_Presenter(this);
            leavetype_Presenter.LoadLeaveType();
        }

        public void DisplayLeavetype(List<Leavetype> leavetypeList)
        {
            dgrid_Leavetype.DataSource = leavetypeList;
            dgrid_Leavetype.Columns[0].HeaderText = "ID";
            dgrid_Leavetype.Columns["Description"].HeaderText = "Leave type";
            dgrid_Leavetype.Columns["Createddate"].HeaderText = "Created date";
            dgrid_Leavetype.Columns["Createdby"].HeaderText = "Created by";
            dgrid_Leavetype.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgrid_Leavetype.ColumnCount == 9)
            {
                dgrid_Leavetype.Columns.RemoveAt(8);
                dgrid_Leavetype.Columns.RemoveAt(7);
                dgrid_Leavetype.Columns.RemoveAt(6);
            }
            dgrid_Leavetype.AutoGenerateColumns = false;
            txt_totalcount.Text = "Total count(s): " + dgrid_Leavetype.RowCount.ToString();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            var lt = new frm_leavetype();
            lt.ShowDialog();
            leavetype_Presenter.LoadLeaveType();

        }
        private void search()
        {
            string searchQuery = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                leavetype_Presenter.LoadLeaveType();
            }
            else
            {
                leavetype_Presenter.SearchData(searchQuery);
            }
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            var selectedleave = dgrid_Leavetype.SelectedRows[0].DataBoundItem as Models.Leavetype;
            if (selectedleave != null)
            {
                var degtype = new frm_leavetype();
                degtype.isupdate = true;
                degtype.putdata(this, selectedleave);
                degtype.ShowDialog(this);
                leavetype_Presenter.LoadLeaveType();
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            var selectedleave = dgrid_Leavetype.SelectedRows[0].DataBoundItem as Models.Leavetype;
            if (selectedleave != null)
            {
                var degtype = new frm_leavetype();
                degtype.putdata(this, selectedleave);
                degtype.ShowDialog(this);
                leavetype_Presenter.LoadLeaveType();
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
            leavetype_Presenter.LoadLeaveType();
        }
    }
}
