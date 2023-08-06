using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
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

namespace HRIS.Views.Forms.Maintenance.SalarySetting
{
    public partial class SalarySettingForm : Form, ISalarySettingView
    {
        private readonly salarysetting_Presenter salarysetting_Presenter;
        public SalarySettingForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_salarysetting);
            salarysetting_Presenter = new salarysetting_Presenter(this);
            salarysetting_Presenter.LoadSalarysetting();
        }

        public void DisplaySalarysetting(List<Salarytype> salarytypes)
        {
            dgrid_salarysetting.DataSource = salarytypes;
            dgrid_salarysetting.Columns[0].HeaderText = "ID";
            dgrid_salarysetting.Columns[3].HeaderText = "Allowance?";
            dgrid_salarysetting.Columns[4].HeaderText = "BasicPay?";
            dgrid_salarysetting.Columns[5].HeaderText = "Bonus?";
            dgrid_salarysetting.Columns[6].HeaderText = "13 Month?";
            dgrid_salarysetting.Columns[7].HeaderText = "Taxable?";
            dgrid_salarysetting.Columns[8].HeaderText = "Pct?";
            dgrid_salarysetting.Columns[9].HeaderText = "COLA?";
            //dgrid_salarysetting.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgrid_salarysetting.ColumnCount == 16)
            {
                dgrid_salarysetting.Columns.RemoveAt(15);
                dgrid_salarysetting.Columns.RemoveAt(14);
                dgrid_salarysetting.Columns.RemoveAt(13);
                dgrid_salarysetting.Columns.RemoveAt(12);
                dgrid_salarysetting.Columns.RemoveAt(11);
                dgrid_salarysetting.Columns.RemoveAt(1);
            }
            dgrid_salarysetting.AutoGenerateColumns = false;
            txt_totalcount.Text = "Total count(s): " + dgrid_salarysetting.RowCount.ToString();
        }

        private void dgrid_salarysetting_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgrid_salarysetting.Columns[0].Width = 80;
            dgrid_salarysetting.Columns[1].Width = 150;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            var st = new frm_salarysetting();
            st.ShowDialog();
            salarysetting_Presenter.LoadSalarysetting();
        }
        private void search()
        {
            string searchQuery = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                salarysetting_Presenter.LoadSalarysetting();
            }
            else
            {
                salarysetting_Presenter.SearchData(searchQuery);
            }
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            var selectedsalary = dgrid_salarysetting.SelectedRows[0].DataBoundItem as Models.Salarytype;
            if (selectedsalary != null)
            {
                var ss = new frm_salarysetting();
                ss.isupdate = true;
                ss.putdata(this, selectedsalary);
                ss.ShowDialog(this);
                if (txt_search.Text != string.Empty)
                {
                    salarysetting_Presenter.LoadSalarysetting();
                    search();
                }
                else
                {
                    salarysetting_Presenter.LoadSalarysetting();
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
            salarysetting_Presenter.LoadSalarysetting();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            var selectedsalary = dgrid_salarysetting.SelectedRows[0].DataBoundItem as Models.Salarytype;
            if (selectedsalary != null)
            {
                var ss = new frm_salarysetting();
                ss.putdata(this, selectedsalary);
                ss.ShowDialog(this);
                if (txt_search.Text != string.Empty)
                {
                    salarysetting_Presenter.LoadSalarysetting();
                    search();
                }
                else
                {
                    salarysetting_Presenter.LoadSalarysetting();
                }
            }
        }
    }
}
