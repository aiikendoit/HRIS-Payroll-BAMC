using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee.Employment;
using HRIS.Views.Forms.Maintenance.Employment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Employee.Employment
{
    public partial class emp_AddEmployment : Form, IEmploymentTypeView, IEmployeeEmploymentView
    {
        private readonly employmenttype_Presenter employmenttype_Presenter;
        private readonly employeeemploymentstatus_Presenter employeeemploymentstatus_Presenter;
        private readonly HrisContext _context;
        private int EmpID;
        public int EmploymentID;
        public bool isUpdate;
        public emp_AddEmployment(int PKEmployeeID)
        {
            InitializeComponent();
            employmenttype_Presenter = new employmenttype_Presenter(this);
            employeeemploymentstatus_Presenter = new employeeemploymentstatus_Presenter(this);
            employmenttype_Presenter.LoadEmployment();
            _context = new HrisContext();
            EmpID = PKEmployeeID;

        }
        public void putdata(int PKEmploymentID)
        {
            if (isUpdate)
            {
                btn_cancel.Select();
                employeeemploymentstatus_Presenter.LoadEmployeeEmploymentStatus(PKEmploymentID);
                EmploymentID = PKEmploymentID;
            }
            else
            {
                btn_cancel.Select();
                employeeemploymentstatus_Presenter.LoadEmployeeEmploymentStatus(PKEmploymentID);
                //disable control
                foreach (Control control in this.Controls)
                {
                    if (control.Name == "txt_remarks")
                    {
                        TextBox txtBox = control as TextBox;
                        if (txtBox != null)
                        {
                            txtBox.ReadOnly = true;
                        }
                    }
                    else
                    {
                        if (!(control is Label) && !(control is Button))
                        {
                            control.Enabled = false;
                        }
                    }
                }

                btn_save.Visible = false;
            }
        }
        private void save()
        {
            if (UniversalStatic.IsEmpty(txt_remarks)) return;
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Models.Employmentstatus
            {
                FkEmployee = EmpID,
                FkEmploymenttype = Convert.ToInt32(txt_employmenttype.SelectedValue),
                Startdate = txt_startdate.Value,
                Enddate = txt_enddate.Value,
                Remarks = txt_remarks.Text,
                Createdby = createdby,
                FkSystemUser = id
            };
            employeeemploymentstatus_Presenter.AddEmploymentStatus(cv);
            this.Close();
        }
        private void update()
        {
            //check
            bool isEnddate = false;
            DateTime? enddate;
            var existingEmployment = _context.Employmentstatuses.Find(EmploymentID);
            if (existingEmployment != null)
            {
                existingEmployment.FkEmployee = EmpID;
                existingEmployment.FkEmploymenttype = Convert.ToInt32(txt_employmenttype.SelectedValue);
                existingEmployment.Startdate = txt_startdate.Value;
                existingEmployment.Enddate = txt_enddate.Value;
                existingEmployment.Remarks = txt_remarks.Text;
                enddate = txt_enddate.Value;


                DateTime? endDateValue = null; // Initialize as null

                if (enddate.HasValue)
                {
                    endDateValue = enddate.Value; 
                }

                if (txt_enddate.Value != null && txt_enddate.Value <= DateTime.Now)
                {
                    isEnddate = true;
                    if (enddate.HasValue)
                    {
                        endDateValue = enddate.Value;
                    }
                }

                employeeemploymentstatus_Presenter.UpdateEmploymentStatus(existingEmployment, isEnddate, endDateValue);
                this.Close();
            }

        }
        public void DisplayEmployment(List<Employmenttype> employments)
        {
            txt_employmenttype.DataSource = employments;
            txt_employmenttype.ValueMember = "PKEmploymenttype";
            txt_employmenttype.DisplayMember = "Description";
        }

        public void DisplayEmployeeEmploymentCustom(List<object> employment)
        {
            //throw new NotImplementedException();
        }

        public void DisplayEmployeeEmploymentAll(List<Employmentstatus> employmentstatuses)
        {
            try
            {
                Models.Employmentstatus employ = employmentstatuses[0];
                txt_employmenttype.SelectedValue = employ.FkEmploymenttype;
                txt_startdate.Value = employ.Startdate;
                txt_enddate.Value = employ.Enddate;
                txt_remarks.Text = employ.Remarks;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_enddate_Click(object sender, EventArgs e)
        {

        }

        public void DsiplayEmploymentCustom(List<object> Employmentlist)
        {
            //throw new NotImplementedException();
        }
    }
}
