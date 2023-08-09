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

namespace HRIS.Views.Forms.Maintenance.WageFactor
{
    public partial class WageFactorForm : Form, IWageFactorView
    {
        private readonly wagefactor_Presenter wagefactor_Presenter;
        public WageFactorForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_wagefactor);
            wagefactor_Presenter = new wagefactor_Presenter(this);
            wagefactor_Presenter.LoadWagefactor();
        }

        public void DisplayWageFactor(List<Wagefactor> wageFactorList)
        {
            dgrid_wagefactor.DataSource = wageFactorList;
            dgrid_wagefactor.Columns[0].HeaderText = "ID";
            dgrid_wagefactor.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgrid_wagefactor.ColumnCount == 7)
            {
                dgrid_wagefactor.Columns.RemoveAt(6);
            }
            dgrid_wagefactor.AutoGenerateColumns = false;
            txt_totalcount.Text = "Total count(s): " + dgrid_wagefactor.RowCount.ToString();
        }

        private void dgrid_wagefactor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgrid_wagefactor.Columns[0].Width = 80;
            dgrid_wagefactor.Columns[1].Width = 100;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            var w = new frm_wagefactor();
            w.ShowDialog();
            wagefactor_Presenter.LoadWagefactor();
        }
        private void search()
        {
            string searchQuery = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                wagefactor_Presenter.LoadWagefactor();
            }
            else
            {
                wagefactor_Presenter.SearchData(searchQuery);
            }
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            var selectedwage = dgrid_wagefactor.SelectedRows[0].DataBoundItem as Models.Wagefactor;
            if (selectedwage != null)
            {
                var degtype = new frm_wagefactor();
                degtype.isupdate = true;
                degtype.putdata(this, selectedwage);
                degtype.ShowDialog(this);
                if (txt_search.Text != string.Empty)
                {
                    wagefactor_Presenter.LoadWagefactor();
                    search();
                }
                else
                {
                    wagefactor_Presenter.LoadWagefactor();
                }

            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            var selectedwage = dgrid_wagefactor.SelectedRows[0].DataBoundItem as Models.Wagefactor;
            if (selectedwage != null)
            {
                var degtype = new frm_wagefactor();
                degtype.putdata(this, selectedwage);
                degtype.ShowDialog(this);
                if (txt_search.Text != string.Empty)
                {
                    wagefactor_Presenter.LoadWagefactor();
                    search();
                }
                else
                {
                    wagefactor_Presenter.LoadWagefactor();
                }

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


        private void btn_refresh_Click(object sender, EventArgs e)
        {
            wagefactor_Presenter.LoadWagefactor();
        }
    }
}
