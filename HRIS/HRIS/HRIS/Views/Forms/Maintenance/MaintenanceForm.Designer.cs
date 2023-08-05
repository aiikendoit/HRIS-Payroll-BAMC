namespace HRIS.Forms.Maintenance
{
    partial class MaintenanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_cancel = new Button();
            btn_save = new Button();
            txt_emailaddress = new TextBox();
            txt_completeaddress = new TextBox();
            MainPanel = new Panel();
            panel4 = new Panel();
            txt_website = new TextBox();
            txt_owner = new TextBox();
            txt_telephone = new TextBox();
            btn_basicinformation = new FontAwesome.Sharp.IconButton();
            panelmenu = new Panel();
            btn_ = new FontAwesome.Sharp.IconButton();
            btn_towncity = new FontAwesome.Sharp.IconButton();
            btn_salarysetting = new FontAwesome.Sharp.IconButton();
            btn_religion = new FontAwesome.Sharp.IconButton();
            btn_relationship = new FontAwesome.Sharp.IconButton();
            btn_province = new FontAwesome.Sharp.IconButton();
            btn_position = new FontAwesome.Sharp.IconButton();
            btn_offencetype = new FontAwesome.Sharp.IconButton();
            btn_nationality = new FontAwesome.Sharp.IconButton();
            btn_licenseType = new FontAwesome.Sharp.IconButton();
            btn_leaveType = new FontAwesome.Sharp.IconButton();
            btn_leavenoticeType = new FontAwesome.Sharp.IconButton();
            btn_employmenttype = new FontAwesome.Sharp.IconButton();
            btn_educationalLevel = new FontAwesome.Sharp.IconButton();
            btn_documenttype = new FontAwesome.Sharp.IconButton();
            btn_disciplinary = new FontAwesome.Sharp.IconButton();
            btn_department = new FontAwesome.Sharp.IconButton();
            btn_degreetype = new FontAwesome.Sharp.IconButton();
            btn_civilstatus = new FontAwesome.Sharp.IconButton();
            btn_bank = new FontAwesome.Sharp.IconButton();
            btn_barangay = new FontAwesome.Sharp.IconButton();
            label_Headername = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            label9 = new Label();
            panel_basicinfo = new Panel();
            picture_logo = new PictureBox();
            label12 = new Label();
            btn_address = new Button();
            txt_fax = new TextBox();
            label1 = new Label();
            txt_organizationname = new TextBox();
            label11 = new Label();
            label8 = new Label();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            panelmenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            panel_basicinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.Transparent;
            btn_cancel.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 152);
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(293, 373);
            btn_cancel.Margin = new Padding(4, 3, 4, 3);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(91, 36);
            btn_cancel.TabIndex = 8;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(0, 127, 152);
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(196, 373);
            btn_save.Margin = new Padding(4, 3, 4, 3);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(91, 36);
            btn_save.TabIndex = 7;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // txt_emailaddress
            // 
            txt_emailaddress.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_emailaddress.Location = new Point(195, 133);
            txt_emailaddress.Margin = new Padding(4, 3, 4, 3);
            txt_emailaddress.Name = "txt_emailaddress";
            txt_emailaddress.Size = new Size(507, 23);
            txt_emailaddress.TabIndex = 3;
            txt_emailaddress.Leave += txt_emailaddress_Leave;
            // 
            // txt_completeaddress
            // 
            txt_completeaddress.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_completeaddress.Location = new Point(195, 183);
            txt_completeaddress.Margin = new Padding(4, 3, 4, 3);
            txt_completeaddress.Multiline = true;
            txt_completeaddress.Name = "txt_completeaddress";
            txt_completeaddress.ReadOnly = true;
            txt_completeaddress.Size = new Size(507, 59);
            txt_completeaddress.TabIndex = 4;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(199, 63);
            MainPanel.Margin = new Padding(4, 3, 4, 3);
            MainPanel.Name = "MainPanel";
            MainPanel.Padding = new Padding(5);
            MainPanel.Size = new Size(716, 419);
            MainPanel.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.WhiteSmoke;
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(199, 62);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(716, 1);
            panel4.TabIndex = 11;
            // 
            // txt_website
            // 
            txt_website.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_website.Location = new Point(195, 108);
            txt_website.Margin = new Padding(4, 3, 4, 3);
            txt_website.Name = "txt_website";
            txt_website.Size = new Size(507, 23);
            txt_website.TabIndex = 2;
            // 
            // txt_owner
            // 
            txt_owner.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_owner.Location = new Point(195, 83);
            txt_owner.Margin = new Padding(4, 3, 4, 3);
            txt_owner.Name = "txt_owner";
            txt_owner.Size = new Size(507, 23);
            txt_owner.TabIndex = 1;
            // 
            // txt_telephone
            // 
            txt_telephone.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_telephone.Location = new Point(195, 158);
            txt_telephone.Margin = new Padding(4, 3, 4, 3);
            txt_telephone.Name = "txt_telephone";
            txt_telephone.Size = new Size(233, 23);
            txt_telephone.TabIndex = 4;
            // 
            // btn_basicinformation
            // 
            btn_basicinformation.BackColor = Color.FromArgb(0, 127, 152);
            btn_basicinformation.Cursor = Cursors.Hand;
            btn_basicinformation.Dock = DockStyle.Top;
            btn_basicinformation.FlatAppearance.BorderSize = 0;
            btn_basicinformation.FlatStyle = FlatStyle.Flat;
            btn_basicinformation.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_basicinformation.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_basicinformation.IconColor = Color.White;
            btn_basicinformation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_basicinformation.IconSize = 20;
            btn_basicinformation.ImageAlign = ContentAlignment.MiddleLeft;
            btn_basicinformation.Location = new Point(2, 2);
            btn_basicinformation.Margin = new Padding(4, 3, 4, 3);
            btn_basicinformation.Name = "btn_basicinformation";
            btn_basicinformation.Padding = new Padding(10, 0, 0, 0);
            btn_basicinformation.Size = new Size(173, 28);
            btn_basicinformation.TabIndex = 22;
            btn_basicinformation.Tag = "Company Information";
            btn_basicinformation.Text = "Company Information";
            btn_basicinformation.TextAlign = ContentAlignment.MiddleLeft;
            btn_basicinformation.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_basicinformation.UseVisualStyleBackColor = false;
            btn_basicinformation.Click += btn_basicinformation_Click;
            // 
            // panelmenu
            // 
            panelmenu.AutoScroll = true;
            panelmenu.BackColor = Color.FromArgb(0, 127, 152);
            panelmenu.Controls.Add(btn_);
            panelmenu.Controls.Add(btn_towncity);
            panelmenu.Controls.Add(btn_salarysetting);
            panelmenu.Controls.Add(btn_religion);
            panelmenu.Controls.Add(btn_relationship);
            panelmenu.Controls.Add(btn_province);
            panelmenu.Controls.Add(btn_position);
            panelmenu.Controls.Add(btn_offencetype);
            panelmenu.Controls.Add(btn_nationality);
            panelmenu.Controls.Add(btn_licenseType);
            panelmenu.Controls.Add(btn_leaveType);
            panelmenu.Controls.Add(btn_leavenoticeType);
            panelmenu.Controls.Add(btn_employmenttype);
            panelmenu.Controls.Add(btn_educationalLevel);
            panelmenu.Controls.Add(btn_documenttype);
            panelmenu.Controls.Add(btn_disciplinary);
            panelmenu.Controls.Add(btn_department);
            panelmenu.Controls.Add(btn_degreetype);
            panelmenu.Controls.Add(btn_civilstatus);
            panelmenu.Controls.Add(btn_bank);
            panelmenu.Controls.Add(btn_barangay);
            panelmenu.Controls.Add(btn_basicinformation);
            panelmenu.Dock = DockStyle.Left;
            panelmenu.ForeColor = Color.White;
            panelmenu.Location = new Point(5, 62);
            panelmenu.Margin = new Padding(4, 3, 4, 3);
            panelmenu.Name = "panelmenu";
            panelmenu.Padding = new Padding(2);
            panelmenu.Size = new Size(194, 420);
            panelmenu.TabIndex = 7;
            // 
            // btn_
            // 
            btn_.BackColor = Color.FromArgb(0, 127, 152);
            btn_.Cursor = Cursors.Hand;
            btn_.Dock = DockStyle.Top;
            btn_.FlatAppearance.BorderSize = 0;
            btn_.FlatStyle = FlatStyle.Flat;
            btn_.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_.IconColor = Color.White;
            btn_.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_.IconSize = 20;
            btn_.ImageAlign = ContentAlignment.MiddleLeft;
            btn_.Location = new Point(2, 590);
            btn_.Margin = new Padding(4, 3, 4, 3);
            btn_.Name = "btn_";
            btn_.Padding = new Padding(10, 0, 0, 0);
            btn_.Size = new Size(173, 28);
            btn_.TabIndex = 43;
            btn_.Tag = "Wage Factor";
            btn_.Text = "Wage Factor";
            btn_.TextAlign = ContentAlignment.MiddleLeft;
            btn_.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_.UseVisualStyleBackColor = false;
            // 
            // btn_towncity
            // 
            btn_towncity.BackColor = Color.FromArgb(0, 127, 152);
            btn_towncity.Cursor = Cursors.Hand;
            btn_towncity.Dock = DockStyle.Top;
            btn_towncity.FlatAppearance.BorderSize = 0;
            btn_towncity.FlatStyle = FlatStyle.Flat;
            btn_towncity.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_towncity.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_towncity.IconColor = Color.White;
            btn_towncity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_towncity.IconSize = 20;
            btn_towncity.ImageAlign = ContentAlignment.MiddleLeft;
            btn_towncity.Location = new Point(2, 562);
            btn_towncity.Margin = new Padding(4, 3, 4, 3);
            btn_towncity.Name = "btn_towncity";
            btn_towncity.Padding = new Padding(10, 0, 0, 0);
            btn_towncity.Size = new Size(173, 28);
            btn_towncity.TabIndex = 42;
            btn_towncity.Tag = "Town/City";
            btn_towncity.Text = "Town/City";
            btn_towncity.TextAlign = ContentAlignment.MiddleLeft;
            btn_towncity.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_towncity.UseVisualStyleBackColor = false;
            btn_towncity.Click += btn_townCity_click;
            // 
            // btn_salarysetting
            // 
            btn_salarysetting.BackColor = Color.FromArgb(0, 127, 152);
            btn_salarysetting.Cursor = Cursors.Hand;
            btn_salarysetting.Dock = DockStyle.Top;
            btn_salarysetting.FlatAppearance.BorderSize = 0;
            btn_salarysetting.FlatStyle = FlatStyle.Flat;
            btn_salarysetting.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_salarysetting.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_salarysetting.IconColor = Color.White;
            btn_salarysetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_salarysetting.IconSize = 20;
            btn_salarysetting.ImageAlign = ContentAlignment.MiddleLeft;
            btn_salarysetting.Location = new Point(2, 534);
            btn_salarysetting.Margin = new Padding(4, 3, 4, 3);
            btn_salarysetting.Name = "btn_salarysetting";
            btn_salarysetting.Padding = new Padding(10, 0, 0, 0);
            btn_salarysetting.Size = new Size(173, 28);
            btn_salarysetting.TabIndex = 41;
            btn_salarysetting.Tag = "Salary Type";
            btn_salarysetting.Text = "Salary Setting";
            btn_salarysetting.TextAlign = ContentAlignment.MiddleLeft;
            btn_salarysetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_salarysetting.UseVisualStyleBackColor = false;
            btn_salarysetting.Click += btn_salarysetting_Click;
            // 
            // btn_religion
            // 
            btn_religion.BackColor = Color.FromArgb(0, 127, 152);
            btn_religion.Cursor = Cursors.Hand;
            btn_religion.Dock = DockStyle.Top;
            btn_religion.FlatAppearance.BorderSize = 0;
            btn_religion.FlatStyle = FlatStyle.Flat;
            btn_religion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_religion.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_religion.IconColor = Color.White;
            btn_religion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_religion.IconSize = 20;
            btn_religion.ImageAlign = ContentAlignment.MiddleLeft;
            btn_religion.Location = new Point(2, 506);
            btn_religion.Margin = new Padding(4, 3, 4, 3);
            btn_religion.Name = "btn_religion";
            btn_religion.Padding = new Padding(10, 0, 0, 0);
            btn_religion.Size = new Size(173, 28);
            btn_religion.TabIndex = 40;
            btn_religion.Tag = "Religion";
            btn_religion.Text = "Religion";
            btn_religion.TextAlign = ContentAlignment.MiddleLeft;
            btn_religion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_religion.UseVisualStyleBackColor = false;
            btn_religion.Click += iconButton18_Click;
            // 
            // btn_relationship
            // 
            btn_relationship.BackColor = Color.FromArgb(0, 127, 152);
            btn_relationship.Cursor = Cursors.Hand;
            btn_relationship.Dock = DockStyle.Top;
            btn_relationship.FlatAppearance.BorderSize = 0;
            btn_relationship.FlatStyle = FlatStyle.Flat;
            btn_relationship.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_relationship.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_relationship.IconColor = Color.White;
            btn_relationship.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_relationship.IconSize = 20;
            btn_relationship.ImageAlign = ContentAlignment.MiddleLeft;
            btn_relationship.Location = new Point(2, 478);
            btn_relationship.Margin = new Padding(4, 3, 4, 3);
            btn_relationship.Name = "btn_relationship";
            btn_relationship.Padding = new Padding(10, 0, 0, 0);
            btn_relationship.Size = new Size(173, 28);
            btn_relationship.TabIndex = 45;
            btn_relationship.Tag = "Relationship";
            btn_relationship.Text = "Relationship";
            btn_relationship.TextAlign = ContentAlignment.MiddleLeft;
            btn_relationship.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_relationship.UseVisualStyleBackColor = false;
            btn_relationship.Click += btn_relationship_Click;
            // 
            // btn_province
            // 
            btn_province.BackColor = Color.FromArgb(0, 127, 152);
            btn_province.Cursor = Cursors.Hand;
            btn_province.Dock = DockStyle.Top;
            btn_province.FlatAppearance.BorderSize = 0;
            btn_province.FlatStyle = FlatStyle.Flat;
            btn_province.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_province.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_province.IconColor = Color.White;
            btn_province.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_province.IconSize = 20;
            btn_province.ImageAlign = ContentAlignment.MiddleLeft;
            btn_province.Location = new Point(2, 450);
            btn_province.Margin = new Padding(4, 3, 4, 3);
            btn_province.Name = "btn_province";
            btn_province.Padding = new Padding(10, 0, 0, 0);
            btn_province.Size = new Size(173, 28);
            btn_province.TabIndex = 39;
            btn_province.Tag = "Province";
            btn_province.Text = "Province";
            btn_province.TextAlign = ContentAlignment.MiddleLeft;
            btn_province.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_province.UseVisualStyleBackColor = false;
            btn_province.Click += btn_province_Click;
            // 
            // btn_position
            // 
            btn_position.BackColor = Color.FromArgb(0, 127, 152);
            btn_position.Cursor = Cursors.Hand;
            btn_position.Dock = DockStyle.Top;
            btn_position.FlatAppearance.BorderSize = 0;
            btn_position.FlatStyle = FlatStyle.Flat;
            btn_position.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_position.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_position.IconColor = Color.White;
            btn_position.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_position.IconSize = 20;
            btn_position.ImageAlign = ContentAlignment.MiddleLeft;
            btn_position.Location = new Point(2, 422);
            btn_position.Margin = new Padding(4, 3, 4, 3);
            btn_position.Name = "btn_position";
            btn_position.Padding = new Padding(10, 0, 0, 0);
            btn_position.Size = new Size(173, 28);
            btn_position.TabIndex = 38;
            btn_position.Tag = "Position";
            btn_position.Text = "Position";
            btn_position.TextAlign = ContentAlignment.MiddleLeft;
            btn_position.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_position.UseVisualStyleBackColor = false;
            btn_position.Click += iconButton16_Click;
            // 
            // btn_offencetype
            // 
            btn_offencetype.BackColor = Color.FromArgb(0, 127, 152);
            btn_offencetype.Cursor = Cursors.Hand;
            btn_offencetype.Dock = DockStyle.Top;
            btn_offencetype.FlatAppearance.BorderSize = 0;
            btn_offencetype.FlatStyle = FlatStyle.Flat;
            btn_offencetype.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_offencetype.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_offencetype.IconColor = Color.White;
            btn_offencetype.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_offencetype.IconSize = 20;
            btn_offencetype.ImageAlign = ContentAlignment.MiddleLeft;
            btn_offencetype.Location = new Point(2, 394);
            btn_offencetype.Margin = new Padding(4, 3, 4, 3);
            btn_offencetype.Name = "btn_offencetype";
            btn_offencetype.Padding = new Padding(10, 0, 0, 0);
            btn_offencetype.Size = new Size(173, 28);
            btn_offencetype.TabIndex = 37;
            btn_offencetype.Tag = "Offence Type";
            btn_offencetype.Text = "Offence Type";
            btn_offencetype.TextAlign = ContentAlignment.MiddleLeft;
            btn_offencetype.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_offencetype.UseVisualStyleBackColor = false;
            btn_offencetype.Click += btn_offencetype_Click;
            // 
            // btn_nationality
            // 
            btn_nationality.BackColor = Color.FromArgb(0, 127, 152);
            btn_nationality.Cursor = Cursors.Hand;
            btn_nationality.Dock = DockStyle.Top;
            btn_nationality.FlatAppearance.BorderSize = 0;
            btn_nationality.FlatStyle = FlatStyle.Flat;
            btn_nationality.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_nationality.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_nationality.IconColor = Color.White;
            btn_nationality.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_nationality.IconSize = 20;
            btn_nationality.ImageAlign = ContentAlignment.MiddleLeft;
            btn_nationality.Location = new Point(2, 366);
            btn_nationality.Margin = new Padding(4, 3, 4, 3);
            btn_nationality.Name = "btn_nationality";
            btn_nationality.Padding = new Padding(10, 0, 0, 0);
            btn_nationality.Size = new Size(173, 28);
            btn_nationality.TabIndex = 44;
            btn_nationality.Tag = "Nationality";
            btn_nationality.Text = "Nationality";
            btn_nationality.TextAlign = ContentAlignment.MiddleLeft;
            btn_nationality.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_nationality.UseVisualStyleBackColor = false;
            btn_nationality.Click += btn_nationality_Click;
            // 
            // btn_licenseType
            // 
            btn_licenseType.BackColor = Color.FromArgb(0, 127, 152);
            btn_licenseType.Cursor = Cursors.Hand;
            btn_licenseType.Dock = DockStyle.Top;
            btn_licenseType.FlatAppearance.BorderSize = 0;
            btn_licenseType.FlatStyle = FlatStyle.Flat;
            btn_licenseType.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_licenseType.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_licenseType.IconColor = Color.White;
            btn_licenseType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_licenseType.IconSize = 20;
            btn_licenseType.ImageAlign = ContentAlignment.MiddleLeft;
            btn_licenseType.Location = new Point(2, 338);
            btn_licenseType.Margin = new Padding(4, 3, 4, 3);
            btn_licenseType.Name = "btn_licenseType";
            btn_licenseType.Padding = new Padding(10, 0, 0, 0);
            btn_licenseType.Size = new Size(173, 28);
            btn_licenseType.TabIndex = 36;
            btn_licenseType.Tag = "License type";
            btn_licenseType.Text = "License Type";
            btn_licenseType.TextAlign = ContentAlignment.MiddleLeft;
            btn_licenseType.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_licenseType.UseVisualStyleBackColor = false;
            btn_licenseType.Click += btn_licenseType_Click;
            // 
            // btn_leaveType
            // 
            btn_leaveType.BackColor = Color.FromArgb(0, 127, 152);
            btn_leaveType.Cursor = Cursors.Hand;
            btn_leaveType.Dock = DockStyle.Top;
            btn_leaveType.FlatAppearance.BorderSize = 0;
            btn_leaveType.FlatStyle = FlatStyle.Flat;
            btn_leaveType.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_leaveType.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_leaveType.IconColor = Color.White;
            btn_leaveType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_leaveType.IconSize = 20;
            btn_leaveType.ImageAlign = ContentAlignment.MiddleLeft;
            btn_leaveType.Location = new Point(2, 310);
            btn_leaveType.Margin = new Padding(4, 3, 4, 3);
            btn_leaveType.Name = "btn_leaveType";
            btn_leaveType.Padding = new Padding(10, 0, 0, 0);
            btn_leaveType.Size = new Size(173, 28);
            btn_leaveType.TabIndex = 35;
            btn_leaveType.Tag = "Leave Type";
            btn_leaveType.Text = "Leave Type";
            btn_leaveType.TextAlign = ContentAlignment.MiddleLeft;
            btn_leaveType.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_leaveType.UseVisualStyleBackColor = false;
            btn_leaveType.Click += btn_leaveType_Click;
            // 
            // btn_leavenoticeType
            // 
            btn_leavenoticeType.BackColor = Color.FromArgb(0, 127, 152);
            btn_leavenoticeType.Cursor = Cursors.Hand;
            btn_leavenoticeType.Dock = DockStyle.Top;
            btn_leavenoticeType.FlatAppearance.BorderSize = 0;
            btn_leavenoticeType.FlatStyle = FlatStyle.Flat;
            btn_leavenoticeType.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_leavenoticeType.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_leavenoticeType.IconColor = Color.White;
            btn_leavenoticeType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_leavenoticeType.IconSize = 20;
            btn_leavenoticeType.ImageAlign = ContentAlignment.MiddleLeft;
            btn_leavenoticeType.Location = new Point(2, 282);
            btn_leavenoticeType.Margin = new Padding(4, 3, 4, 3);
            btn_leavenoticeType.Name = "btn_leavenoticeType";
            btn_leavenoticeType.Padding = new Padding(10, 0, 0, 0);
            btn_leavenoticeType.Size = new Size(173, 28);
            btn_leavenoticeType.TabIndex = 34;
            btn_leavenoticeType.Tag = "Leave notice type";
            btn_leavenoticeType.Text = "Leave notice type";
            btn_leavenoticeType.TextAlign = ContentAlignment.MiddleLeft;
            btn_leavenoticeType.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_leavenoticeType.UseVisualStyleBackColor = false;
            btn_leavenoticeType.Click += btn_leavenoticeType_Click;
            // 
            // btn_employmenttype
            // 
            btn_employmenttype.BackColor = Color.FromArgb(0, 127, 152);
            btn_employmenttype.Cursor = Cursors.Hand;
            btn_employmenttype.Dock = DockStyle.Top;
            btn_employmenttype.FlatAppearance.BorderSize = 0;
            btn_employmenttype.FlatStyle = FlatStyle.Flat;
            btn_employmenttype.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_employmenttype.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_employmenttype.IconColor = Color.White;
            btn_employmenttype.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_employmenttype.IconSize = 20;
            btn_employmenttype.ImageAlign = ContentAlignment.MiddleLeft;
            btn_employmenttype.Location = new Point(2, 254);
            btn_employmenttype.Margin = new Padding(4, 3, 4, 3);
            btn_employmenttype.Name = "btn_employmenttype";
            btn_employmenttype.Padding = new Padding(10, 0, 0, 0);
            btn_employmenttype.Size = new Size(173, 28);
            btn_employmenttype.TabIndex = 33;
            btn_employmenttype.Tag = "Employment type";
            btn_employmenttype.Text = "Employment type";
            btn_employmenttype.TextAlign = ContentAlignment.MiddleLeft;
            btn_employmenttype.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_employmenttype.UseVisualStyleBackColor = false;
            btn_employmenttype.Click += btn_employmenttype_Click;
            // 
            // btn_educationalLevel
            // 
            btn_educationalLevel.BackColor = Color.FromArgb(0, 127, 152);
            btn_educationalLevel.Cursor = Cursors.Hand;
            btn_educationalLevel.Dock = DockStyle.Top;
            btn_educationalLevel.FlatAppearance.BorderSize = 0;
            btn_educationalLevel.FlatStyle = FlatStyle.Flat;
            btn_educationalLevel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_educationalLevel.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_educationalLevel.IconColor = Color.White;
            btn_educationalLevel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_educationalLevel.IconSize = 20;
            btn_educationalLevel.ImageAlign = ContentAlignment.MiddleLeft;
            btn_educationalLevel.Location = new Point(2, 226);
            btn_educationalLevel.Margin = new Padding(4, 3, 4, 3);
            btn_educationalLevel.Name = "btn_educationalLevel";
            btn_educationalLevel.Padding = new Padding(10, 0, 0, 0);
            btn_educationalLevel.Size = new Size(173, 28);
            btn_educationalLevel.TabIndex = 32;
            btn_educationalLevel.Tag = "Educational level";
            btn_educationalLevel.Text = "Educational level";
            btn_educationalLevel.TextAlign = ContentAlignment.MiddleLeft;
            btn_educationalLevel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_educationalLevel.UseVisualStyleBackColor = false;
            btn_educationalLevel.Click += btn_educationalLevel_Click;
            // 
            // btn_documenttype
            // 
            btn_documenttype.BackColor = Color.FromArgb(0, 127, 152);
            btn_documenttype.Cursor = Cursors.Hand;
            btn_documenttype.Dock = DockStyle.Top;
            btn_documenttype.FlatAppearance.BorderSize = 0;
            btn_documenttype.FlatStyle = FlatStyle.Flat;
            btn_documenttype.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_documenttype.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_documenttype.IconColor = Color.White;
            btn_documenttype.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_documenttype.IconSize = 20;
            btn_documenttype.ImageAlign = ContentAlignment.MiddleLeft;
            btn_documenttype.Location = new Point(2, 198);
            btn_documenttype.Margin = new Padding(4, 3, 4, 3);
            btn_documenttype.Name = "btn_documenttype";
            btn_documenttype.Padding = new Padding(10, 0, 0, 0);
            btn_documenttype.Size = new Size(173, 28);
            btn_documenttype.TabIndex = 31;
            btn_documenttype.Tag = "Document type";
            btn_documenttype.Text = "Document type";
            btn_documenttype.TextAlign = ContentAlignment.MiddleLeft;
            btn_documenttype.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_documenttype.UseVisualStyleBackColor = false;
            btn_documenttype.Click += btn_documenttype_Click;
            // 
            // btn_disciplinary
            // 
            btn_disciplinary.BackColor = Color.FromArgb(0, 127, 152);
            btn_disciplinary.Cursor = Cursors.Hand;
            btn_disciplinary.Dock = DockStyle.Top;
            btn_disciplinary.FlatAppearance.BorderSize = 0;
            btn_disciplinary.FlatStyle = FlatStyle.Flat;
            btn_disciplinary.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_disciplinary.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_disciplinary.IconColor = Color.White;
            btn_disciplinary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_disciplinary.IconSize = 20;
            btn_disciplinary.ImageAlign = ContentAlignment.MiddleLeft;
            btn_disciplinary.Location = new Point(2, 170);
            btn_disciplinary.Margin = new Padding(4, 3, 4, 3);
            btn_disciplinary.Name = "btn_disciplinary";
            btn_disciplinary.Padding = new Padding(10, 0, 0, 0);
            btn_disciplinary.Size = new Size(173, 28);
            btn_disciplinary.TabIndex = 30;
            btn_disciplinary.Tag = "Disciplinary type";
            btn_disciplinary.Text = "Disciplinary type";
            btn_disciplinary.TextAlign = ContentAlignment.MiddleLeft;
            btn_disciplinary.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_disciplinary.UseVisualStyleBackColor = false;
            btn_disciplinary.Click += btn_disciplinary_Click;
            // 
            // btn_department
            // 
            btn_department.BackColor = Color.FromArgb(0, 127, 152);
            btn_department.Cursor = Cursors.Hand;
            btn_department.Dock = DockStyle.Top;
            btn_department.FlatAppearance.BorderSize = 0;
            btn_department.FlatStyle = FlatStyle.Flat;
            btn_department.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_department.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_department.IconColor = Color.White;
            btn_department.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_department.IconSize = 20;
            btn_department.ImageAlign = ContentAlignment.MiddleLeft;
            btn_department.Location = new Point(2, 142);
            btn_department.Margin = new Padding(4, 3, 4, 3);
            btn_department.Name = "btn_department";
            btn_department.Padding = new Padding(10, 0, 0, 0);
            btn_department.Size = new Size(173, 28);
            btn_department.TabIndex = 28;
            btn_department.Tag = "Department";
            btn_department.Text = "Department";
            btn_department.TextAlign = ContentAlignment.MiddleLeft;
            btn_department.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_department.UseVisualStyleBackColor = false;
            btn_department.Click += btn_department_Click;
            // 
            // btn_degreetype
            // 
            btn_degreetype.BackColor = Color.FromArgb(0, 127, 152);
            btn_degreetype.Cursor = Cursors.Hand;
            btn_degreetype.Dock = DockStyle.Top;
            btn_degreetype.FlatAppearance.BorderSize = 0;
            btn_degreetype.FlatStyle = FlatStyle.Flat;
            btn_degreetype.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_degreetype.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_degreetype.IconColor = Color.White;
            btn_degreetype.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_degreetype.IconSize = 20;
            btn_degreetype.ImageAlign = ContentAlignment.MiddleLeft;
            btn_degreetype.Location = new Point(2, 114);
            btn_degreetype.Margin = new Padding(4, 3, 4, 3);
            btn_degreetype.Name = "btn_degreetype";
            btn_degreetype.Padding = new Padding(10, 0, 0, 0);
            btn_degreetype.Size = new Size(173, 28);
            btn_degreetype.TabIndex = 27;
            btn_degreetype.Tag = "Degree type";
            btn_degreetype.Text = "Degree type";
            btn_degreetype.TextAlign = ContentAlignment.MiddleLeft;
            btn_degreetype.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_degreetype.UseVisualStyleBackColor = false;
            btn_degreetype.Click += btn_degreetype_Click;
            // 
            // btn_civilstatus
            // 
            btn_civilstatus.BackColor = Color.FromArgb(0, 127, 152);
            btn_civilstatus.Cursor = Cursors.Hand;
            btn_civilstatus.Dock = DockStyle.Top;
            btn_civilstatus.FlatAppearance.BorderSize = 0;
            btn_civilstatus.FlatStyle = FlatStyle.Flat;
            btn_civilstatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_civilstatus.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_civilstatus.IconColor = Color.White;
            btn_civilstatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_civilstatus.IconSize = 20;
            btn_civilstatus.ImageAlign = ContentAlignment.MiddleLeft;
            btn_civilstatus.Location = new Point(2, 86);
            btn_civilstatus.Margin = new Padding(4, 3, 4, 3);
            btn_civilstatus.Name = "btn_civilstatus";
            btn_civilstatus.Padding = new Padding(10, 0, 0, 0);
            btn_civilstatus.Size = new Size(173, 28);
            btn_civilstatus.TabIndex = 26;
            btn_civilstatus.Tag = "Civil Status";
            btn_civilstatus.Text = "Civil Status";
            btn_civilstatus.TextAlign = ContentAlignment.MiddleLeft;
            btn_civilstatus.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_civilstatus.UseVisualStyleBackColor = false;
            btn_civilstatus.Click += btn_civilstatus_Click;
            // 
            // btn_bank
            // 
            btn_bank.BackColor = Color.FromArgb(0, 127, 152);
            btn_bank.Cursor = Cursors.Hand;
            btn_bank.Dock = DockStyle.Top;
            btn_bank.FlatAppearance.BorderSize = 0;
            btn_bank.FlatStyle = FlatStyle.Flat;
            btn_bank.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_bank.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_bank.IconColor = Color.White;
            btn_bank.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_bank.IconSize = 20;
            btn_bank.ImageAlign = ContentAlignment.MiddleLeft;
            btn_bank.Location = new Point(2, 58);
            btn_bank.Margin = new Padding(4, 3, 4, 3);
            btn_bank.Name = "btn_bank";
            btn_bank.Padding = new Padding(10, 0, 0, 0);
            btn_bank.Size = new Size(173, 28);
            btn_bank.TabIndex = 25;
            btn_bank.Tag = "Bank";
            btn_bank.Text = "Bank";
            btn_bank.TextAlign = ContentAlignment.MiddleLeft;
            btn_bank.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_bank.UseVisualStyleBackColor = false;
            btn_bank.Click += btn_bank_Click;
            // 
            // btn_barangay
            // 
            btn_barangay.BackColor = Color.FromArgb(0, 127, 152);
            btn_barangay.Cursor = Cursors.Hand;
            btn_barangay.Dock = DockStyle.Top;
            btn_barangay.FlatAppearance.BorderSize = 0;
            btn_barangay.FlatStyle = FlatStyle.Flat;
            btn_barangay.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_barangay.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_barangay.IconColor = Color.White;
            btn_barangay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_barangay.IconSize = 20;
            btn_barangay.ImageAlign = ContentAlignment.MiddleLeft;
            btn_barangay.Location = new Point(2, 30);
            btn_barangay.Margin = new Padding(4, 3, 4, 3);
            btn_barangay.Name = "btn_barangay";
            btn_barangay.Padding = new Padding(10, 0, 0, 0);
            btn_barangay.Size = new Size(173, 28);
            btn_barangay.TabIndex = 24;
            btn_barangay.Tag = "Barangay";
            btn_barangay.Text = "Barangay";
            btn_barangay.TextAlign = ContentAlignment.MiddleLeft;
            btn_barangay.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_barangay.UseVisualStyleBackColor = false;
            btn_barangay.Click += iconButton2_Click;
            // 
            // label_Headername
            // 
            label_Headername.AutoSize = true;
            label_Headername.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label_Headername.ForeColor = Color.White;
            label_Headername.Location = new Point(54, 8);
            label_Headername.Margin = new Padding(4, 0, 4, 0);
            label_Headername.Name = "label_Headername";
            label_Headername.Size = new Size(163, 30);
            label_Headername.TabIndex = 1;
            label_Headername.Text = "Global Settings";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 127, 152);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label_Headername);
            panel1.Controls.Add(iconPictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 5);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 57);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 52);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(910, 5);
            panel2.TabIndex = 10;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(0, 127, 152);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Gear;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 39;
            iconPictureBox2.Location = new Point(15, 6);
            iconPictureBox2.Margin = new Padding(4, 3, 4, 3);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(47, 39);
            iconPictureBox2.TabIndex = 2;
            iconPictureBox2.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(46, 138);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(91, 17);
            label9.TabIndex = 3;
            label9.Text = "Email Address";
            // 
            // panel_basicinfo
            // 
            panel_basicinfo.AutoScroll = true;
            panel_basicinfo.BackColor = Color.White;
            panel_basicinfo.Controls.Add(picture_logo);
            panel_basicinfo.Controls.Add(label12);
            panel_basicinfo.Controls.Add(btn_address);
            panel_basicinfo.Controls.Add(txt_fax);
            panel_basicinfo.Controls.Add(label1);
            panel_basicinfo.Controls.Add(btn_cancel);
            panel_basicinfo.Controls.Add(btn_save);
            panel_basicinfo.Controls.Add(txt_emailaddress);
            panel_basicinfo.Controls.Add(txt_completeaddress);
            panel_basicinfo.Controls.Add(txt_website);
            panel_basicinfo.Controls.Add(txt_owner);
            panel_basicinfo.Controls.Add(txt_telephone);
            panel_basicinfo.Controls.Add(label9);
            panel_basicinfo.Controls.Add(txt_organizationname);
            panel_basicinfo.Controls.Add(label11);
            panel_basicinfo.Controls.Add(label8);
            panel_basicinfo.Controls.Add(label10);
            panel_basicinfo.Controls.Add(label7);
            panel_basicinfo.Controls.Add(label6);
            panel_basicinfo.Controls.Add(iconPictureBox1);
            panel_basicinfo.Controls.Add(label2);
            panel_basicinfo.Dock = DockStyle.Fill;
            panel_basicinfo.Location = new Point(199, 63);
            panel_basicinfo.Margin = new Padding(4, 3, 4, 3);
            panel_basicinfo.Name = "panel_basicinfo";
            panel_basicinfo.Size = new Size(716, 419);
            panel_basicinfo.TabIndex = 0;
            // 
            // picture_logo
            // 
            picture_logo.BorderStyle = BorderStyle.FixedSingle;
            picture_logo.Cursor = Cursors.Hand;
            picture_logo.Location = new Point(195, 243);
            picture_logo.Margin = new Padding(4, 3, 4, 3);
            picture_logo.Name = "picture_logo";
            picture_logo.Size = new Size(507, 124);
            picture_logo.SizeMode = PictureBoxSizeMode.Zoom;
            picture_logo.TabIndex = 17;
            picture_logo.TabStop = false;
            picture_logo.Click += pictureBox2_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(46, 243);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(82, 17);
            label12.TabIndex = 16;
            label12.Text = "Official Logo";
            // 
            // btn_address
            // 
            btn_address.Location = new Point(166, 185);
            btn_address.Margin = new Padding(4, 3, 4, 3);
            btn_address.Name = "btn_address";
            btn_address.Size = new Size(26, 23);
            btn_address.TabIndex = 6;
            btn_address.Text = "...";
            btn_address.UseVisualStyleBackColor = true;
            btn_address.Click += button2_Click;
            // 
            // txt_fax
            // 
            txt_fax.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_fax.Location = new Point(485, 158);
            txt_fax.Margin = new Padding(4, 3, 4, 3);
            txt_fax.Name = "txt_fax";
            txt_fax.Size = new Size(218, 23);
            txt_fax.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(433, 162);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 13;
            label1.Text = "Fax";
            // 
            // txt_organizationname
            // 
            txt_organizationname.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_organizationname.Location = new Point(195, 58);
            txt_organizationname.Margin = new Padding(4, 3, 4, 3);
            txt_organizationname.Name = "txt_organizationname";
            txt_organizationname.Size = new Size(507, 23);
            txt_organizationname.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(46, 188);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(116, 17);
            label11.TabIndex = 3;
            label11.Text = "Complete Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(46, 111);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(54, 17);
            label8.TabIndex = 2;
            label8.Text = "Website";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(46, 162);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(68, 17);
            label10.TabIndex = 2;
            label10.Text = "Telephone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(46, 84);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(46, 17);
            label7.TabIndex = 3;
            label7.Text = "Owner";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(46, 59);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 17);
            label6.TabIndex = 2;
            label6.Text = "Organization name";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 31;
            iconPictureBox1.Location = new Point(10, 18);
            iconPictureBox1.Margin = new Padding(4, 3, 4, 3);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(31, 32);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(38, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(267, 32);
            label2.TabIndex = 0;
            label2.Text = "Company Information";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "Choose Image";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // MaintenanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(920, 487);
            Controls.Add(panel_basicinfo);
            Controls.Add(MainPanel);
            Controls.Add(panel4);
            Controls.Add(panelmenu);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(900, 501);
            Name = "MaintenanceForm";
            Padding = new Padding(5);
            StartPosition = FormStartPosition.CenterParent;
            Text = "MaintenanceForm";
            Load += MaintenanceForm_Load;
            panelmenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            panel_basicinfo.ResumeLayout(false);
            panel_basicinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_cancel;
        private Button btn_save;
        private TextBox txt_emailaddress;
        private TextBox txt_completeaddress;
        private Panel MainPanel;
        private Panel panel4;
        private TextBox txt_website;
        private TextBox txt_owner;
        private TextBox txt_telephone;
        private FontAwesome.Sharp.IconButton btn_basicinformation;
        private Panel panelmenu;
        private Label label_Headername;
        private Panel panel1;
        private Label label9;
        private Panel panel_basicinfo;
        private TextBox txt_fax;
        private Label label1;
        private TextBox txt_organizationname;
        private Label label11;
        private Label label8;
        private Label label10;
        private Label label7;
        private Label label6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label2;
        private Button btn_address;
        private PictureBox picture_logo;
        private Label label12;
        private OpenFileDialog openFileDialog1;
        private FontAwesome.Sharp.IconButton btn_position;
        private FontAwesome.Sharp.IconButton btn_offencetype;
        private FontAwesome.Sharp.IconButton btn_licenseType;
        private FontAwesome.Sharp.IconButton btn_leaveType;
        private FontAwesome.Sharp.IconButton btn_leavenoticeType;
        private FontAwesome.Sharp.IconButton btn_employmenttype;
        private FontAwesome.Sharp.IconButton btn_educationalLevel;
        private FontAwesome.Sharp.IconButton btn_documenttype;
        private FontAwesome.Sharp.IconButton btn_disciplinary;
        private FontAwesome.Sharp.IconButton btn_department;
        private FontAwesome.Sharp.IconButton btn_degreetype;
        private FontAwesome.Sharp.IconButton btn_civilstatus;
        private FontAwesome.Sharp.IconButton btn_bank;
        private FontAwesome.Sharp.IconButton btn_barangay;
        private FontAwesome.Sharp.IconButton btn_;
        private FontAwesome.Sharp.IconButton btn_towncity;
        private FontAwesome.Sharp.IconButton btn_salarysetting;
        private FontAwesome.Sharp.IconButton btn_religion;
        private FontAwesome.Sharp.IconButton btn_province;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btn_nationality;
        private FontAwesome.Sharp.IconButton btn_relationship;
    }
}