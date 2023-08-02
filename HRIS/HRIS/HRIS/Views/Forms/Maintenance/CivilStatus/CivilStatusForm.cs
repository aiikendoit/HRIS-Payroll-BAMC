using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace HRIS.Forms.Maintenance.CivilStatus
{
    public partial class CivilStatusForm : Form, ICivilStatusView
    {
        private readonly civilStatus_Presenter civilStatus_Presenter;
        public CivilStatusForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_civilstatus);
            civilStatus_Presenter = new civilStatus_Presenter(this);
            civilStatus_Presenter.LoadCivilStatus();
        }

        public void ClearFields()
        {
        }
        private void CivilStatusForm_Load(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            frm_civilstatus_add frm_Civilstatus_Add = new frm_civilstatus_add();
            frm_Civilstatus_Add.ShowDialog();
            civilStatus_Presenter.LoadCivilStatus();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var selectcivilstatus = dgrid_civilstatus.SelectedRows[0].DataBoundItem as Civilstatus;
            if (selectcivilstatus != null)
            {
                frm_civilstatus_add frm_Civilstatus_Add = new frm_civilstatus_add();
                frm_Civilstatus_Add.isupdate = true;
                frm_Civilstatus_Add.putdata(this, selectcivilstatus);
                frm_Civilstatus_Add.ShowDialog(this);
                civilStatus_Presenter.LoadCivilStatus();
            }
        }

        public void DisplayCivilStatus(List<Civilstatus> Civilstatuses)
        {
            dgrid_civilstatus.DataSource = Civilstatuses;
            dgrid_civilstatus.Columns[0].HeaderText = "ID";
            dgrid_civilstatus.Columns[1].HeaderText = "Civil Status";
            dgrid_civilstatus.Columns["Createddate"].HeaderText = "Created date";
            dgrid_civilstatus.Columns["Createdby"].HeaderText = "Created by";
            dgrid_civilstatus.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgrid_civilstatus.ColumnCount == 8)
            {
                //Remove unnecessary column
                dgrid_civilstatus.Columns.RemoveAt(7);
                dgrid_civilstatus.Columns.RemoveAt(6);
                dgrid_civilstatus.Columns.RemoveAt(5);
            }
            dgrid_civilstatus.AutoGenerateColumns = false;
            txt_totalcount.Text = "Total record(s): " + dgrid_civilstatus.RowCount.ToString();
        }
        private void search()
        {
            string searchQuery = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                civilStatus_Presenter.LoadCivilStatus();
            }
            else
            {
                civilStatus_Presenter.SearchData(searchQuery);
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
            var selectcivilstatus = dgrid_civilstatus.SelectedRows[0].DataBoundItem as Civilstatus;
            if (selectcivilstatus != null)
            {
                frm_civilstatus_add frm_Civilstatus_Add = new frm_civilstatus_add();
                frm_Civilstatus_Add.isupdate = false;
                frm_Civilstatus_Add.putdata(this, selectcivilstatus);
                frm_Civilstatus_Add.ShowDialog(this);
                civilStatus_Presenter.LoadCivilStatus();
            }
        }
    }
}
