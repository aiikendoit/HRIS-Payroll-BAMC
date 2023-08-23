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
        private readonly EmployeeDisciplinary_presenter emplDiscAct_presenter;
        public emp_DisciplinaryActionForm()
        {
            InitializeComponent();
            emplDiscAct_presenter = new EmployeeDisciplinary_presenter(this);
            UniversalStatic.customDatagrid(dgrid_disciplinaryAction);
            emplDiscAct_presenter.loadEmpDscActAll();
        }

        public void ClearFields()
        {

        }

        public void DisplayEmployeeDscAct(List<Employeedisciplinary> employeedisciplinaries)
        {
            dgrid_disciplinaryAction.DataSource = employeedisciplinaries;
            dgrid_disciplinaryAction.Columns[0].HeaderText = "ID";
            dgrid_disciplinaryAction.Columns["Description"].HeaderText = "Description";
            dgrid_disciplinaryAction.Columns["Createddate"].HeaderText = "Created date";
            //dgrid_disciplinaryAction.Columns["Createdby"].HeaderText = "Created by";
            dgrid_disciplinaryAction.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgrid_disciplinaryAction.ColumnCount == 8)
            {

                dgrid_disciplinaryAction.Columns.RemoveAt(7);
                dgrid_disciplinaryAction.Columns.RemoveAt(6);
                dgrid_disciplinaryAction.Columns.RemoveAt(5);
            }
            dgrid_disciplinaryAction.AutoGenerateColumns = false;
            txt_totalcount.Text = "Total count(s): " + dgrid_disciplinaryAction.RowCount.ToString();
        }

        private void emp_DisciplinaryActionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
