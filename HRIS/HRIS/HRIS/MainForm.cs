using FontAwesome.Sharp;
using HRIS.Class;
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
=======
>>>>>>> d26903d7ac5009b91ce31b58de57948fdef89f60
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
<<<<<<< HEAD
=======
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
<<<<<<< HEAD
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
>>>>>>> 07483abc6b46d58c9a5bcab93c34fbae724965f0
>>>>>>> d26903d7ac5009b91ce31b58de57948fdef89f60
using HRIS.Forms.Doctors;
using HRIS.Forms.Employee;
using HRIS.Forms.Hiring;
using HRIS.Forms.Maintenance;
using HRIS.Forms.Userlogin;
using System.Net.Security;
using System.Runtime.InteropServices;
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
=======
<<<<<<< HEAD
>>>>>>> d26903d7ac5009b91ce31b58de57948fdef89f60
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
=======
using HRIS.Forms.Employee;
using HRIS.Forms.Userlogin;
using System.Net.Security;
>>>>>>> backup files
=======
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
<<<<<<< HEAD
using HRIS.Forms.Employee;
using HRIS.Forms.Userlogin;
using System.Net.Security;
>>>>>>> backup files
=======
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
using HRIS.Forms.Employee;
using HRIS.Forms.Userlogin;
using System.Net.Security;
>>>>>>> backup files
=======
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
>>>>>>> 07483abc6b46d58c9a5bcab93c34fbae724965f0
>>>>>>> d26903d7ac5009b91ce31b58de57948fdef89f60

namespace HRIS
{
    public partial class MainForm : Form
    {

        private IconButton currentbtn;
        private Form currentchildform;
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
=======
>>>>>>> d26903d7ac5009b91ce31b58de57948fdef89f60
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
<<<<<<< HEAD
        
=======

>>>>>>> backup files
=======
        
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
<<<<<<< HEAD

>>>>>>> backup files
=======
        
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======

>>>>>>> backup files
=======
        
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
        
>>>>>>> 07483abc6b46d58c9a5bcab93c34fbae724965f0
>>>>>>> d26903d7ac5009b91ce31b58de57948fdef89f60
        public MainForm()
        {
            InitializeComponent();
            currentbtn = new IconButton();
            currentchildform = new Form();
        }
        private void activatebutton(Object senderbtn, Color customcolor)
        {
            disablebutton();
            currentbtn = (IconButton)senderbtn;
            currentbtn.BackColor = Color.FromArgb(0, 127, 152);
            currentbtn.ForeColor = customcolor;
            currentbtn.IconColor = customcolor;
            //change form title name
            lbl_formtitle.Text = currentbtn.Tag as string;
            //change form icon
            icon_home.IconChar = currentbtn.IconChar;
            icon_home.IconColor = customcolor;
        }
        private void disablebutton()
        {
            if (currentbtn != null)
            {
                currentbtn.ForeColor = Color.White;
                currentbtn.IconColor = Color.White;
            }

        }
        private void openchildform(Form childform)
        {
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
=======
>>>>>>> d26903d7ac5009b91ce31b58de57948fdef89f60
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
<<<<<<< HEAD
            if (currentchildform != null)
=======
        if (currentchildform != null)
>>>>>>> backup files
=======
            if (currentchildform != null)
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
<<<<<<< HEAD
        if (currentchildform != null)
>>>>>>> backup files
=======
            if (currentchildform != null)
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
        if (currentchildform != null)
>>>>>>> backup files
=======
            if (currentchildform != null)
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
            if (currentchildform != null)
>>>>>>> 07483abc6b46d58c9a5bcab93c34fbae724965f0
>>>>>>> d26903d7ac5009b91ce31b58de57948fdef89f60
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
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
=======
>>>>>>> d26903d7ac5009b91ce31b58de57948fdef89f60
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
<<<<<<< HEAD

=======
        
>>>>>>> backup files
=======

>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
<<<<<<< HEAD
        
>>>>>>> backup files
=======

>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
        
>>>>>>> backup files
=======

>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======

>>>>>>> 07483abc6b46d58c9a5bcab93c34fbae724965f0
>>>>>>> d26903d7ac5009b91ce31b58de57948fdef89f60

        private void Image_Logo_Click(object sender, EventArgs e)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();
            }
            reset();
        }
        private void reset()
        {
            disablebutton();
            icon_home.IconChar = IconChar.Home;
            icon_home.IconColor = Color.White;
            lbl_formtitle.Text = "Home";
            HomePanel.BringToFront();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            Userlogin userlogin = new Userlogin();
            userlogin.Show();
        }

