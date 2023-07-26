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
    public partial class frm_relationship_ad : Form, IRelationshipView
    {
        private readonly relationship_Presenter relationship_Presenter;
        public frm_relationship_ad()
        {
            InitializeComponent();
            relationship_Presenter = new relationship_Presenter(this);
        }


        public void DisplayRelationship(List<Relationship> relationships)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            save();
        }
        private void save()
        {
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Relationship
            {
                Description = txt_relationship.Text,
                Isactive = checkBox_isactive.Checked,
                Createdby = createdby,
                FkSystemUser = id
            };
            relationship_Presenter.AddRelationship(cv);
            MessageBox.Show("Added Successfully!");
            this.Close();
        }
    }
}
