﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using HRIS.Forms.Employee.Disciplinary_Action;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.AddressFolder.TownCityFolder;
using HRIS.Views.Forms.Maintenance.Disciplinary;
using HRIS.Views.Forms.Maintenance.Offensetype;
using Microsoft.EntityFrameworkCore;

namespace HRIS.Views.Forms.Employee.Disciplinary_Action
{
    public partial class Add_empDiscipAction : Form, IEmployeeDisciplinaryActionView, IDisciplinaryView, IOffenceTypeView
    {
        public int PKEmployee;
        private readonly EmployeeDisciplinary_presenter empDA_presenter;
        private readonly disciplinarytype_Presenter discType_presenter;
        private readonly offencetype_Presenter offenseType_presenter;

        private emp_DisciplinaryActionForm add_DisciplinaryActionForm;
        private readonly HrisContext _context;
        private Models.Disciplinarytype selectedDisciplinaryType;
        private Models.Offensetype selectedOffenseType;
        public bool isUpdate = false;//update button control
        private string selectedFilePath;//attached file
        public Add_empDiscipAction(int EmpID)
        {
            InitializeComponent();
            empDA_presenter = new EmployeeDisciplinary_presenter(this);
            discType_presenter = new disciplinarytype_Presenter(this);
            offenseType_presenter = new offencetype_Presenter(this);

            _context = new HrisContext();
            PKEmployee = EmpID;

            discType_presenter.LoadDisciplinary();//load combobox disciplinary type
            offenseType_presenter.LoadOffensetype();//load combobox offense type

        }

        public void ClearFields()
        {

        }

        public void DisplayEmployeeDscAct_All(List<Employeedisciplinary> employeedisciplinaries)
        {

        }

        public void displayEmployeeDscAct_ListObject(List<object> employeedisciplinaries)
        {

        }

        public void DisplayDisciplinaryType(List<Disciplinarytype> disciplinaries)
        {

            comboBox_discplnryType.DataSource = disciplinaries;
            comboBox_discplnryType.ValueMember = "PkDisciplinarytype";
            comboBox_discplnryType.DisplayMember = "Disciplinarydescription";
        }

        public void DisplayDisciplinaryType_ListObject(List<object> disciplinaries)
        {

        }

        public void DisplayOffencetype(List<Offensetype> offensetypes)
        {
            comboBox_offenseType.DataSource = offensetypes;
            comboBox_offenseType.ValueMember = "PkOffensetype";
            comboBox_offenseType.DisplayMember = "Description";
        }

        private void button_attach_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tif;*.tiff;*.pdf)|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tif;*.tiff;*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                label_filePath.Text = selectedFilePath;
            }
        }
    }
}
