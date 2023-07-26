using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.Department;
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

namespace HRIS.Views.Forms.Maintenance.Positions
{
    public partial class frm_position : Form, IPositionView, IDeparmentView
    {
        private readonly position_Presenter position_Presenter;
        private readonly department_Presenter department_Presenter;
        public frm_position()
        {
            InitializeComponent();
            position_Presenter = new position_Presenter(this);
            department_Presenter = new department_Presenter(this);
            UniversalStatic.customDatagrid(dgrid_position);
            department_Presenter.LoadDepartment();
        }


        private void addposition()
        {
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Position
            {
                FkDepartment = Convert.ToInt32(txt_department.SelectedValue),
                PositionName = txt_position.Text,
                IsActive = checkBox_isactive.Checked,
                Createdby = createdby,
                FkSystemUser = id
            };
            int departmentid = Convert.ToInt32(txt_department.SelectedValue);
            position_Presenter.AddPosition(cv, departmentid);
        }

        private void frm_position_Load(object sender, EventArgs e)
        {

        }


        public void DisplayDepartment(List<Models.Department> departments)
        {
            txt_department.SelectedIndexChanged -= txt_department_SelectedIndexChanged;
            txt_department.DataSource = departments;
            txt_department.ValueMember = "PkDepartment";
            txt_department.DisplayMember = "Description";
            txt_department.SelectedIndex = -1;
            txt_department.SelectedIndexChanged += txt_department_SelectedIndexChanged;
        }
        public void DisplayPosition(List<Position> positions)
        {
            dgrid_position.DataSource = positions;
            dgrid_position.Columns[0].HeaderText = "ID";
            DataGridView dataGridView = dgrid_position;
            int[] columnsToKeep = new int[] { 0, 1, 2 };
            for (int i = dataGridView.Columns.Count - 1; i >= 0; i--)
            {
                if (!columnsToKeep.Contains(i))
                {
                    dataGridView.Columns.RemoveAt(i);
                }
            }
            dgrid_position.Columns["FkDepartment"].HeaderText = "Department ID";
            dgrid_position.Columns["Description"].HeaderText = "Position";
            dgrid_position.AutoGenerateColumns = false;
        }

        private void txt_department_SelectedIndexChanged(object sender, EventArgs e)
        {

            int selecteddepartment = Convert.ToInt32(txt_department.SelectedValue);
            position_Presenter.LoadPositionwithWhere(selecteddepartment);
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            addposition();
            
        }
        private void loadposition()
        {
            int dptid = Convert.ToInt32(txt_department.SelectedValue.ToString());
            position_Presenter.LoadPositionwithWhere(dptid);
        }
        private void btn_update_Click(object sender, EventArgs e)
        {

            if (dgrid_position.SelectedRows.Count > 0)
            {
                var selectposition = dgrid_position.SelectedRows[0].DataBoundItem as Models.Position;
                if (selectposition != null)
                {
                    selectposition.PositionName = txt_position.Text;
                    selectposition.IsActive = checkBox_isactive.Checked;
                    position_Presenter.UpdatePosition(selectposition);
                    MessageBox.Show("Update Successfully!");
                    loadposition();
                }
            }
        }

        private void dgrid_position_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var selectedRow = dgrid_position.Rows[e.RowIndex];
                var selectedPerson = selectedRow.DataBoundItem as Models.Position;
                txt_position.Text = selectedPerson?.PositionName;
                checkBox_isactive.Checked = selectedPerson?.IsActive ?? false;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgrid_position.SelectedRows.Count > 0)
            {
                var selectedPerson = dgrid_position.SelectedRows[0].DataBoundItem as Models.Position;
                if (selectedPerson != null)
                {
                    position_Presenter.DeletePosition(selectedPerson);
                    MessageBox.Show("Deleted Successfully!");
                    loadposition();
                }
            }
        }
    }
}
