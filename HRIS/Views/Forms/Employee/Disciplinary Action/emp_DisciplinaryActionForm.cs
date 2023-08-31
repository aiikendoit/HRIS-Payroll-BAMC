using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee.Disciplinary_Action;
using HRIS.Views.Forms.Employee.Documents;
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
        public emp_DisciplinaryActionForm(int PkEmployeeID, bool isUpdate)
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_disciplinaryAction);
            emplDiscAct_presenter = new EmployeeDisciplinary_presenter(this);
            EmpID = PkEmployeeID;

            emplDiscAct_presenter.loadEmpDscActAll();
            loadAllDiscActWhere();

            // btn_viewDocs.Click += btn_viewDocs_Click;
            if (isUpdate == false)
            {
                btn_new.Visible = false;
                btn_edit.Visible = false;
                btn_view.Visible = true;
            }
        }

        private void loadAllDiscActWhere()
        {
            emplDiscAct_presenter.loadEmpDiscAcWhere(EmpID);
            editButtonColumn.Text = "Edit"; // Set default text for the button
            editButtonColumn.UseColumnTextForButtonValue = true; // This will display the text in the button cells
            viewButtonColumn.Text = "View";
            viewButtonColumn.UseColumnTextForButtonValue = true;
        }

        public void ClearFields()
        {

        }

        public void DisplayEmployeeDscAct_All(List<Employeedisciplinary> employeedisciplinaries)
        {

        }

        public void displayEmployeeDscAct_ListObject(List<object> employeedisciplinaries)
        {
            if (employeedisciplinaries != null && employeedisciplinaries.Count > 0)
            {
                dgrid_disciplinaryAction.AutoGenerateColumns = false;
                dgrid_disciplinaryAction.Columns["Code"].DataPropertyName = "PkEmployeedisciplinary";
                dgrid_disciplinaryAction.Columns["offensetypeDescr"].DataPropertyName = "FK_offensetype";
                dgrid_disciplinaryAction.Columns["disciplinaryTypeName"].DataPropertyName = "FK_disciplinarytype";
                dgrid_disciplinaryAction.Columns["empDA_Descr"].DataPropertyName = "Description";
                dgrid_disciplinaryAction.Columns["datestart"].DataPropertyName = "Datestart";
                dgrid_disciplinaryAction.Columns["dateEnd"].DataPropertyName = "Dateend";
                dgrid_disciplinaryAction.Columns["file"].DataPropertyName = "File";
                dgrid_disciplinaryAction.Columns["createdDate"].DataPropertyName = "Createddate";
                dgrid_disciplinaryAction.Columns["createdBy"].DataPropertyName = "Createdby";
                //dgrid_disciplinaryAction.Columns["fkSystemUser"].DataPropertyName = "FK_systemUser";

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

        private void btn_new_Click(object sender, EventArgs e)
        {
            var addNew = new Add_empDiscipAction(EmpID);
            addNew.ShowDialog();
            loadAllDiscActWhere();
        }

        private void dgrid_disciplinaryAction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgrid_disciplinaryAction.Rows[e.RowIndex];

                if (e.ColumnIndex == editButtonColumn.Index)
                {
                    var PkEmployeediscplnryActn = dgrid_disciplinaryAction.SelectedRows[0].Cells[0].Value;
                    Add_empDiscipAction empDiscplnryActn = new Add_empDiscipAction(EmpID);
                    empDiscplnryActn.isUpdate = true;
                    empDiscplnryActn.putdata(Convert.ToInt32(PkEmployeediscplnryActn));
                    empDiscplnryActn.ShowDialog();
                    loadAllDiscActWhere();
                }
                else if (e.ColumnIndex == viewButtonColumn.Index)
                {
                    int PKEmployeeID = (int)row.Cells[0].Value;
                    var empDocs = new PreviewDocs(PKEmployeeID);
                    empDocs.ShowDialog(this);
                }
            }
        }
    }
}