        private void btn_dashboard_Click_1(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new EmployeeForm());
        }

        private void btn_doctors_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
=======
>>>>>>> d26903d7ac5009b91ce31b58de57948fdef89f60
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
<<<<<<< HEAD
            openchildform(new DoctorForm());
=======
>>>>>>> backup files
=======
            openchildform(new DoctorForm());
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
<<<<<<< HEAD
>>>>>>> backup files
=======
            openchildform(new DoctorForm());
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
>>>>>>> backup files
=======
            openchildform(new DoctorForm());
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
            openchildform(new DoctorForm());
>>>>>>> 07483abc6b46d58c9a5bcab93c34fbae724965f0
>>>>>>> d26903d7ac5009b91ce31b58de57948fdef89f60
        }

        private void btn_dutyschedule_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
        }

        private void btn_leaves_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
        }

        private void btn_maintenance_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
=======
>>>>>>> d26903d7ac5009b91ce31b58de57948fdef89f60
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
<<<<<<< HEAD
            MaintenanceForm maintenanceForm = new MaintenanceForm();
            maintenanceForm.ShowDialog();
=======
>>>>>>> backup files
=======
            MaintenanceForm maintenanceForm = new MaintenanceForm();
            maintenanceForm.ShowDialog();
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
<<<<<<< HEAD
>>>>>>> backup files
=======
            MaintenanceForm maintenanceForm = new MaintenanceForm();
            maintenanceForm.ShowDialog();
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
>>>>>>> backup files
=======
            MaintenanceForm maintenanceForm = new MaintenanceForm();
            maintenanceForm.ShowDialog();
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
            MaintenanceForm maintenanceForm = new MaintenanceForm();
            maintenanceForm.ShowDialog();
>>>>>>> 07483abc6b46d58c9a5bcab93c34fbae724965f0
>>>>>>> d26903d7ac5009b91ce31b58de57948fdef89f60
        }

        private void btn_reportmanager_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
        }

        private void btn_audittrail_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
=======
>>>>>>> d26903d7ac5009b91ce31b58de57948fdef89f60
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
<<<<<<< HEAD
=======
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
<<<<<<< HEAD
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
>>>>>>> 07483abc6b46d58c9a5bcab93c34fbae724965f0
>>>>>>> d26903d7ac5009b91ce31b58de57948fdef89f60

        private void btn_seminar_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
        }

        private void btn_training_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
        }

        private void btn_attendance_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
        }

        private void btn_hiring_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new HiringForm());
        }
<<<<<<< HEAD
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
=======
<<<<<<< HEAD
>>>>>>> d26903d7ac5009b91ce31b58de57948fdef89f60
<<<<<<< HEAD:HRIS/HRIS/HRIS/MainForm.cs
=======
>>>>>>> backup files
=======
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
<<<<<<< HEAD
>>>>>>> backup files
=======
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
>>>>>>> backup files
=======
>>>>>>> update files:HRIS/HRIS/HRIS/HRIS/HRIS/MainForm.cs
=======
>>>>>>> 07483abc6b46d58c9a5bcab93c34fbae724965f0
>>>>>>> d26903d7ac5009b91ce31b58de57948fdef89f60
    }
}