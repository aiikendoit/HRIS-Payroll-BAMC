using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee.Work_Assignment;
using HRIS.Views.Forms.Maintenance.Department;
using HRIS.Views.Forms.Maintenance.Positions;
using Microsoft.EntityFrameworkCore;
using Syncfusion.WinForms.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HRIS.Forms.Employee.Work_Assignment
{
    public partial class emp_AddworkAssignment : Form, IDeparmentView, IPositionView, IWorkAssigmentView
    {
        private readonly department_Presenter department_presenter;
        private readonly position_Presenter position_presenter;
        private readonly workassignment_Presenter workassignment_presenter;
        private readonly HrisContext _context;
        private string emp_ID;
        private int workassignmentid;
        public bool isUpdate = false;
        string selectedFilePath = string.Empty;
        public emp_AddworkAssignment(string employeeid)
        {
            InitializeComponent();
            department_presenter = new department_Presenter(this);
            position_presenter = new position_Presenter(this);
            workassignment_presenter = new workassignment_Presenter(this);
            _context = new HrisContext();
            department_presenter.LoadDepartment();
            emp_ID = employeeid;
        }

        public void DisplayDepartment(List<Department> departments)
        {
            txt_department.SelectedIndexChanged -= txt_department_SelectedIndexChanged;
            txt_department.DataSource = departments;
            txt_department.DisplayMember = "Description";
            txt_department.ValueMember = "PkDepartment";
            txt_department.SelectedIndexChanged += txt_department_SelectedIndexChanged;
        }

        public void DisplayPosition(List<Position> positions)
        {
            txt_position.DataSource = positions;
            txt_position.DisplayMember = "positionName";
            txt_position.ValueMember = "PkPosition";
        }

        private void emp_AddworkAssignment_Load(object sender, EventArgs e)
        {

        }

        private void txt_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            int departmentid = Convert.ToInt32(txt_department.SelectedValue);
            position_presenter.LoadPositionwithWhere(departmentid);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                update();
            }
            else
            {
                add();
            }


        }
        private void add()
        {
            try
            {

                string? createdby = Properties.Settings.Default.completename;
                int id = Properties.Settings.Default.usercode;
                var cv = new Workassignment
                {
                    FkEmployee = Convert.ToInt32(emp_ID),
                    FkDepartment = Convert.ToInt32(txt_department.SelectedValue),
                    FkPosition = Convert.ToInt32(txt_position.SelectedValue),
                    IsManager = checkBox_ishead.Checked,
                    Startdate = txt_startdate.Value,
                    Enddate = txt_enddate.Value,
                    Createdby = createdby,
                    FkSystemUser = id
                };
                if (!string.IsNullOrEmpty(selectedFilePath)) // Make sure a file is selected
                {
                    byte[] fileData = File.ReadAllBytes(selectedFilePath);
                    cv.Jobdescription = fileData; // Set the file data to the EmployeeDocs property
                }
                workassignment_presenter.AddWorkAssignment(cv);
                this.Close();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    // Display the inner exception details
                    MessageBox.Show($"An error occurred while saving the entity changes. Inner exception: {ex.InnerException.Message}");
                }
                else
                {
                    // Display the exception message if there is no inner exception
                    MessageBox.Show($"An error occurred while saving the entity changes. Exception: {ex.Message}");
                }
            }
        }
        private void update()
        {
            try
            {
                var existingWorkAssignment = _context.Workassignments.Find(workassignmentid);


                if (existingWorkAssignment != null)
                {
                    existingWorkAssignment.FkDepartment = Convert.ToInt32(txt_department.SelectedValue);
                    existingWorkAssignment.FkPosition = Convert.ToInt32(txt_position.SelectedValue);
                    existingWorkAssignment.FkEmployee = Convert.ToInt32(emp_ID);
                    existingWorkAssignment.IsManager = checkBox_ishead.Checked;
                    existingWorkAssignment.Startdate = txt_startdate.Value;
                    existingWorkAssignment.Enddate = txt_enddate.Value;
                    if (!string.IsNullOrEmpty(selectedFilePath)) // Make sure a file is selected
                    {
                        byte[] fileData = File.ReadAllBytes(selectedFilePath);
                        existingWorkAssignment.Jobdescription = fileData; // Set the file data to the EmployeeDocs property
                    }
                    workassignment_presenter.UpdateWorkAssignment(existingWorkAssignment);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    // Display the inner exception details
                    MessageBox.Show($"An error occurred while saving the entity changes. Inner exception: {ex.InnerException.Message}");
                }
                else
                {
                    // Display the exception message if there is no inner exception
                    MessageBox.Show($"An error occurred while saving the entity changes. Exception: {ex.Message}");
                }
            }
        }
        public void putdata(int workass)
        {
            if (isUpdate)
            {
                workassignmentid = workass;
                workassignment_presenter.loadWorkAssignmentWithWhere(workass);
                txt_enddate.Enabled = true;
                btn_cancel.Select();
                label_header.Text = "Edit Work Assignment";
            }
            else
            {

                workassignmentid = workass;
                workassignment_presenter.loadWorkAssignmentWithWhere(workass);
                txt_enddate.Enabled = true;
                btn_save.Visible = false;
                btn_cancel.Select();
                //disable control
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox ||
                        control is SfDateTimeEdit ||
                        control is ComboBox || control is CheckBox)
                    {
                        control.Enabled = false;
                    }
                }
                label_header.Text = "View Work Assignment";
            }

        }

        public void DisplayWorkAssignment(List<Workassignment> workassignments)
        {
            try
            {
                if (workassignments != null && workassignments.Count > 0)
                {
                    Models.Workassignment wk = workassignments[0];
                    txt_department.SelectedValue = wk.FkDepartment;
                    txt_position.SelectedValue = wk.FkPosition;
                    checkBox_ishead.Checked = wk.IsManager;
                    txt_startdate.Value = wk.Startdate;
                    txt_enddate.Value = wk.Enddate;
                    if (wk.Jobdescription != null && wk.Jobdescription.Length > 0)
                    {
                        byte[] ap = wk.Jobdescription;
                        MemoryStream ms = new MemoryStream(ap);

                        // Load and display the Base64-encoded PDF using Syncfusion PdfViewerControl
                        pdfViewerControl1.Load(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"An error occurred while saving the entity changes. Inner exception: {ex.InnerException.Message}");
                }
                else
                {
                    MessageBox.Show($"An error occurred while saving the entity changes. Exception: {ex.Message}");
                }
            }
        }

        private void txt_enddate_ValueChanged(object sender, EventArgs e)
        {
        }

        public void DisplayWorkAssignmentCustom(List<object> workassingmentlist)
        {
            throw new NotImplementedException();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_attachfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|TIF Files (*.tif)|*.tif|PDF Files (*.pdf)|*.pdf";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;
                    selectedFilePath = filePath;
                    string extension = Path.GetExtension(filePath).ToLower();

                    if (extension == ".pdf")
                    {
                        // Handle PDF loading using a PDF rendering library
                        // Load and display the PDF content in your application
                        txt_jobdescription.Text = filePath;
                        pdfViewerControl1.Load(filePath);
                    }
                    else if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".tif" || extension == ".tiff")
                    {
                        //Image image = Image.FromFile(filePath);
                        txt_jobdescription.Text = filePath;
                    }
                    else
                    {
                        MessageBox.Show("Unsupported file format. Please select a JPEG, PNG, TIF, or PDF file.");
                    }
                }
            }



        }
    }
}
