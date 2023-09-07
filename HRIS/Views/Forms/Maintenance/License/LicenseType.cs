using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.Degreetype;
using HRIS.Views.Forms.Maintenance.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Maintenance.License
{
    public partial class LicenseType : Form, ILicenseTypeView
    {
        private readonly licensetype_Presenter licensetype_Presenter;
        public LicenseType()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_licensetype);
            licensetype_Presenter = new licensetype_Presenter(this);
            licensetype_Presenter.LoadLicentype();
        }

        public void DisplayLicensetype(List<Licensetype> licenseTypes)
        {
            dgrid_licensetype.DataSource = licenseTypes;
            dgrid_licensetype.Columns[0].HeaderText = "ID";
            dgrid_licensetype.Columns["Description"].HeaderText = "License type";
            dgrid_licensetype.Columns["Createddate"].HeaderText = "Created date";
            dgrid_licensetype.Columns["Createdby"].HeaderText = "Created by";
            dgrid_licensetype.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgrid_licensetype.ColumnCount == 7)
            {
                dgrid_licensetype.Columns.RemoveAt(6);
                dgrid_licensetype.Columns.RemoveAt(5);
            }
            dgrid_licensetype.AutoGenerateColumns = false;
            txt_totalcount.Text = "Total count(s): " + dgrid_licensetype.RowCount.ToString();
        }
        private void search()
        {
            string searchQuery = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                licensetype_Presenter.LoadLicentype();
            }
            else
            {
                licensetype_Presenter.SearchData(searchQuery);
            }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            var license = new frm_licensetype();
            license.ShowDialog();
            licensetype_Presenter.LoadLicentype();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var selectedleave = dgrid_licensetype.SelectedRows[0].DataBoundItem as Models.Licensetype;
            if (selectedleave != null)
            {
                var licesetype = new frm_licensetype();
                licesetype.isupdate = true;
                licesetype.putdata(this, selectedleave);
                licesetype.ShowDialog(this);
                if (txt_search.Text != string.Empty)
                {
                    licensetype_Presenter.LoadLicentype();
                    search();
                }
                else
                {
                    licensetype_Presenter.LoadLicentype();
                }

            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            var selectedleave = dgrid_licensetype.SelectedRows[0].DataBoundItem as Models.Licensetype;
            if (selectedleave != null)
            {
                var licesetype = new frm_licensetype();
                licesetype.putdata(this, selectedleave);
                licesetype.ShowDialog(this);
                if (txt_search.Text != string.Empty)
                {
                    licensetype_Presenter.LoadLicentype();
                    search();
                }
                else
                {
                    licensetype_Presenter.LoadLicentype();
                }

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
            licensetype_Presenter.LoadLicentype();
        }
    }
}
