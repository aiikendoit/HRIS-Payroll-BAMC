using HRIS.Class;
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/Forms/Employee/Work Assignment/emp_workassignment.cs
using HRIS.Views.Employee.Work_Assignment;
=======
=======
>>>>>>> main
using HRIS.Forms.Employee.Work_Assignment;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee.Work_Assignment;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> 615004df363606e89cc8c7813c61629b7015ea3f:HRIS/HRIS/HRIS/Views/Forms/Employee/Work Assignment/emp_workassignment.cs
=======
<<<<<<< HEAD
=======
using Microsoft.EntityFrameworkCore;
>>>>>>> 67147bbd4f97bf4ca6707b247f35dc2e02b627b5
>>>>>>> may7-james
=======
>>>>>>> main
=======
using Microsoft.EntityFrameworkCore;
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Employee
{
<<<<<<< HEAD
<<<<<<< HEAD
    public partial class emp_workassignment : Form,IWorkAssigmentView
    {
        private readonly workassignment_Presenter workassignment_Presenter;
        private string emp_id;
=======
    public partial class emp_workassignment : Form, IWorkAssigmentView
    {
        private readonly workassignment_Presenter workassignment_Presenter;
        private string emp_id;

>>>>>>> 67147bbd4f97bf4ca6707b247f35dc2e02b627b5
=======
    public partial class emp_workassignment : Form, IWorkAssigmentView
    {
        private readonly workassignment_Presenter workassignment_Presenter;
        private string emp_id;

>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
        public emp_workassignment(string employeeid)
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_workassignment);
            workassignment_Presenter = new workassignment_Presenter(this);
<<<<<<< HEAD
<<<<<<< HEAD
            workassignment_Presenter.loadWorkAssignment();
=======
            loadWorkAssignment(Convert.ToInt32(employeeid));
>>>>>>> 67147bbd4f97bf4ca6707b247f35dc2e02b627b5
=======
            loadWorkAssignment(Convert.ToInt32(employeeid));
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
            emp_id = employeeid;
        }

        public void DisplayWorkAssignment(List<Workassignment> workassignments)
        {
<<<<<<< HEAD
<<<<<<< HEAD
           dgrid_workassignment.DataSource = workassignments;
=======
=======
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
            dgrid_workassignment.DataSource = workassignments;
        }

        private void loadWorkAssignment(int employeeid)
        {
            workassignment_Presenter.loadWorkAssignment(employeeid, dgrid_workassignment);
<<<<<<< HEAD
>>>>>>> 67147bbd4f97bf4ca6707b247f35dc2e02b627b5
=======
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
        }

        private void emp_workassignment_Load(object sender, EventArgs e)
        {

        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            emp_AddworkAssignment emp_AddworkAssignment = new emp_AddworkAssignment(emp_id);
            emp_AddworkAssignment.ShowDialog();
            loadWorkAssignment(Convert.ToInt32(emp_id));
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
            
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
            int workassid = (int)dgrid_workassignment.SelectedRows[0].Cells[0].Value;
            emp_AddworkAssignment emp_AddworkAssignment = new emp_AddworkAssignment(emp_id);
            emp_AddworkAssignment.putdata(workassid);
            emp_AddworkAssignment.ShowDialog();
            loadWorkAssignment(Convert.ToInt32(emp_id));
        }
    }
}
