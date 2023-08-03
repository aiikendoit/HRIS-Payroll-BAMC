using HRIS.Forms.Maintenance.Degreetype;
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
        private RelationshipForm relationshipForm;
        private Models.Relationship Selectedrelationship;
        public bool isupdate = false;
        public frm_relationship_ad()
        {
            InitializeComponent();
            relationship_Presenter = new relationship_Presenter(this);
            relationshipForm = new RelationshipForm();
            Selectedrelationship = new Models.Relationship();
        }


        public void DisplayRelationship(List<Relationship> relationships)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isupdate)
            {
                update();
            }
            else
            {
                save();
            }
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
          if (!relationship_Presenter.AddRelationship(cv))
            {
                this.Close();
            }
           
        }
        public void putdata(RelationshipForm relationshipForm, Models.Relationship relationship)
        {
            if (isupdate)
            {
                btn_cancel.Select();
                this.relationshipForm = relationshipForm;
                this.Selectedrelationship = relationship;
                txt_relationship.Text = Selectedrelationship.Description;
                checkBox_isactive.Checked = Selectedrelationship.Isactive;
            }
            else
            {
                btn_cancel.Select();
                this.relationshipForm = relationshipForm;
                this.Selectedrelationship = relationship;
                txt_relationship.Text = Selectedrelationship.Description;
                checkBox_isactive.Checked = Selectedrelationship.Isactive;
                //disable control
                txt_relationship.Enabled = false;
                checkBox_isactive.Enabled = false;
                btn_save.Visible = false;
            }
        }
        private void update()
        {

            var selRelation = Selectedrelationship as Models.Relationship;

            selRelation.Description = txt_relationship.Text;
            selRelation.Isactive = checkBox_isactive.Checked;
            relationship_Presenter.UpdateRelationship(selRelation);
            this.Close();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
