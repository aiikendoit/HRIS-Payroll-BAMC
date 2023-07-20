using HRIS.Class;
<<<<<<< HEAD:HRIS/HRIS/HRIS/Forms/Employee/Work Assignment/emp_workassignment.cs
using HRIS.Views.Employee.Work_Assignment;
=======
using HRIS.Forms.Employee.Work_Assignment;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee.Work_Assignment;
>>>>>>> 615004df363606e89cc8c7813c61629b7015ea3f:HRIS/HRIS/HRIS/Views/Forms/Employee/Work Assignment/emp_workassignment.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Views.Employee
{
    public partial class emp_workassignment : Form,IWorkAssigmentView
    {
        private readonly workassignment_Presenter workassignment_Presenter;
        private string emp_id;
        public emp_workassignment(string employeeid)
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_workassignment);
            workassignment_Presenter = new workassignment_Presenter(this);
            workassignment_Presenter.loadWorkAssignment();
            emp_id = employeeid;
        }

        public void DisplayWorkAssignment(List<Workassignment> workassignments)
        {
           dgrid_workassignment.DataSource = workassignments;
        }

        private void emp_workassignment_Load(object sender, EventArgs e)
        {

        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            emp_AddworkAssignment emp_AddworkAssignment = new emp_AddworkAssignment(emp_id);
            emp_AddworkAssignment.ShowDialog();
        }
    }
}
