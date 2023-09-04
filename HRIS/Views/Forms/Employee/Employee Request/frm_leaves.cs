using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee.Leaves;
using HRIS.Views.Forms.Maintenance.Leaves;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Views.Forms.Employee.Employee_Request
{
    public partial class frm_leaves : Form, IEmployeeLeaveSettingView, ILeaveTypeView
    {
        private readonly employee_leavesetting_Presenter employee_Leavesetting_Presenter;
        private readonly leavetype_Presenter leavetype_Presenter;
        public frm_leaves()
        {
            InitializeComponent();
            employee_Leavesetting_Presenter = new employee_leavesetting_Presenter(this);
            leavetype_Presenter = new leavetype_Presenter(this);
           loaddetails();
            txt_datefrom.MinDate = DateTime.Now;
            txt_dateto.MinDate = DateTime.Now;
        }

        public void DisplayLeavesetting(List<Leavessetting> leavessettings)
        {

            Models.Leavessetting ls = leavessettings[0];
            txt_leavecredits.Text = ls.Totaldays.ToString();


        }

        public void DisplayLeavesettingCustom(List<object> leavessettings)
        {
        }

        public void DisplayLeavetype(List<Leavetype> leavetypeList)
        {
            // if (leavetypeList != null)
            //{
            txt_leavetype.DataSource = leavetypeList;
            txt_leavetype.ValueMember = "PkLeavetype";
            txt_leavetype.DisplayMember = "Description";
            // }

        }

        private void loaddetails()
        {
            string? completename = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.pkemployeeno;
            string employeeid = Properties.Settings.Default.employeeidno;
            txt_name.Text = completename;
            leavetype_Presenter.LoadLeavetype_forrequest(id);
            if (txt_leavetype.SelectedValue != null)
            {
                int leavetypeid = (int)txt_leavetype.SelectedValue;
                employee_Leavesetting_Presenter.LoadLeavesetting_forLeaveFiling(id, leavetypeid);
            }


        }

        private void txt_leavetype_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Properties.Settings.Default.usercode;
            //var leavetypeid = txt_leavetype.SelectedValue;
            if (int.TryParse(txt_leavetype.SelectedValue.ToString(), out int leavetypeid))
            {
                // Conversion successful, leavetypeid now holds the integer value.
                employee_Leavesetting_Presenter.LoadLeavesetting_forLeaveFiling(id, Convert.ToInt32(leavetypeid));
            }


        }
        private void check30daysNotice()
        {
            DateTime detnow = DateTime.Now;
            DateTime detfrom = txt_datefrom.Value;

            TimeSpan difference = detfrom - detnow;
            TimeSpan thirtyDays = TimeSpan.FromDays(30);

            txt_totaldays.Text = difference.ToString();
            if (difference >= thirtyDays)
            {

            }
            else
            {
                MessageBox.Show("File date is less than 30 days. \nPlease proceed provide Letter of Intent", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

            check30daysNotice();
        }

        private void txt_datefrom_ValueChanged(object sender, EventArgs e)
        {
            check30daysNotice();
        }
    }
}
