using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.CivilStatus;
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

namespace HRIS.Forms.Maintenance.Degreetype
{
    public partial class DegreetypeForm : Form, IDegreeTypeView
    {
        private readonly degreetype_Presenter degreetype_Presenter;
        public DegreetypeForm()
        {
            InitializeComponent();
            degreetype_Presenter = new degreetype_Presenter(this);
            UniversalStatic.customDatagrid(dgrid_degreetype);
            degreetype_Presenter.LoadDegreeType();
        }

        public void DisplayDegreetype(List<Models.Degreetype> degreetypes)
        {
            dgrid_degreetype.DataSource = degreetypes;
            dgrid_degreetype.Columns[0].HeaderText = "ID";
            dgrid_degreetype.Columns["Description"].HeaderText = "Degree type";
            dgrid_degreetype.Columns["Createddate"].HeaderText = "Created date";
            dgrid_degreetype.Columns["Createdby"].HeaderText = "Created by";
            dgrid_degreetype.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgrid_degreetype.ColumnCount == 7)
            {
                dgrid_degreetype.Columns.RemoveAt(6);
                dgrid_degreetype.Columns.RemoveAt(5);
            }
            dgrid_degreetype.AutoGenerateColumns = false;
            txt_totalcount.Text = "Total count(s): " + dgrid_degreetype.RowCount.ToString();
        }

        private void DegreetypeForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            var degretype = new frm_degreeType();
            degretype.ShowDialog();
            degreetype_Presenter.LoadDegreeType();
        }
        private void search()
        {
            string searchQuery = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                degreetype_Presenter.LoadDegreeType();
            }
            else
            {
                degreetype_Presenter.SearchData(searchQuery);
            }
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            var selectedDegreetype = dgrid_degreetype.SelectedRows[0].DataBoundItem as Models.Degreetype;
            if (selectedDegreetype != null)
            {
                var degtype = new frm_degreeType();
                degtype.isupdate = true;
                degtype.putdata(this, selectedDegreetype);
                degtype.ShowDialog(this);
                if (txt_search.Text != string.Empty)
                {
                    degreetype_Presenter.LoadDegreeType();
                    search();
                }
                else
                {
                    degreetype_Presenter.LoadDegreeType();
                }
                
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            var selectedDegreetype = dgrid_degreetype.SelectedRows[0].DataBoundItem as Models.Degreetype;
            if (selectedDegreetype != null)
            {
                var degtype = new frm_degreeType();
                degtype.putdata(this, selectedDegreetype);
                degtype.ShowDialog(this);
                if (txt_search.Text != string.Empty)
                {
                    degreetype_Presenter.LoadDegreeType();
                    search();
                }
                else
                {
                    degreetype_Presenter.LoadDegreeType();
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
            degreetype_Presenter.LoadDegreeType();
        }
    }
}
