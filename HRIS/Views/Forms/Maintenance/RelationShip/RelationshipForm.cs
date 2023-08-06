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

namespace HRIS.Views.Forms.Maintenance.RelationShip
{
    public partial class RelationshipForm : Form, IRelationshipView
    {
        private readonly relationship_Presenter relationship_Presenter;
        public RelationshipForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_relationship);
            relationship_Presenter = new relationship_Presenter(this);
            relationship_Presenter.loadRelationShip();

        }

        public void DisplayRelationship(List<Relationship> relationships)
        {
            dgrid_relationship.DataSource = relationships;
            dgrid_relationship.Columns[0].HeaderText = "ID";
            dgrid_relationship.Columns["Description"].HeaderText = "Relationship";
            dgrid_relationship.Columns["Createddate"].HeaderText = "Created date";
            dgrid_relationship.Columns["Createdby"].HeaderText = "Created by";
            dgrid_relationship.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgrid_relationship.ColumnCount == 7)
            {
                dgrid_relationship.Columns.RemoveAt(6);
                dgrid_relationship.Columns.RemoveAt(5);
            }
            dgrid_relationship.AutoGenerateColumns = false;
            txt_totalcount.Text = "Total count(s): " + dgrid_relationship.RowCount.ToString();
        }
        private void search()
        {
            string searchQuery = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                relationship_Presenter.loadRelationShip();
            }
            else
            {
                relationship_Presenter.SearchData(searchQuery);
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            frm_relationship_ad frm_Relationship_Ad = new frm_relationship_ad();
            frm_Relationship_Ad.ShowDialog();
            relationship_Presenter.loadRelationShip();
        }

        private void RelationshipForm_Load(object sender, EventArgs e)
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
            relationship_Presenter.loadRelationShip();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var selRelation = dgrid_relationship.SelectedRows[0].DataBoundItem as Models.Relationship;
            if (selRelation != null)
            {
                var degtype = new frm_relationship_ad();
                degtype.isupdate = true;
                degtype.putdata(this, selRelation);
                degtype.ShowDialog(this);
                if (txt_search.Text != string.Empty)
                {
                    relationship_Presenter.loadRelationShip();
                    search();
                }
                else
                {
                    relationship_Presenter.loadRelationShip();
                }

            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            var selRelation = dgrid_relationship.SelectedRows[0].DataBoundItem as Models.Relationship;
            if (selRelation != null)
            {
                var degtype = new frm_relationship_ad();
                degtype.putdata(this, selRelation);
                degtype.ShowDialog(this);
                if (txt_search.Text != string.Empty)
                {
                    relationship_Presenter.loadRelationShip();
                    search();
                }
                else
                {
                    relationship_Presenter.loadRelationShip();
                }

            }
        }
    }
}
