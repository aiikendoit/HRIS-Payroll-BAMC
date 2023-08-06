using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRIS.Views.Forms.Maintenance.NationalityFolder;
using System.Windows.Controls;
using HRIS.Views.Forms.Maintenance.ReligionFolder;
using HRIS.Views.Forms.Maintenance.Degreetype;

namespace HRIS.Views.Forms.Maintenance.NationalityFolder
{
    public partial class NationalityForm : Form, INationalityView
    {
        private readonly nationality_Presenter nationality_Presenter;
        public NationalityForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_nationality);
            nationality_Presenter = new nationality_Presenter(this);
            nationality_Presenter.loadNationality();
        }

        public void ClearFields()
        {
        }
        private void search()
        {
            string searchQuery = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                nationality_Presenter.loadNationality();
            }
            else
            {
                nationality_Presenter.SearchData(searchQuery);
            }
        }
        public void DisplayNationality(List<Nationality> Nationalities)
        {
            dgrid_nationality.DataSource = Nationalities;
            dgrid_nationality.Columns[0].HeaderText = "ID";
            dgrid_nationality.Columns["Description"].HeaderText = "Nationalities";
            dgrid_nationality.Columns["Createddate"].HeaderText = "Created date";
            dgrid_nationality.Columns["Createdby"].HeaderText = "Created by";
            dgrid_nationality.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgrid_nationality.ColumnCount == 8)
            {
                dgrid_nationality.Columns.RemoveAt(7);
                dgrid_nationality.Columns.RemoveAt(6);
                dgrid_nationality.Columns.RemoveAt(5);
            }
            dgrid_nationality.AutoGenerateColumns = false;
            txt_totalcount.Text = "Total count(s): " + dgrid_nationality.RowCount.ToString();
        }

        private void NationalityForm_Load(object sender, EventArgs e)
        {

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
            nationality_Presenter.loadNationality();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            var n = new frm_nationality_add();
            n.ShowDialog();
            nationality_Presenter.loadNationality();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var selectenationality = dgrid_nationality.SelectedRows[0].DataBoundItem as Models.Nationality;
            if (selectenationality != null)
            {
                var degtype = new frm_nationality_add();
                degtype.isupdate = true;
                degtype.putdata(this, selectenationality);
                degtype.ShowDialog(this);
                if (txt_search.Text != string.Empty)
                {
                    nationality_Presenter.loadNationality();
                    search();
                }
                else
                {
                    nationality_Presenter.loadNationality();
                }

            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            var selectenationality = dgrid_nationality.SelectedRows[0].DataBoundItem as Models.Nationality;
            if (selectenationality != null)
            {
                var degtype = new frm_nationality_add();
                degtype.putdata(this, selectenationality);
                degtype.ShowDialog(this);
                if (txt_search.Text != string.Empty)
                {
                    nationality_Presenter.loadNationality();
                    search();
                }
                else
                {
                    nationality_Presenter.loadNationality();
                }

            }
        }
    }
}
