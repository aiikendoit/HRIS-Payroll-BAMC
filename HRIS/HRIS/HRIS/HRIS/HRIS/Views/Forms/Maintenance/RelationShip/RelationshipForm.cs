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
            if (dgrid_relationship.ColumnCount == 9)
            {
                //Remove unnecessary column
                dgrid_relationship.Columns.RemoveAt(7);
                dgrid_relationship.Columns.RemoveAt(6);
                dgrid_relationship.Columns.RemoveAt(5);
                dgrid_relationship.Columns.RemoveAt(4);
            }
            dgrid_relationship.AutoGenerateColumns = false;
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
    }
}
