using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using HRIS.Views.Forms.Maintenance.ReligionFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace HRIS.Views.Forms.Maintenance.Religion
{
    public partial class ReligionForm : Form, IReligionView
    {
        private readonly religion_Presenter religion_Presenter;

        public ReligionForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_religion);
            religion_Presenter = new religion_Presenter(this);
            religion_Presenter.LoadReligion();
        }

        public void ClearFields()
        {

        }

        public void DisplayReligion(List<Models.Religion> Religions)
        {
            dgrid_religion.DataSource = Religions;
            dgrid_religion.Columns[0].HeaderText = "ID";
            dgrid_religion.Columns["Description"].HeaderText = "Religion";
            dgrid_religion.Columns["Createddate"].HeaderText = "Created date";
            dgrid_religion.Columns["Createdby"].HeaderText = "Created by";
            dgrid_religion.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgrid_religion.ColumnCount == 8)
            {
                //Remove unnecessary column
                dgrid_religion.Columns.RemoveAt(7);
                dgrid_religion.Columns.RemoveAt(6);
                dgrid_religion.Columns.RemoveAt(5);
            }
            dgrid_religion.AutoGenerateColumns = false;
            txt_totalcount.Text = "Total count(s): " + dgrid_religion.RowCount.ToString();
        }
        private void search()
        {
            string searchQuery = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                religion_Presenter.LoadReligion();
            }
            else
            {
                religion_Presenter.SearchData(searchQuery);
            }
        }
        private void ReligionForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            frm_religion_Add frm_Religion_Add = new frm_religion_Add();
            frm_Religion_Add.ShowDialog();
            religion_Presenter.LoadReligion();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var selectReligion = dgrid_religion.SelectedRows[0].DataBoundItem as Models.Religion;
            if (selectReligion != null)
            {
                frm_religion_Add frm_Religion_Add = new frm_religion_Add();
                frm_Religion_Add.isupdate = true;
                frm_Religion_Add.putdata(this, selectReligion);
                frm_Religion_Add.ShowDialog(this);
                religion_Presenter.LoadReligion();
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
            religion_Presenter.LoadReligion();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            var selectReligion = dgrid_religion.SelectedRows[0].DataBoundItem as Models.Religion;
            if (selectReligion != null)
            {
                frm_religion_Add frm_Religion_Add = new frm_religion_Add();
                frm_Religion_Add.isupdate = true;
                frm_Religion_Add.putdata(this, selectReligion);
                frm_Religion_Add.ShowDialog(this);
                if (txt_search.Text != string.Empty)
                {
                    religion_Presenter.LoadReligion();
                    search();
                }
                else
                {
                    religion_Presenter.LoadReligion();
                }
            }
        }
    }
}
