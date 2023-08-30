using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using HRIS.Views.Forms.Maintenance.RelationShip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Employee.Family_and_Dependents
{
    public partial class emp_AddDependent : Form, IRelationshipView, ICivilStatusView
    {

        private readonly relationship_Presenter relationship_Presenter;
        private readonly civilStatus_Presenter civilStatus_Presenter;

        public emp_AddDependent()
        {
            InitializeComponent();
            relationship_Presenter = new relationship_Presenter(this);
            relationship_Presenter.loadRelationShip();

            civilStatus_Presenter = new civilStatus_Presenter(this);
            civilStatus_Presenter.LoadCivilStatus();
        }

        public void ClearFields()
        {
        }
        public void DisplayRelationship(List<Relationship> relationships)
        {
            //Relationship relationshipCombo = relationships[0];
            txt_relationshipcombo.DataSource = relationships;
            txt_relationshipcombo.ValueMember = "PkRelationship";
            txt_relationshipcombo.DisplayMember = "Description";

        }
        public void DisplayCivilStatus(List<Civilstatus> Civilstatuses)
        {
            txt_civilstatuscombo.DataSource = Civilstatuses;
            txt_civilstatuscombo.ValueMember = "PkCivilstatus";
            txt_civilstatuscombo.DisplayMember = "Description";
        }
    }
}
