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
using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.AddressFolder.Barangay;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HRIS.Forms.Maintenance.Barangay
{
    public partial class BarangayForm : Form, IBarangayView
    {
        private readonly barangay_Presenter barangay_Presenter;
        private readonly HrisContext context = new HrisContext();
        public BarangayForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_barangay);
            barangay_Presenter = new barangay_Presenter(this);
            barangay_Presenter.LoadAllBarangay();
            //loadbrgy();
        }

        public void clearfields()
        {

        }
        private void loadbrgy()
        {
            //HrisContext hrisContext = new HrisContext();
            //try
            //{
            //    using (var dbContext = new HrisContext())
            //    {
            //        var connectionString = dbContext.Database.GetConnectionString();
            //        using (var connection = new SqlConnection(connectionString))
            //        {
            //            string query = @"SELECT [PK_barangay][Code]
            //                                ,[description][Barangay Name]
            //                                ,[isActive]
            //                            FROM [HRIS].[Template].[barangay]";
            //            using (var command = new SqlCommand(query, connection))
            //            {
            //                connection.Open();
            //                DataTable dataTable = new DataTable();
            //                dataTable.Load(command.ExecuteReader());
            //                dgrid_barangay.DataSource = dataTable;
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Cursor.Current = Cursors.Default;
            //    MessageBox.Show(ex.Message);
            //}

        }
        public DataTable ConvertListToDataTable(List<Models.Barangay> list)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("BarangayName", typeof(string));
            dt.Columns.Add("isActive", typeof(bool));
            dt.Columns.Add("Createddate", typeof(DateTime));

            foreach (var item in list)
            {
                dt.Rows.Add(item.PkBarangay, item.Description, item.IsActive, item.Createddate);
            }

            return dt;
        }
        public void DisplayBarangay(List<Models.Barangay> Barangays)
        {

            //var p = Barangays.ToList();
            //var datatable = ConvertListToDataTable(p);
            //dgrid_barangay.DataSource = datatable;

            dgrid_barangay.DataSource = null;
            dgrid_barangay.DataSource = Barangays;
            dgrid_barangay.Columns[0].HeaderText = "ID";
            dgrid_barangay.Columns[4].HeaderText = "Created by";
            dgrid_barangay.Columns[3].HeaderText = "Created date";
            dgrid_barangay.Columns[1].HeaderText = "Barangay Name";
            dgrid_barangay.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            if (dgrid_barangay.ColumnCount == 8)
            {
                // Remove unnecessary column
                dgrid_barangay.Columns[7].Visible = false;
                dgrid_barangay.Columns[6].Visible = false;
                dgrid_barangay.Columns[5].Visible = false;
            }
            dgrid_barangay.AutoGenerateColumns = false;
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
            barangay_Presenter.LoadAllBarangay();
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
                barangay_Presenter.LoadAllBarangay();
            }
            else
            {
                barangay_Presenter.SearchData(searchQuery);
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            var selectedbrgy = dgrid_barangay.SelectedRows[0].DataBoundItem as Models.Barangay;
            if (selectedbrgy != null)
            {
                frm_barangay frm_Barangay = new frm_barangay();
                frm_Barangay.isupdate = true;
                frm_Barangay.putdata(this, selectedbrgy);
                frm_Barangay.ShowDialog(this);

                if (txt_search.Text != string.Empty)
                {
                    search();
                }
                else
                {
                    barangay_Presenter.LoadAllBarangay();
                }
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            var selectedbrgy = dgrid_barangay.SelectedRows[0].DataBoundItem as Models.Barangay;
            if (selectedbrgy != null)
            {
                frm_barangay frm_Barangay = new frm_barangay();
                frm_Barangay.isview = true;
                frm_Barangay.putdata(this, selectedbrgy);
                frm_Barangay.ShowDialog(this);

                if (txt_search.Text != string.Empty)
                {
                    search();
                }
                else
                {
                    barangay_Presenter.LoadAllBarangay();
                }
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            barangay_Presenter.LoadAllBarangay();
        }

        private void dgrid_barangay_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedbrgy = dgrid_barangay.SelectedRows[0].DataBoundItem as Models.Barangay;
            if (selectedbrgy != null)
            {
                frm_barangay frm_Barangay = new frm_barangay();
                frm_Barangay.isview = true;
                frm_Barangay.putdata(this, selectedbrgy);
                frm_Barangay.ShowDialog(this);

                if (txt_search.Text != string.Empty)
                {
                    search();
                }
                else
                {
                    barangay_Presenter.LoadAllBarangay();
                }
            }
        }
    }
}
