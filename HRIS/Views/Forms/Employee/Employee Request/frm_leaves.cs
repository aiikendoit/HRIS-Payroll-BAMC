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
    public partial class frm_leaves : Form,IEmployeeLeaveSettingView
    {
        private readonly employee_leavesetting_Presenter employee_Leavesetting_Presenter;
        public frm_leaves()
        {
            InitializeComponent();
            employee_Leavesetting_Presenter = new employee_leavesetting_Presenter(this);
            loaddetails();
        }

        public void DisplayLeavesetting(List<Leavessetting> leavessettings)
        {
            //txt_leavetype.DataSource = leavessettings;
            //txt_leavetype.ValueMember = "FKLeavetype";
            //txt_leavetype.DisplayMember = "Leavetype";
        }

        public void DisplayLeavesettingCustom(List<object> leavessettings)
        {
            //txt_leavetype.DataSource = leavessettings;
            //txt_leavetype.ValueMember = "PKLeavetype";
            //txt_leavetype.DisplayMember = "Leavetype";
            //foreach (var obj in leavessettings)
            //{
            //    var dayscredit = obj.GetType().GetProperty("daysperyear");
            //}
        }
        private void loaddetails()
        {
            string? completename = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            string employeeid = Properties.Settings.Default.employeeidno;
            txt_name.Text = completename;
            employee_Leavesetting_Presenter.LoadLeavesetting_forLeaveFiling(id);
        }
    }
}
