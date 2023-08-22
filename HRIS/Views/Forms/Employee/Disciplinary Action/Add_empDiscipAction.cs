using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRIS.Models;

namespace HRIS.Views.Forms.Employee.Disciplinary_Action
{
    public partial class Add_empDiscipAction : Form, IEmployeeDisciplinaryActionView
    {
        public Add_empDiscipAction()
        {
            InitializeComponent();
        }

        public void ClearFields()
        {
            
        }

        public void DisplayEmployeeDscAct(List<Employeedisciplinary> employeedisciplinaries)
        {
            
        }
    }
}
