using FontAwesome.Sharp;
using HRIS.Class;
<<<<<<< HEAD
using HRIS.Forms.Employee.Disciplinary_Action;
=======
using HRIS.Forms.Employee.Benefits;
using HRIS.Forms.Employee.Disciplinary_Action;
using HRIS.Forms.Employee.Documents;
>>>>>>> may7-james
using HRIS.Forms.Employee.Employment;
using HRIS.Forms.Employee.Family_and_Dependents;
using HRIS.Forms.Employee.Leaves;
using HRIS.Forms.Employee.License_information;
using HRIS.Forms.Employee.Salary_Setting;
using HRIS.Forms.Employee.Seminars;
using HRIS.Forms.Employee.Training;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace HRIS.Forms.Employee
{

    public partial class EmployeeRegistration : Form
    {
        Boolean sidebarclick = false;
        private Form currentchildform;
        private IconButton currentbtn;
<<<<<<< HEAD
        public EmployeeRegistration()
        {
            InitializeComponent();
=======
        String headername;
        public EmployeeRegistration(string headername)
        {
            InitializeComponent();



>>>>>>> may7-james
            currentbtn = new IconButton();
            currentchildform = new Form();
            btn_basicinformation.ForeColor = ColorPalette.color5;
            btn_basicinformation.IconColor = ColorPalette.color5;
<<<<<<< HEAD
=======
            this.headername = headername;
            label_Headername.Text = headername;
>>>>>>> may7-james
        }

        private void EmployeeRegistration_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            //Init data
            List<Province> list = new List<Province>();
            list.Add(new City() { ID = 1, Name = "New York" });
            list.Add(new City() { ID = 2, Name = "Los Angeles" });
            list.Add(new City() { ID = 3, Name = "Chicago" });
            list.Add(new City() { ID = 4, Name = "Houston" });
            list.Add(new City() { ID = 5, Name = "Philadelphia" });
            cboCity.DataSource = list;
            cboCity.ValueMember = "ID";
            cboCity.DisplayMember = "Name";
=======
>>>>>>> may7-james
        }

        #region "Procedure"
        private void collapsemenu()
        {
            if (panelmenu.Width == 160)
            {
                //setting the width of a panel to 60
                int width = 160;
                while (width >= 70)
                {
                    width -= 10;
                    panelmenu.Width = width;
                }

                //looping through each button to make text to null
                foreach (Button menubutton in panelmenu.Controls)
                {
                    menubutton.Text = "";
                    menubutton.ImageAlign = ContentAlignment.MiddleLeft;
                    menubutton.Padding = new Padding(10, 0, 0, 0);
                }

                sidebarclick = true;
            }
            else
            {

                panelmenu.Width = 160;

                //looping through each button to make text to null
                foreach (Button menubutton in panelmenu.Controls)
                {
                    menubutton.Text = menubutton.Tag.ToString();
                    menubutton.ImageAlign = ContentAlignment.MiddleLeft;
                    menubutton.Padding = new Padding(10, 0, 0, 0);
                }
                sidebarclick = false;
            }
        }
        private void mousehover()
        {
            if (panelmenu.Width < 160)
            {
                panelmenu.Width = 160;
                //looping through each button to make text to null
                foreach (Button menubutton in panelmenu.Controls)
                {
                    menubutton.Text = menubutton.Tag.ToString();
                    menubutton.ImageAlign = ContentAlignment.MiddleLeft;
                    menubutton.Padding = new Padding(10, 0, 0, 0);
                }
            }

        }
        private void mouseleave()
        {
            panelmenu.Width = 60;
            //looping through each button to make text to null
            foreach (Button menubutton in panelmenu.Controls)
            {
                menubutton.Text = "";
                menubutton.ImageAlign = ContentAlignment.MiddleLeft;
                menubutton.Padding = new Padding(10, 0, 0, 0);
            }
        }
        private void openchildform(Form childform)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();
            }
            currentchildform = childform;
            currentchildform.TopLevel = false;
            currentchildform.FormBorderStyle = FormBorderStyle.None;
            currentchildform.Dock = DockStyle.Fill;
            currentchildform.Size = new Size(MainPanel.Width, MainPanel.Height);
            MainPanel.Controls.Add(currentchildform);
            MainPanel.BringToFront();
            childform.BringToFront();
            childform.Show();

        }
        private void activatebutton(Object senderbtn, Color customcolor)
        {
            disablebutton();
            currentbtn = (IconButton)senderbtn;
            currentbtn.BackColor = Color.FromArgb(0, 127, 152);
            currentbtn.ForeColor = customcolor;
            currentbtn.IconColor = customcolor;
        }
        private void disablebutton()
        {
            if (currentbtn != null)
            {
                currentbtn.ForeColor = Color.White;
                currentbtn.IconColor = Color.White;
                btn_basicinformation.ForeColor = Color.White;
                btn_basicinformation.IconColor = Color.White;
            }

        }
        private void reset()
        {
            disablebutton();
            panel_basicinfo.BringToFront();
        }
        #endregion


        private void btn_sidebardrawer_Click(object sender, EventArgs e)
        {
            collapsemenu();
        }

        private void _MouseHover_(object sender, EventArgs e)
        {
            mousehover();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();
            }
            reset();
            activatebutton(sender, ColorPalette.color5);

        }

        private void btn_education_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_EducationalAttainment());
        }

        private void btn_shifting_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_shifting());
        }

        private void btn_workassignment_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_workassignment());
        }
        private void btn_basicinfo_Click(object sender, EventArgs e)
        {
            reset();
            activatebutton(sender, ColorPalette.color5);
        }


        private void _Activatebutton(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_licenseInfoForm());
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_employmentForm());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_leaveSetting());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_leaveRecordsForm());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_FamilyDependentsForm());
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_SeminarForm());
        }

        private void _training_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_TrainingForm());
        }

        private void _salarysetting_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_SalarySetting());
        }

        private void _DisciplinaryAction_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_DisciplinaryActionForm());
        }
<<<<<<< HEAD
=======

        private void _benefits_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_Benefits());
        }

        private void _documents_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new emp_DocumentsForm());
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
>>>>>>> may7-james
    }
}
