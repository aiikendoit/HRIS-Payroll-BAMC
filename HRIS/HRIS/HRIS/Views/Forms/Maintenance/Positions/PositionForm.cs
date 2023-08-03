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

namespace HRIS.Views.Forms.Maintenance.Positions
{
    public partial class PositionForm : Form, IPositionView
    {
        private readonly position_Presenter position_presenter;
        public PositionForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_position);
            position_presenter = new position_Presenter(this);
            position_presenter.LoadPosition();
        }

        public void DisplayPosition(List<Position> positions)
        {
            dgrid_position.DataSource = positions;
            dgrid_position.Columns[0].HeaderText = "ID";
            dgrid_position.Columns[2].HeaderText = "Position Name";
            dgrid_position.Columns["Createddate"].HeaderText = "Created date";
            dgrid_position.Columns["Createdby"].HeaderText = "Created by";
            dgrid_position.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgrid_position.ColumnCount == 10)
            {
                dgrid_position.Columns.RemoveAt(9);
                dgrid_position.Columns.RemoveAt(8);
                dgrid_position.Columns.RemoveAt(7);
                dgrid_position.Columns.RemoveAt(6);
                dgrid_position.Columns.RemoveAt(1);
            }
            dgrid_position.AutoGenerateColumns = false;
            txt_totalcount.Text = "Total count(s): " + dgrid_position.RowCount.ToString();
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            var p = new frm_position();
            p.ShowDialog();
            position_presenter.LoadPosition();
        }
        private void search()
        {
            string searchQuery = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                position_presenter.LoadPosition();
            }
            else
            {
                position_presenter.SearchData(searchQuery);
            }
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            var selectedPosition = dgrid_position.SelectedRows[0].DataBoundItem as Models.Position;
            if (selectedPosition != null)
            {
                var degtype = new frm_position();
                degtype.isupdate = true;
                degtype.putdata(this, selectedPosition);
                degtype.ShowDialog(this);
                if (txt_search.Text != string.Empty)
                {
                    position_presenter.LoadPosition();
                    search();
                }
                else
                {
                    position_presenter.LoadPosition();
                }

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            position_presenter.LoadPosition();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            var selectedPosition = dgrid_position.SelectedRows[0].DataBoundItem as Models.Position;
            if (selectedPosition != null)
            {
                var degtype = new frm_position();
                degtype.putdata(this, selectedPosition);
                degtype.ShowDialog(this);
                if (txt_search.Text != string.Empty)
                {
                    position_presenter.LoadPosition();
                    search();
                }
                else
                {
                    position_presenter.LoadPosition();
                }

            }
        }
    }
}
