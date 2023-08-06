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

namespace HRIS.Views.Forms.Maintenance.AddressFolder.ProvincesFolder
{
    public partial class ProvinceForm : Form, IProvinceView
    {
        private readonly province_Presenter province_Presenter;
        public ProvinceForm()
        {
            InitializeComponent();
            province_Presenter = new province_Presenter(this);
            UniversalStatic.customDatagrid(dgrid_provinces);
            province_Presenter.loadProvince();
        }

        public void ClearFields()
        {

        }
        private void search()
        {
            string searchQuery = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                province_Presenter.loadProvince();
            }
            else
            {
                province_Presenter.SearchData(searchQuery);
            }
        }
        public void DisplayProvinces(List<Province> Provinces)
        {
            dgrid_provinces.DataSource = Provinces;
            dgrid_provinces.Columns[0].HeaderText = "ID";
            dgrid_provinces.Columns["Description"].HeaderText = "Province";
            dgrid_provinces.Columns["Createddate"].HeaderText = "Created date";
            dgrid_provinces.Columns["Createdby"].HeaderText = "Created by";
            dgrid_provinces.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgrid_provinces.ColumnCount == 9)
            {
                dgrid_provinces.Columns.RemoveAt(8);
                dgrid_provinces.Columns.RemoveAt(7);
                dgrid_provinces.Columns.RemoveAt(6);
                dgrid_provinces.Columns.RemoveAt(5);
            }
            dgrid_provinces.AutoGenerateColumns = false;
            txt_totalcount.Text = "Total count(s): " + dgrid_provinces.RowCount.ToString();
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
            province_Presenter.loadProvince();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            var p = new frm_province();
            p.ShowDialog();
            province_Presenter.loadProvince();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var selectedprovince = dgrid_provinces.SelectedRows[0].DataBoundItem as Models.Province;
            if (selectedprovince != null)
            {
                var degtype = new frm_province();
                degtype.isupdate = true;
                degtype.putdata(this, selectedprovince);
                degtype.ShowDialog(this);
                if (txt_search.Text != string.Empty)
                {
                    province_Presenter.loadProvince();
                    search();
                }
                else
                {
                    province_Presenter.loadProvince();
                }

            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            var selectedprovince = dgrid_provinces.SelectedRows[0].DataBoundItem as Models.Province;
            if (selectedprovince != null)
            {
                var degtype = new frm_province();
                degtype.putdata(this, selectedprovince);
                degtype.ShowDialog(this);
                if (txt_search.Text != string.Empty)
                {
                    province_Presenter.loadProvince();
                    search();
                }
                else
                {
                    province_Presenter.loadProvince();
                }

            }
        }
    }
}
