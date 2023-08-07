using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.SalarySetting;

namespace HRIS.Views.Forms.Maintenance.AddressFolder.TownCityFolder
{
    public partial class TownCityForm : Form, ITownCityView
    {
        private readonly towncity_Presenter towncity_Presenter;
        public TownCityForm()
        {
            InitializeComponent();
            towncity_Presenter = new towncity_Presenter(this);
            UniversalStatic.customDatagrid(dgrid_towncity);
            towncity_Presenter.loadTownCity_All();
            //towncity_Presenter.loadTowncity();
        }

        private void TownCityForm_Load(object sender, EventArgs e)
        {

        }

        public void ClearFields()
        {
            throw new NotImplementedException();
        }

        public void DisplayProvince(int provinces)
        {
            throw new NotImplementedException();
        }

        public void DisplayTownCity(List<Towncity> Towncities)
        {
            dgrid_towncity.DataSource = Towncities;
            dgrid_towncity.Columns[0].HeaderText = "ID";
            dgrid_towncity.Columns["Description"].HeaderText = "Town/City";
            dgrid_towncity.Columns["Createddate"].HeaderText = "Created date";
            dgrid_towncity.Columns["Createdby"].HeaderText = "Created by";
            dgrid_towncity.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgrid_towncity.ColumnCount == 8)
            {

                dgrid_towncity.Columns.RemoveAt(7);
                dgrid_towncity.Columns.RemoveAt(6);
                dgrid_towncity.Columns.RemoveAt(5);
            }
            dgrid_towncity.AutoGenerateColumns = false;
            txt_totalcount.Text = "Total count(s): " + dgrid_towncity.RowCount.ToString();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            string searchQuery = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                towncity_Presenter.loadTownCity_All();
            }
            else
            {
                towncity_Presenter.SearchData(searchQuery);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            var st = new frm_towncity();
            st.ShowDialog();
            //salarysetting_Presenter.LoadSalarysetting();
        }
    }
}
