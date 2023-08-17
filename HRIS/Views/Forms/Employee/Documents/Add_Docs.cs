using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.Document;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HRIS.Views.Forms.Employee.Documents
{
    public partial class Add_Docs : Form, IEmployeeView, IDocumentTypeView, IEmployeeDocumentView
    {
        int EmpID = 0;
        private readonly employee_Presenter emp_Presenter;
        private readonly documenttype_Presenter doctype_Presenter;
        private readonly EmployeeDocument_Presenter empDocs_Presenter;
        private readonly HrisContext _context;
        public bool isUpdate;
        public Add_Docs(int PkEmployee)
        {
            InitializeComponent();
            doctype_Presenter = new documenttype_Presenter(this);
            emp_Presenter = new employee_Presenter(this);
            empDocs_Presenter = new EmployeeDocument_Presenter(this);
            _context = new HrisContext();
            EmpID = PkEmployee;
            doctype_Presenter.LoadDocumenttype();

        }

        public void DisplayDocumentype(List<Doctype> documentTypes)
        {
            comboBox_DocType.DataSource = documentTypes;
            comboBox_DocType.ValueMember = "PkDoctype";
            comboBox_DocType.DisplayMember = "Description";
        }

        public void DisplayEmployee(List<Models.Employee> employees)
        {

        }

        public void DisplayEmployeeAllDetails(List<Models.Employee> employees)
        {

        }

        public void DisplayEmployeeCustomView(List<object> employees)
        {
            //throw new NotImplementedException();
        }

        private void Add_Docs_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                update();
            }
            else
            {
                save();
            }
        }

        private void update()
        {
            //throw new NotImplementedException();
        }

        private void save()
        {
            try
            {

                //if (UniversalStatic.IsEmpty(txt_expiryreminder)) return;
                string? createdby = Properties.Settings.Default.completename;
                int id = Properties.Settings.Default.usercode;
                var cv = new Models.Employeedocument
                {
                    FkEmployee = EmpID,
                    FkDoctype = Convert.ToInt32(comboBox_DocType.SelectedValue),
                    Description = textBox_Description.Text,
                    Remarks = richTextBox_Remarks.Text,
                    Createdby = createdby,
                    FkSystemUser = id
                };
                empDocs_Presenter.add_EmployeeDocs(cv);
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }

        public void DisplayEmployees(List<Employeedocument> Employeedocuments)
        {
            throw new NotImplementedException();
        }

        public void DisplayEmployeeInActive(List<object> employees)
        {
            throw new NotImplementedException();
        }
    }
}
