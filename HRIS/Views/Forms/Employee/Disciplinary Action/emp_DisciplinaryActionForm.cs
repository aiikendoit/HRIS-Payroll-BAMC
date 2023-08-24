using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee.Disciplinary_Action;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Employee.Disciplinary_Action
{
    public partial class emp_DisciplinaryActionForm : Form, IEmployeeDisciplinaryActionView
    {
        public int EmpID;
        private readonly EmployeeDisciplinary_presenter emplDiscAct_presenter;
        public emp_DisciplinaryActionForm(int PkEmployeeID)
        {
            InitializeComponent();
            emplDiscAct_presenter = new EmployeeDisciplinary_presenter(this);
            EmpID = PkEmployeeID;
            UniversalStatic.customDatagrid(dgrid_disciplinaryAction);
            emplDiscAct_presenter.loadEmpDscActAll();
            loadAllDiscActWhere();
        }

        private void loadAllDiscActWhere()
        {
            emplDiscAct_presenter.loadEmpDiscAcWhere(EmpID);
        }

        public void ClearFields()
        {

        }

        public void DisplayEmployeeDscAct_All(List<Employeedisciplinary> employeedisciplinaries)
        {
            //dgrid_disciplinaryAction.DataSource = employeedisciplinaries;
            //dgrid_disciplinaryAction.Columns[0].HeaderText = "ID";
            //dgrid_disciplinaryAction.Columns["Description"].HeaderText = "Description";
            //dgrid_disciplinaryAction.Columns["Createddate"].HeaderText = "Created date";
            ////dgrid_disciplinaryAction.Columns["Createdby"].HeaderText = "Created by";
            //dgrid_disciplinaryAction.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //if (dgrid_disciplinaryAction.ColumnCount == 8)
            //{

            //    dgrid_disciplinaryAction.Columns.RemoveAt(7);
            //    dgrid_disciplinaryAction.Columns.RemoveAt(6);
            //    dgrid_disciplinaryAction.Columns.RemoveAt(5);
            //}
            //dgrid_disciplinaryAction.AutoGenerateColumns = false;
            //txt_totalcount.Text = "Total count(s): " + dgrid_disciplinaryAction.RowCount.ToString();
        }

        public void displayEmployeeDscAct_ListObject(List<object> employeedisciplinaries)
        {
            if (employeedisciplinaries != null && employeedisciplinaries.Count > 0)
            {
                dgrid_disciplinaryAction.AutoGenerateColumns = false;
                dgrid_disciplinaryAction.Columns["Code"].DataPropertyName = "PkEmployeedisciplinary";
                dgrid_disciplinaryAction.Columns["offensetype"].DataPropertyName = "FkOffensetype";
                dgrid_disciplinaryAction.Columns["disciplinaryType"].DataPropertyName = "FkDisciplinarytype";
                dgrid_disciplinaryAction.Columns["description"].DataPropertyName = "Description";
                dgrid_disciplinaryAction.Columns["lastname"].DataPropertyName = "Lastname";
                dgrid_disciplinaryAction.Columns["firstname"].DataPropertyName = "Firstname";

                dgrid_disciplinaryAction.DataSource = employeedisciplinaries;
            }
            else
            {
                dgrid_disciplinaryAction.DataSource = null; // Clear the DataGridView if licenseInfo is empty
            }

            //changeDgridSize();
            txt_totalcount.Text = "Total count(s): " + dgrid_disciplinaryAction.RowCount.ToString();
        }

        private void emp_DisciplinaryActionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
