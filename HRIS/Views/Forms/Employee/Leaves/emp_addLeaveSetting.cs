using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee.Leaves;
using HRIS.Views.Forms.Maintenance.Leaves;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HRIS.Forms.Employee.Leaves
{
    public partial class emp_addLeaveSetting : Form, ILeaveTypeView, IEmployeeLeaveSettingView
    {
        private readonly leavetype_Presenter leavetype_Presenter;
        private HrisContext _context;
        private readonly employee_leavesetting_Presenter employee_Leavesetting_Presenter;
        public bool isUpdate = false;
        private int empID = 0;
        private int PKleavesettingID = 0;
        public emp_addLeaveSetting(int EmployeeID)
        {
            InitializeComponent();
            leavetype_Presenter = new leavetype_Presenter(this);
            employee_Leavesetting_Presenter = new employee_leavesetting_Presenter(this);
            _context = new HrisContext();
            leavetype_Presenter.LoadLeaveType();
            txt_daysperyear.Text = "0"; // Set default value
            txt_daysperyear.Enter += txt_daysperyear_Enter;
            txt_daysperyear.TextChanged += txt_daysperyear_TextChanged;
            empID = EmployeeID;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Suppress the input if it's not a digit or control character
            }
        }

        private void txt_daysperyear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.V))
            {
                // Disable Ctrl+V (paste) by not calling the base method
                e.Handled = true;
            }
            else
            {
                base.OnKeyDown(e);
            }
        }

        private void txt_daysperyear_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "0")
            {
                textBox.Text = "";
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_daysperyear_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text == "0")
            {
                textBox.Select(0, 0); // Move cursor to the start
            }
            else
            {
                textBox.SelectionStart = textBox.Text.Length; // Move cursor to the end
            }
        }

        public void DisplayLeavetype(List<Leavetype> leavetypeList)
        {
            txt_leavetype.DataSource = leavetypeList;
            txt_leavetype.ValueMember = "PkLeavetype";
            txt_leavetype.DisplayMember = "Description";
        }
        public void putdata(int PKLeavesetting)
        {
            if (isUpdate)
            {
                btn_cancel.Select();
                employee_Leavesetting_Presenter.LoadLeavesetting(PKLeavesetting);
                PKleavesettingID = PKLeavesetting;
            }
            else
            {
                btn_cancel.Select();
                employee_Leavesetting_Presenter.LoadLeavesetting(PKLeavesetting);
                //disable control
                foreach (Control control in this.Controls)
                {
                    if (!(control is Label) && !(control is Button))
                    {
                        control.Enabled = false;
                    }
                }
                btn_save.Visible = false;
            }
        }
        private void save()
        {
            if (UniversalStatic.IsEmpty(txt_remarks)) return;
            if (UniversalStatic.IsEmpty(txt_daysperyear)) return;
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Models.Leavessetting
            {
                FkEmployee = empID,
                FkLeavetype = Convert.ToInt32(txt_leavetype.SelectedValue),
                Totaldays = Convert.ToInt32(txt_daysperyear.Text),
                Effectivitydate = txt_effectivitydate.Value,
                Remarks = txt_remarks.Text,
                Createdby = createdby,
                FkSystemUser = id
            };
            employee_Leavesetting_Presenter.AddLeaveSetting(cv);
            this.Close();
        }

        public void DisplayLeavesetting(List<Leavessetting> leavessettings)
        {
            try
            {
                Models.Leavessetting lsetting = leavessettings[0];
                txt_leavetype.SelectedValue = lsetting.FkLeavetype;
                txt_daysperyear.Text = lsetting.Totaldays.ToString();
                txt_effectivitydate.Value = lsetting.Effectivitydate;
                txt_remarks.Text = lsetting.Remarks;
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

        public void DisplayLeavesettingCustom(List<object> leavessettings)
        {
            throw new NotImplementedException();
        }
        private void update()
        {
            var existingLeavesetting = _context.Leavessettings.Find(PKleavesettingID);
            if (existingLeavesetting != null)
            {
                existingLeavesetting.FkEmployee = empID;
                existingLeavesetting.FkLeavetype = Convert.ToInt32(txt_leavetype.SelectedValue);
                existingLeavesetting.Totaldays = Convert.ToInt32(txt_daysperyear.Text);
                existingLeavesetting.Effectivitydate = txt_effectivitydate.Value;
                existingLeavesetting.Remarks = txt_remarks.Text;
                employee_Leavesetting_Presenter.UpdateLeavesetting(existingLeavesetting);
                this.Close();
            }

        }
    }
}
