using HRIS.Class;
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

namespace HRIS.Views.Forms.Maintenance.Offensetype
{
    public partial class OffenceTypeForm : Form, IOffenceTypeView
    {
        private readonly offencetype_Presenter offencetype_Presenter;
        public OffenceTypeForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_offencetype);
            offencetype_Presenter = new offencetype_Presenter(this);
            offencetype_Presenter.LoadOffensetype();
        }

        public void DisplayOffencetype(List<Models.Offensetype> offensetypes)
        {
            dgrid_offencetype.DataSource = offensetypes;
            dgrid_offencetype.Columns[0].HeaderText = "ID";
            dgrid_offencetype.Columns["Description"].HeaderText = "Degree type";
            dgrid_offencetype.Columns["Createddate"].HeaderText = "Created date";
            dgrid_offencetype.Columns["Createdby"].HeaderText = "Created by";
            dgrid_offencetype.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgrid_offencetype.ColumnCount == 8)
            {
                dgrid_offencetype.Columns.RemoveAt(7);
                dgrid_offencetype.Columns.RemoveAt(6);
            }
            dgrid_offencetype.AutoGenerateColumns = false;
            txt_totalcount.Text = "Total count(s): " + dgrid_offencetype.RowCount.ToString();
        }
        private void search()
        {
            string searchQuery = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                offencetype_Presenter.LoadOffensetype();
            }
            else
            {
                offencetype_Presenter.SearchData(searchQuery);
            }
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            var ot = new frm_offencetype();
            ot.ShowDialog();
            offencetype_Presenter.LoadOffensetype();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var selecteoffence = dgrid_offencetype.SelectedRows[0].DataBoundItem as Models.Offensetype;
            if (selecteoffence != null)
            {
                var degtype = new frm_offencetype();
                degtype.isupdate = true;
                degtype.putdata(this, selecteoffence);
                degtype.ShowDialog(this);
                if (txt_search.Text != string.Empty)
                {
                    offencetype_Presenter.LoadOffensetype();
                    search();
                }
                else
                {
                    offencetype_Presenter.LoadOffensetype();
                }

            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            var selecteoffence = dgrid_offencetype.SelectedRows[0].DataBoundItem as Models.Offensetype;
            if (selecteoffence != null)
            {
                var degtype = new frm_offencetype();
                degtype.putdata(this, selecteoffence);
                degtype.ShowDialog(this);
                if (txt_search.Text != string.Empty)
                {
                    offencetype_Presenter.LoadOffensetype();
                    search();
                }
                else
                {
                    offencetype_Presenter.LoadOffensetype();
                }

            }
        }
    }
}
