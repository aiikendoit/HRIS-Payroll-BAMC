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
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.AddressFolder.Barangay;

namespace HRIS.Forms.Maintenance.Barangay
{
    public partial class BarangayForm : Form, IBarangayView
    {
        private readonly barangay_Presenter barangay_Presenter;
        public BarangayForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_barangay);
            barangay_Presenter = new barangay_Presenter(this);
            loadBarangay();
        }

        public void clearfields()
        {

        }

        public void DisplayBarangay(List<Models.Barangay> Barangays)
        {
            dgrid_barangay.DataSource = Barangays;
            //dgrid_barangay.Columns[0].HeaderText = "ID";
            //dgrid_barangay.Columns[4].HeaderText = "Created by";
            //dgrid_barangay.Columns[3].HeaderText = "Created date";
            //dgrid_barangay.Columns[1].HeaderText = "Barangay Name";
            //if (dgrid_barangay.ColumnCount == 8)
            //{
            //    //Remove unnecessary column
            //    dgrid_barangay.Columns[7].Visible = false;
            //    dgrid_barangay.Columns[6].Visible = false;
            //    dgrid_barangay.Columns[5].Visible = false;
            //}
            //dgrid_barangay.AutoGenerateColumns = false;
            int totalrow = dgrid_barangay.RowCount;
            txt_totalcount.Text = "Total record(s): " + totalrow.ToString();
        }
        

        private void BarangayForm_Load(object sender, EventArgs e)
        {

        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            var brgy = new frm_barangay();
            brgy.province_Presenter.loadProvince();
            brgy.ShowDialog();
            loadBarangay();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }
        private void search()
        {
            string searchQuery = txt_search.Text.Trim();
            var employees = (List<Models.Barangay>)dgrid_barangay.DataSource;
           
            if (string.IsNullOrEmpty(searchQuery))
            {
                loadBarangay();
            }
            else
            {
                var searchResults = employees?.Where(emp =>
                 emp.PkBarangay.ToString().Contains(searchQuery, StringComparison.OrdinalIgnoreCase) ||
                 emp.Description.Contains(searchQuery, StringComparison.OrdinalIgnoreCase)).ToList();
                dgrid_barangay.DataSource = searchResults;
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            search();
        }
        private void loadBarangay()
        {
            barangay_Presenter.LoadAllBarangay(dgrid_barangay);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int brgyid = (int)dgrid_barangay.SelectedRows[0].Cells[0].Value;
            int towncityid = (int)dgrid_barangay.SelectedRows[0].Cells["FkTownCity"].Value;
            var brgy = new frm_barangay();
            brgy.isupdate = true;
            brgy.putdata(brgyid, towncityid);
            brgy.ShowDialog();
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            loadBarangay();
        }
    }
}
