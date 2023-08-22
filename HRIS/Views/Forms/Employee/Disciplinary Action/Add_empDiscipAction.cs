using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRIS.Forms.Employee.Disciplinary_Action;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.AddressFolder.TownCityFolder;

namespace HRIS.Views.Forms.Employee.Disciplinary_Action
{
    public partial class Add_empDiscipAction : Form, IEmployeeDisciplinaryActionView
    {
        private readonly EmployeeDisciplinary_presenter empDA_presenter;
        private readonly disciplinarytype_Presenter discType_presenter;
        private readonly offencetype_Presenter offenseType_presenter;

        private emp_DisciplinaryActionForm add_DisciplinaryActionForm;

        private Models.Disciplinarytype selectedDisciplinaryType;
        private Models.Offensetype selectedOffenseType;
        public bool isupdate = false;
        public Add_empDiscipAction()
        {
            InitializeComponent();
            this.add_DisciplinaryActionForm = new emp_DisciplinaryActionForm();
            this.empDA_presenter = new EmployeeDisciplinary_presenter(this);
            //this.discType_presenter = new disciplinarytype_Presenter(this);

            this.selectedDisciplinaryType = new Disciplinarytype();
            this.selectedOffenseType = new Offensetype();
            //province_Presenter.loadProvince();

        }

        public void ClearFields()
        {
            
        }

        public void DisplayEmployeeDscAct(List<Employeedisciplinary> employeedisciplinaries)
        {
            
        }
    }
}
