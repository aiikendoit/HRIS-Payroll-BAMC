using HRIS.UserControl;

namespace HRIS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelTop = new Panel();
            picturebox_profilepicture = new JPCircularPictureBox();
            label1_idno = new Label();
            label_completename = new Label();
            lbl_formtitle = new Label();
            icon_home = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panelLeft = new Panel();
            panel1 = new Panel();
            btn_audittrail = new FontAwesome.Sharp.IconButton();
            btn_reportmanager = new FontAwesome.Sharp.IconButton();
            btn_maintenance = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            btn_attendance = new FontAwesome.Sharp.IconButton();
            btn_training = new FontAwesome.Sharp.IconButton();
            btn_seminar = new FontAwesome.Sharp.IconButton();
            label15 = new Label();
            btn_employeerequest = new FontAwesome.Sharp.IconButton();
            label16 = new Label();
            btn_leaves = new FontAwesome.Sharp.IconButton();
            btn_dutyschedule = new FontAwesome.Sharp.IconButton();
            btn_doctors = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btn_employee = new FontAwesome.Sharp.IconButton();
            btn_hiring = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            btn_dashboard = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            Image_Logo = new PictureBox();
            HomePanel = new Panel();
            panel2 = new Panel();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            MainPanel = new Panel();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturebox_profilepicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon_home).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panelLeft.SuspendLayout();
            panel1.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Image_Logo).BeginInit();
            HomePanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(0, 127, 152);
            panelTop.Controls.Add(picturebox_profilepicture);
            panelTop.Controls.Add(label1_idno);
            panelTop.Controls.Add(label_completename);
            panelTop.Controls.Add(lbl_formtitle);
            panelTop.Controls.Add(icon_home);
            panelTop.Controls.Add(iconPictureBox1);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(199, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(847, 100);
            panelTop.TabIndex = 0;
            // 
            // picturebox_profilepicture
            // 
            picturebox_profilepicture.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            picturebox_profilepicture.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            picturebox_profilepicture.BorderColor = Color.RoyalBlue;
            picturebox_profilepicture.BorderColor2 = Color.HotPink;
            picturebox_profilepicture.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            picturebox_profilepicture.BorderSize = 2;
            picturebox_profilepicture.GradientAngle = 50F;
            picturebox_profilepicture.Image = (Image)resources.GetObject("picturebox_profilepicture.Image");
            picturebox_profilepicture.Location = new Point(761, 41);
            picturebox_profilepicture.Name = "picturebox_profilepicture";
            picturebox_profilepicture.Size = new Size(54, 54);
            picturebox_profilepicture.SizeMode = PictureBoxSizeMode.StretchImage;
            picturebox_profilepicture.TabIndex = 5;
            picturebox_profilepicture.TabStop = false;
            // 
            // label1_idno
            // 
            label1_idno.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1_idno.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1_idno.Location = new Point(555, 71);
            label1_idno.Name = "label1_idno";
            label1_idno.Size = new Size(202, 17);
            label1_idno.TabIndex = 3;
            label1_idno.Text = "NULL";
            label1_idno.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label_completename
            // 
            label_completename.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label_completename.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_completename.Location = new Point(555, 53);
            label_completename.Name = "label_completename";
            label_completename.Size = new Size(202, 17);
            label_completename.TabIndex = 3;
            label_completename.Text = "NULL";
            label_completename.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_formtitle
            // 
            lbl_formtitle.AutoSize = true;
            lbl_formtitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_formtitle.Location = new Point(44, 72);
            lbl_formtitle.Name = "lbl_formtitle";
            lbl_formtitle.Size = new Size(43, 17);
            lbl_formtitle.TabIndex = 1;
            lbl_formtitle.Text = "Home";
            // 
            // icon_home
            // 
            icon_home.BackColor = Color.FromArgb(0, 127, 152);
            icon_home.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            icon_home.IconColor = Color.White;
            icon_home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icon_home.IconSize = 28;
            icon_home.Location = new Point(6, 66);
            icon_home.Name = "icon_home";
            icon_home.Size = new Size(32, 28);
            icon_home.SizeMode = PictureBoxSizeMode.Zoom;
            icon_home.TabIndex = 0;
            icon_home.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            iconPictureBox1.BackColor = Color.FromArgb(0, 127, 152);
            iconPictureBox1.Cursor = Cursors.Hand;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.EllipsisVertical;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 24;
            iconPictureBox1.Location = new Point(820, 58);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(24, 24);
            iconPictureBox1.TabIndex = 4;
            iconPictureBox1.TabStop = false;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(0, 127, 152);
            panelLeft.Controls.Add(panel1);
            panelLeft.Controls.Add(panelLogo);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(199, 613);
            panelLeft.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_audittrail);
            panel1.Controls.Add(btn_reportmanager);
            panel1.Controls.Add(btn_maintenance);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_attendance);
            panel1.Controls.Add(btn_training);
            panel1.Controls.Add(btn_seminar);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(btn_employeerequest);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(btn_leaves);
            panel1.Controls.Add(btn_dutyschedule);
            panel1.Controls.Add(btn_doctors);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(btn_employee);
            panel1.Controls.Add(btn_hiring);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btn_dashboard);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 513);
            panel1.TabIndex = 18;
            // 
            // btn_audittrail
            // 
            btn_audittrail.BackColor = Color.FromArgb(0, 127, 152);
            btn_audittrail.Cursor = Cursors.Hand;
            btn_audittrail.Dock = DockStyle.Top;
            btn_audittrail.FlatAppearance.BorderSize = 0;
            btn_audittrail.FlatStyle = FlatStyle.Flat;
            btn_audittrail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_audittrail.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            btn_audittrail.IconColor = Color.White;
            btn_audittrail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_audittrail.IconSize = 25;
            btn_audittrail.ImageAlign = ContentAlignment.MiddleLeft;
            btn_audittrail.Location = new Point(0, 563);
            btn_audittrail.Name = "btn_audittrail";
            btn_audittrail.Padding = new Padding(10, 0, 0, 0);
            btn_audittrail.Size = new Size(199, 35);
            btn_audittrail.TabIndex = 26;
            btn_audittrail.Tag = "Audit trail";
            btn_audittrail.Text = "Audit trail";
            btn_audittrail.TextAlign = ContentAlignment.MiddleLeft;
            btn_audittrail.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_audittrail.UseVisualStyleBackColor = false;
            btn_audittrail.Click += btn_audittrail_Click;
            // 
            // btn_reportmanager
            // 
            btn_reportmanager.BackColor = Color.FromArgb(0, 127, 152);
            btn_reportmanager.Cursor = Cursors.Hand;
            btn_reportmanager.Dock = DockStyle.Top;
            btn_reportmanager.FlatAppearance.BorderSize = 0;
            btn_reportmanager.FlatStyle = FlatStyle.Flat;
            btn_reportmanager.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_reportmanager.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            btn_reportmanager.IconColor = Color.White;
            btn_reportmanager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_reportmanager.IconSize = 25;
            btn_reportmanager.ImageAlign = ContentAlignment.MiddleLeft;
            btn_reportmanager.Location = new Point(0, 528);
            btn_reportmanager.Name = "btn_reportmanager";
            btn_reportmanager.Padding = new Padding(10, 0, 0, 0);
            btn_reportmanager.Size = new Size(199, 35);
            btn_reportmanager.TabIndex = 25;
            btn_reportmanager.Tag = "Report Manager";
            btn_reportmanager.Text = "Report Manager";
            btn_reportmanager.TextAlign = ContentAlignment.MiddleLeft;
            btn_reportmanager.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_reportmanager.UseVisualStyleBackColor = false;
            btn_reportmanager.Click += btn_reportmanager_Click;
            // 
            // btn_maintenance
            // 
            btn_maintenance.BackColor = Color.FromArgb(0, 127, 152);
            btn_maintenance.Cursor = Cursors.Hand;
            btn_maintenance.Dock = DockStyle.Top;
            btn_maintenance.FlatAppearance.BorderSize = 0;
            btn_maintenance.FlatStyle = FlatStyle.Flat;
            btn_maintenance.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_maintenance.IconChar = FontAwesome.Sharp.IconChar.Gear;
            btn_maintenance.IconColor = Color.White;
            btn_maintenance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_maintenance.IconSize = 25;
            btn_maintenance.ImageAlign = ContentAlignment.MiddleLeft;
            btn_maintenance.Location = new Point(0, 493);
            btn_maintenance.Name = "btn_maintenance";
            btn_maintenance.Padding = new Padding(10, 0, 0, 0);
            btn_maintenance.Size = new Size(199, 35);
            btn_maintenance.TabIndex = 23;
            btn_maintenance.Tag = "Maintenance";
            btn_maintenance.Text = "Maintenance";
            btn_maintenance.TextAlign = ContentAlignment.MiddleLeft;
            btn_maintenance.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_maintenance.UseVisualStyleBackColor = false;
            btn_maintenance.Click += btn_maintenance_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(86, 180, 206);
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 466);
            label2.Name = "label2";
            label2.Padding = new Padding(5, 0, 0, 0);
            label2.Size = new Size(199, 27);
            label2.TabIndex = 20;
            label2.Text = "OTHERS";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_attendance
            // 
            btn_attendance.BackColor = Color.FromArgb(0, 127, 152);
            btn_attendance.Cursor = Cursors.Hand;
            btn_attendance.Dock = DockStyle.Top;
            btn_attendance.FlatAppearance.BorderSize = 0;
            btn_attendance.FlatStyle = FlatStyle.Flat;
            btn_attendance.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_attendance.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            btn_attendance.IconColor = Color.White;
            btn_attendance.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_attendance.IconSize = 25;
            btn_attendance.ImageAlign = ContentAlignment.MiddleLeft;
            btn_attendance.Location = new Point(0, 431);
            btn_attendance.Name = "btn_attendance";
            btn_attendance.Padding = new Padding(10, 0, 0, 0);
            btn_attendance.Size = new Size(199, 35);
            btn_attendance.TabIndex = 31;
            btn_attendance.Tag = "Attendance";
            btn_attendance.Text = "Attendance";
            btn_attendance.TextAlign = ContentAlignment.MiddleLeft;
            btn_attendance.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_attendance.UseVisualStyleBackColor = false;
            btn_attendance.Click += btn_attendance_Click;
            // 
            // btn_training
            // 
            btn_training.BackColor = Color.FromArgb(0, 127, 152);
            btn_training.Cursor = Cursors.Hand;
            btn_training.Dock = DockStyle.Top;
            btn_training.FlatAppearance.BorderSize = 0;
            btn_training.FlatStyle = FlatStyle.Flat;
            btn_training.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_training.IconChar = FontAwesome.Sharp.IconChar.HandHoldingMedical;
            btn_training.IconColor = Color.White;
            btn_training.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_training.IconSize = 25;
            btn_training.ImageAlign = ContentAlignment.MiddleLeft;
            btn_training.Location = new Point(0, 396);
            btn_training.Name = "btn_training";
            btn_training.Padding = new Padding(10, 0, 0, 0);
            btn_training.Size = new Size(199, 35);
            btn_training.TabIndex = 30;
            btn_training.Tag = "Training";
            btn_training.Text = "Training";
            btn_training.TextAlign = ContentAlignment.MiddleLeft;
            btn_training.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_training.UseVisualStyleBackColor = false;
            btn_training.Click += btn_training_Click;
            // 
            // btn_seminar
            // 
            btn_seminar.BackColor = Color.FromArgb(0, 127, 152);
            btn_seminar.Cursor = Cursors.Hand;
            btn_seminar.Dock = DockStyle.Top;
            btn_seminar.FlatAppearance.BorderSize = 0;
            btn_seminar.FlatStyle = FlatStyle.Flat;
            btn_seminar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_seminar.IconChar = FontAwesome.Sharp.IconChar.PersonChalkboard;
            btn_seminar.IconColor = Color.White;
            btn_seminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_seminar.IconSize = 25;
            btn_seminar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_seminar.Location = new Point(0, 361);
            btn_seminar.Name = "btn_seminar";
            btn_seminar.Padding = new Padding(10, 0, 0, 0);
            btn_seminar.Size = new Size(199, 35);
            btn_seminar.TabIndex = 29;
            btn_seminar.Tag = "Seminar";
            btn_seminar.Text = "Seminar";
            btn_seminar.TextAlign = ContentAlignment.MiddleLeft;
            btn_seminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_seminar.UseVisualStyleBackColor = false;
            btn_seminar.Click += btn_seminar_Click;
            // 
            // label15
            // 
            label15.BackColor = Color.FromArgb(86, 180, 206);
            label15.Dock = DockStyle.Top;
            label15.Location = new Point(0, 334);
            label15.Name = "label15";
            label15.Padding = new Padding(5, 0, 0, 0);
            label15.Size = new Size(199, 27);
            label15.TabIndex = 28;
            label15.Text = "EVENTS";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_employeerequest
            // 
            btn_employeerequest.BackColor = Color.FromArgb(0, 127, 152);
            btn_employeerequest.Cursor = Cursors.Hand;
            btn_employeerequest.Dock = DockStyle.Top;
            btn_employeerequest.FlatAppearance.BorderSize = 0;
            btn_employeerequest.FlatStyle = FlatStyle.Flat;
            btn_employeerequest.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_employeerequest.IconChar = FontAwesome.Sharp.IconChar.PersonCircleQuestion;
            btn_employeerequest.IconColor = Color.White;
            btn_employeerequest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_employeerequest.IconSize = 25;
            btn_employeerequest.ImageAlign = ContentAlignment.MiddleLeft;
            btn_employeerequest.Location = new Point(0, 299);
            btn_employeerequest.Name = "btn_employeerequest";
            btn_employeerequest.Padding = new Padding(10, 0, 0, 0);
            btn_employeerequest.Size = new Size(199, 35);
            btn_employeerequest.TabIndex = 35;
            btn_employeerequest.Tag = "Employee Requests";
            btn_employeerequest.Text = "Employee Requests";
            btn_employeerequest.TextAlign = ContentAlignment.MiddleLeft;
            btn_employeerequest.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_employeerequest.UseVisualStyleBackColor = false;
            btn_employeerequest.Click += btn_employeerequest_Click;
            // 
            // label16
            // 
            label16.BackColor = Color.FromArgb(86, 180, 206);
            label16.Dock = DockStyle.Top;
            label16.Location = new Point(0, 272);
            label16.Name = "label16";
            label16.Padding = new Padding(5, 0, 0, 0);
            label16.Size = new Size(199, 27);
            label16.TabIndex = 34;
            label16.Text = "EMPLOYEES";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_leaves
            // 
            btn_leaves.BackColor = Color.FromArgb(0, 127, 152);
            btn_leaves.Cursor = Cursors.Hand;
            btn_leaves.Dock = DockStyle.Top;
            btn_leaves.FlatAppearance.BorderSize = 0;
            btn_leaves.FlatStyle = FlatStyle.Flat;
            btn_leaves.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_leaves.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingLuggage;
            btn_leaves.IconColor = Color.White;
            btn_leaves.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_leaves.IconSize = 25;
            btn_leaves.ImageAlign = ContentAlignment.MiddleLeft;
            btn_leaves.Location = new Point(0, 237);
            btn_leaves.Name = "btn_leaves";
            btn_leaves.Padding = new Padding(10, 0, 0, 0);
            btn_leaves.Size = new Size(199, 35);
            btn_leaves.TabIndex = 24;
            btn_leaves.Tag = "Leaves";
            btn_leaves.Text = "Leaves";
            btn_leaves.TextAlign = ContentAlignment.MiddleLeft;
            btn_leaves.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_leaves.UseVisualStyleBackColor = false;
            btn_leaves.Click += btn_leaves_Click;
            // 
            // btn_dutyschedule
            // 
            btn_dutyschedule.BackColor = Color.FromArgb(0, 127, 152);
            btn_dutyschedule.Cursor = Cursors.Hand;
            btn_dutyschedule.Dock = DockStyle.Top;
            btn_dutyschedule.FlatAppearance.BorderSize = 0;
            btn_dutyschedule.FlatStyle = FlatStyle.Flat;
            btn_dutyschedule.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_dutyschedule.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            btn_dutyschedule.IconColor = Color.White;
            btn_dutyschedule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_dutyschedule.IconSize = 25;
            btn_dutyschedule.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dutyschedule.Location = new Point(0, 202);
            btn_dutyschedule.Name = "btn_dutyschedule";
            btn_dutyschedule.Padding = new Padding(10, 0, 0, 0);
            btn_dutyschedule.Size = new Size(199, 35);
            btn_dutyschedule.TabIndex = 27;
            btn_dutyschedule.Tag = "Duty Schedule";
            btn_dutyschedule.Text = "Duty Schedule";
            btn_dutyschedule.TextAlign = ContentAlignment.MiddleLeft;
            btn_dutyschedule.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_dutyschedule.UseVisualStyleBackColor = false;
            btn_dutyschedule.Click += btn_dutyschedule_Click;
            // 
            // btn_doctors
            // 
            btn_doctors.BackColor = Color.FromArgb(0, 127, 152);
            btn_doctors.Cursor = Cursors.Hand;
            btn_doctors.Dock = DockStyle.Top;
            btn_doctors.FlatAppearance.BorderSize = 0;
            btn_doctors.FlatStyle = FlatStyle.Flat;
            btn_doctors.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_doctors.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            btn_doctors.IconColor = Color.White;
            btn_doctors.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_doctors.IconSize = 25;
            btn_doctors.ImageAlign = ContentAlignment.MiddleLeft;
            btn_doctors.Location = new Point(0, 167);
            btn_doctors.Name = "btn_doctors";
            btn_doctors.Padding = new Padding(10, 0, 0, 0);
            btn_doctors.Size = new Size(199, 35);
            btn_doctors.TabIndex = 22;
            btn_doctors.Tag = "Doctors";
            btn_doctors.Text = "Doctors";
            btn_doctors.TextAlign = ContentAlignment.MiddleLeft;
            btn_doctors.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_doctors.UseVisualStyleBackColor = false;
            btn_doctors.Click += btn_doctors_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(0, 127, 152);
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 25;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 132);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 0, 0);
            iconButton1.Size = new Size(199, 35);
            iconButton1.TabIndex = 33;
            iconButton1.Tag = "Outsource";
            iconButton1.Text = "Outsource";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // btn_employee
            // 
            btn_employee.BackColor = Color.FromArgb(0, 127, 152);
            btn_employee.Cursor = Cursors.Hand;
            btn_employee.Dock = DockStyle.Top;
            btn_employee.FlatAppearance.BorderSize = 0;
            btn_employee.FlatStyle = FlatStyle.Flat;
            btn_employee.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            btn_employee.IconColor = Color.White;
            btn_employee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_employee.IconSize = 25;
            btn_employee.ImageAlign = ContentAlignment.MiddleLeft;
            btn_employee.Location = new Point(0, 97);
            btn_employee.Name = "btn_employee";
            btn_employee.Padding = new Padding(10, 0, 0, 0);
            btn_employee.Size = new Size(199, 35);
            btn_employee.TabIndex = 19;
            btn_employee.Tag = "Employee";
            btn_employee.Text = "Employee";
            btn_employee.TextAlign = ContentAlignment.MiddleLeft;
            btn_employee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_employee.UseVisualStyleBackColor = false;
            btn_employee.Click += btn_employee_Click;
            // 
            // btn_hiring
            // 
            btn_hiring.BackColor = Color.FromArgb(0, 127, 152);
            btn_hiring.Cursor = Cursors.Hand;
            btn_hiring.Dock = DockStyle.Top;
            btn_hiring.FlatAppearance.BorderSize = 0;
            btn_hiring.FlatStyle = FlatStyle.Flat;
            btn_hiring.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_hiring.IconChar = FontAwesome.Sharp.IconChar.Bullhorn;
            btn_hiring.IconColor = Color.White;
            btn_hiring.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_hiring.IconSize = 25;
            btn_hiring.ImageAlign = ContentAlignment.MiddleLeft;
            btn_hiring.Location = new Point(0, 62);
            btn_hiring.Name = "btn_hiring";
            btn_hiring.Padding = new Padding(10, 0, 0, 0);
            btn_hiring.Size = new Size(199, 35);
            btn_hiring.TabIndex = 32;
            btn_hiring.Tag = "Hiring";
            btn_hiring.Text = "Hiring";
            btn_hiring.TextAlign = ContentAlignment.MiddleLeft;
            btn_hiring.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_hiring.UseVisualStyleBackColor = false;
            btn_hiring.Click += btn_hiring_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(86, 180, 206);
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(0, 35);
            label1.Name = "label1";
            label1.Padding = new Padding(5, 0, 0, 0);
            label1.Size = new Size(199, 27);
            label1.TabIndex = 18;
            label1.Text = "MASTER FILES";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_dashboard
            // 
            btn_dashboard.BackColor = Color.FromArgb(0, 127, 152);
            btn_dashboard.Cursor = Cursors.Hand;
            btn_dashboard.Dock = DockStyle.Top;
            btn_dashboard.FlatAppearance.BorderSize = 0;
            btn_dashboard.FlatStyle = FlatStyle.Flat;
            btn_dashboard.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_dashboard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            btn_dashboard.IconColor = Color.White;
            btn_dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_dashboard.IconSize = 25;
            btn_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.Location = new Point(0, 0);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Padding = new Padding(10, 0, 0, 0);
            btn_dashboard.Size = new Size(199, 35);
            btn_dashboard.TabIndex = 21;
            btn_dashboard.Tag = "Dashboard";
            btn_dashboard.Text = "Dashboard";
            btn_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_dashboard.UseVisualStyleBackColor = false;
            btn_dashboard.Click += btn_dashboard_Click_1;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(248, 146, 54);
            panelLogo.Controls.Add(Image_Logo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(10);
            panelLogo.Size = new Size(199, 100);
            panelLogo.TabIndex = 0;
            // 
            // Image_Logo
            // 
            Image_Logo.Cursor = Cursors.Hand;
            Image_Logo.Dock = DockStyle.Fill;
            Image_Logo.Image = (Image)resources.GetObject("Image_Logo.Image");
            Image_Logo.Location = new Point(10, 10);
            Image_Logo.Name = "Image_Logo";
            Image_Logo.Size = new Size(179, 80);
            Image_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            Image_Logo.TabIndex = 0;
            Image_Logo.TabStop = false;
            Image_Logo.Tag = "Home";
            Image_Logo.Click += Image_Logo_Click;
            // 
            // HomePanel
            // 
            HomePanel.BackColor = Color.FromArgb(193, 250, 255);
            HomePanel.Controls.Add(panel2);
            HomePanel.Dock = DockStyle.Fill;
            HomePanel.Location = new Point(199, 100);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new Size(847, 513);
            HomePanel.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(173, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(511, 409);
            panel2.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(64, 64, 64);
            label13.Location = new Point(113, 350);
            label13.Name = "label13";
            label13.Size = new Size(169, 13);
            label13.TabIndex = 17;
            label13.Text = "Generates customizable reports";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(64, 64, 64);
            label12.Location = new Point(113, 289);
            label12.Name = "label12";
            label12.Size = new Size(362, 13);
            label12.TabIndex = 16;
            label12.Text = "Track employee attendance, including leaves, vacations and absences";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(64, 64, 64);
            label11.Location = new Point(113, 233);
            label11.Name = "label11";
            label11.Size = new Size(339, 13);
            label11.TabIndex = 15;
            label11.Text = "Manage all employee information, employment history and more";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(64, 64, 64);
            label10.Location = new Point(113, 177);
            label10.Name = "label10";
            label10.Size = new Size(350, 13);
            label10.TabIndex = 14;
            label10.Text = "Automate the recruitment process from job posting to onboarding";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 127, 152);
            panel4.Location = new Point(26, 382);
            panel4.Name = "panel4";
            panel4.Size = new Size(469, 1);
            panel4.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 127, 152);
            panel3.Location = new Point(26, 143);
            panel3.Name = "panel3";
            panel3.Size = new Size(469, 1);
            panel3.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(0, 127, 152);
            label9.Location = new Point(113, 325);
            label9.Name = "label9";
            label9.Size = new Size(130, 21);
            label9.TabIndex = 11;
            label9.Text = "Report Manager";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(0, 127, 152);
            label8.Location = new Point(113, 268);
            label8.Name = "label8";
            label8.Size = new Size(251, 21);
            label8.TabIndex = 10;
            label8.Text = "Time && Attendance Management";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 127, 152);
            label7.Location = new Point(113, 212);
            label7.Name = "label7";
            label7.Size = new Size(278, 21);
            label7.TabIndex = 9;
            label7.Text = "Employee Information Management ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 127, 152);
            label6.Location = new Point(113, 156);
            label6.Name = "label6";
            label6.Size = new Size(201, 21);
            label6.TabIndex = 8;
            label6.Text = "Recruitment Management";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(57, 325);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 38);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 7;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(57, 268);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 38);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(57, 212);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(57, 156);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 127, 152);
            label3.Location = new Point(138, 26);
            label3.Name = "label3";
            label3.Size = new Size(353, 54);
            label3.TabIndex = 0;
            label3.Text = "Human Resource";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(248, 146, 54);
            label4.Location = new Point(138, 67);
            label4.Name = "label4";
            label4.Size = new Size(348, 51);
            label4.TabIndex = 1;
            label4.Text = "Information System";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 127, 152);
            label5.Location = new Point(145, 118);
            label5.Name = "label5";
            label5.Size = new Size(242, 15);
            label5.TabIndex = 2;
            label5.Text = "Licensed to Adventist Medical Center - Bacolod";
            // 
            // iconSplitButton1
            // 
            iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSplitButton1.IconColor = Color.Black;
            iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSplitButton1.IconSize = 48;
            iconSplitButton1.Name = "iconSplitButton1";
            iconSplitButton1.Rotation = 0D;
            iconSplitButton1.Size = new Size(23, 23);
            iconSplitButton1.Text = "iconSplitButton1";
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(199, 100);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(847, 513);
            MainPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1046, 613);
            Controls.Add(HomePanel);
            Controls.Add(MainPanel);
            Controls.Add(panelTop);
            Controls.Add(panelLeft);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Human Resource Information System";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picturebox_profilepicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon_home).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panelLeft.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Image_Logo).EndInit();
            HomePanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelLeft;
        private Panel HomePanel;
        private Panel panelLogo;
        private PictureBox Image_Logo;
        private FontAwesome.Sharp.IconPictureBox icon_home;
        private Label lbl_formtitle;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btn_audittrail;
        private FontAwesome.Sharp.IconButton btn_reportmanager;
        private FontAwesome.Sharp.IconButton btn_maintenance;
        private Label label2;
        private FontAwesome.Sharp.IconButton btn_leaves;
        private FontAwesome.Sharp.IconButton btn_dutyschedule;
        private FontAwesome.Sharp.IconButton btn_doctors;
        private FontAwesome.Sharp.IconButton btn_employee;
        private Label label1;
        private FontAwesome.Sharp.IconButton btn_dashboard;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private Panel panel2;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Panel panel4;
        private Panel panel3;
        private Label label_completename;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel MainPanel;
        private JPCircularPictureBox picturebox_profilepicture;
        private FontAwesome.Sharp.IconButton btn_attendance;
        private FontAwesome.Sharp.IconButton btn_training;
        private FontAwesome.Sharp.IconButton btn_seminar;
        private Label label15;
        private FontAwesome.Sharp.IconButton btn_hiring;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btn_employeerequest;
        private Label label16;
        private Label label1_idno;
    }
}