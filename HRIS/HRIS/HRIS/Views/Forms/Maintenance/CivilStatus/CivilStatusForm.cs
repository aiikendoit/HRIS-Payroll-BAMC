using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace HRIS.Forms.Maintenance.CivilStatus
{
    public partial class CivilStatusForm : Form, ICivilStatusView
    {
        private readonly civilStatus_Presenter civilStatus_Presenter;
        public CivilStatusForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_civilstatus);
            civilStatus_Presenter = new civilStatus_Presenter(this);
            civilStatus_Presenter.LoadCivilStatus();
        }

        public void ClearFields()
        {
        }

       
        private void CivilStatusForm_Load(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            frm_civilstatus_add frm_Civilstatus_Add = new frm_civilstatus_add();
            frm_Civilstatus_Add.ShowDialog();
            civilStatus_Presenter.LoadCivilStatus();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var selectcivilstatus = dgrid_civilstatus.SelectedRows[0].DataBoundItem as Civilstatus;
            if (selectcivilstatus != null)
            {
                frm_civilstatus_add frm_Civilstatus_Add = new frm_civilstatus_add();
                frm_Civilstatus_Add.putdata(this, selectcivilstatus);
                frm_Civilstatus_Add.ShowDialog(this);
                civilStatus_Presenter.LoadCivilStatus();
            }
        }

        public void DisplayCivilStatus(List<Civilstatus> Civilstatuses)
        {
            dgrid_civilstatus.DataSource = Civilstatuses;
            dgrid_civilstatus.Columns[0].HeaderText = "ID";
            if (dgrid_civilstatus.ColumnCount == 8)
            {
                //Remove unnecessary column
                dgrid_civilstatus.Columns.RemoveAt(7);
                dgrid_civilstatus.Columns.RemoveAt(6);
                dgrid_civilstatus.Columns.RemoveAt(5);
            }
            dgrid_civilstatus.AutoGenerateColumns = false;
        }
    }
}
