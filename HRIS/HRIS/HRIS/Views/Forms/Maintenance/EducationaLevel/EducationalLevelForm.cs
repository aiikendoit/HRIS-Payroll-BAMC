using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using HRIS.Views.Forms.Maintenance.EducationaLevel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Maintenance.EducationaLevel
{
    public partial class EducationalLevelForm : Form, IEducationLevelView
    {
        private readonly educationlevel_Presenter educationlevel_Presenter;
        public EducationalLevelForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_educationalLevel);
            educationlevel_Presenter = new educationlevel_Presenter(this);
            educationlevel_Presenter.LoadEducationallevel();

        }

        public void DisplayEducationalLevel(List<Educationallevel> Educationallevels)
        {
            dgrid_educationalLevel.DataSource = Educationallevels;
            dgrid_educationalLevel.Columns[0].HeaderText = "ID";
            if (dgrid_educationalLevel.ColumnCount == 10)
            {
                //Remove unnecessary column
                dgrid_educationalLevel.Columns.RemoveAt(7);
                dgrid_educationalLevel.Columns.RemoveAt(6);
                dgrid_educationalLevel.Columns.RemoveAt(5);
                dgrid_educationalLevel.Columns.RemoveAt(4);
            }
            dgrid_educationalLevel.AutoGenerateColumns = false;
        }

        private void EducationalLevelForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var p = new frm_educationllevel_add();
            p.ShowDialog();
            educationlevel_Presenter.LoadEducationallevel();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var selectcivilstatus = dgrid_educationalLevel.SelectedRows[0].DataBoundItem as Models.Educationallevel;
            if (selectcivilstatus != null)
            {
                frm_educationllevel_add frm_Educationllevel_Add = new frm_educationllevel_add();
                frm_Educationllevel_Add.putdata(this, selectcivilstatus);
                frm_Educationllevel_Add.ShowDialog(this);
                educationlevel_Presenter.LoadEducationallevel();
            }
        }
    }
}
