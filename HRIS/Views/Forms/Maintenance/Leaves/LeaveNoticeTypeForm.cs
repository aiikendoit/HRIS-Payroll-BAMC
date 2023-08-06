using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.Degreetype;
using HRIS.Views.Forms.Maintenance.Leaves;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Maintenance.Leaves
{
    public partial class LeaveNoticeTypeForm : Form, ILeaveNoticeTypeView
    {
        private readonly leavenoticetype_Presenter leavenoticetype_Presenter;
        public LeaveNoticeTypeForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_leavenoticetype);
            leavenoticetype_Presenter = new leavenoticetype_Presenter(this);
            leavenoticetype_Presenter.Loadleavenotice();
        }

        public void DisplayLeaveNoticeType(List<Leavenoticetype> leaves)
        {
            dgrid_leavenoticetype.DataSource = leaves;
            dgrid_leavenoticetype.Columns[0].HeaderText = "ID";
            dgrid_leavenoticetype.Columns["Description"].HeaderText = "Notice type";
            dgrid_leavenoticetype.Columns["Createddate"].HeaderText = "Created date";
            dgrid_leavenoticetype.Columns["Createdby"].HeaderText = "Created by";
            dgrid_leavenoticetype.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgrid_leavenoticetype.ColumnCount == 7)
            {
                dgrid_leavenoticetype.Columns.RemoveAt(6);
                dgrid_leavenoticetype.Columns.RemoveAt(5);
            }
            dgrid_leavenoticetype.AutoGenerateColumns = false;
            txt_totalcount.Text = "Total count(s): " + dgrid_leavenoticetype.RowCount.ToString();
        }
        private void search()
        {
            string searchQuery = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                leavenoticetype_Presenter.Loadleavenotice();
            }
            else
            {
                leavenoticetype_Presenter.SearchData(searchQuery);
            }
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            var lt = new frm_leavenoticetype();
            lt.ShowDialog();
            leavenoticetype_Presenter.Loadleavenotice();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var selectedtype = dgrid_leavenoticetype.SelectedRows[0].DataBoundItem as Models.Leavenoticetype;
            if (selectedtype != null)
            {
                var noticetype = new frm_leavenoticetype();
                noticetype.isupdate = true;
                noticetype.putdata(this, selectedtype);
                noticetype.ShowDialog(this);
                leavenoticetype_Presenter.Loadleavenotice();
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

        private void btn_view_Click(object sender, EventArgs e)
        {
            var selectedtype = dgrid_leavenoticetype.SelectedRows[0].DataBoundItem as Models.Leavenoticetype;
            if (selectedtype != null)
            {
                var noticetype = new frm_leavenoticetype();
                noticetype.putdata(this, selectedtype);
                noticetype.ShowDialog(this);
                leavenoticetype_Presenter.Loadleavenotice();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            leavenoticetype_Presenter.Loadleavenotice();
        }
    }
}
