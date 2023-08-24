using FontAwesome.Sharp;
using HRIS.Class;
using HRIS.Forms.Doctors;
using HRIS.Forms.Employee;
using HRIS.Forms.Hiring;
using HRIS.Forms.Maintenance;
using HRIS.Forms.Userlogin;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Employee.Employee_Request;
using HRIS.Views.Forms.Userlogin;
using System.Net.Security;
using System.Runtime.InteropServices;

namespace HRIS
{
    public partial class MainForm : Form, ISysemUsers
    {

        private IconButton currentbtn;
        private Form currentchildform;
        private readonly userlogin_Presenter userlogin_Presenter;
        public MainForm()
        {
            InitializeComponent();
            userlogin_Presenter = new userlogin_Presenter(this);
            currentbtn = new IconButton();
            currentchildform = new Form();
            profile();

        }
        private void profile()
        {
            string? completename = Properties.Settings.Default.completename;
            string employeeid = Properties.Settings.Default.employeeidno;
            userlogin_Presenter.loadlogin(employeeid);
            label_completename.Text = completename;
            label1_idno.Text = employeeid;
            
            

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
            openchildform(new DoctorForm());
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
            MaintenanceForm maintenanceForm = new MaintenanceForm();
            maintenanceForm.ShowDialog();
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

        private void btn_employeerequest_Click(object sender, EventArgs e)
        {
            activatebutton(sender, ColorPalette.color5);
            openchildform(new EmployeeRequestForm());
        }

        public void DisplaySystemUsers(List<SystemUser> SystemUsers)
        {
           // throw new NotImplementedException();
        }

        public void DisplayUserCustom(List<object> systemuser)
        {
            foreach (var obj in systemuser)
            {
                var profilePictureProperty = obj.GetType().GetProperty("profilepicture");

                if (profilePictureProperty != null)
                {
                    var profilePictureValue = profilePictureProperty.GetValue(obj);

                    if (profilePictureValue is byte[] profilePicture)
                    {
                        using (MemoryStream memoryStream = new MemoryStream(profilePicture))
                        {
                            picturebox_profilepicture.Image = Image.FromStream(memoryStream);
                        }
                    }
                }
            }
        }
    }
}