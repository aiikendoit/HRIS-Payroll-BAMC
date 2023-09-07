namespace HRIS.Forms.Employee.License_information
{
    partial class emp_licenseInfoForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            ID = new DataGridViewTextBoxColumn();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            label2 = new Label();
            txt_totalcount = new Label();
            panel1 = new Panel();
            dgrid_license = new DataGridView();
            txt_search = new TextBox();
            btn_search = new FontAwesome.Sharp.IconButton();
            btn_refresh = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_new = new FontAwesome.Sharp.IconButton();
            btn_edit = new FontAwesome.Sharp.IconButton();
            btn_view = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btn_delete = new FontAwesome.Sharp.IconButton();
            LicenseID = new DataGridViewTextBoxColumn();
            LicenseType = new DataGridViewTextBoxColumn();
            LicenseNumber = new DataGridViewTextBoxColumn();
            ExpiryDate = new DataGridViewTextBoxColumn();
            ExpiryReminder = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_license).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(11, 7);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 40);
            panel2.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 5);
            label2.Name = "label2";
            label2.Size = new Size(242, 32);
            label2.TabIndex = 2;
            label2.Text = "License Information";
            // 
            // txt_totalcount
            // 
            txt_totalcount.AutoSize = true;
            txt_totalcount.ForeColor = Color.Black;
            txt_totalcount.Location = new Point(5, 6);
            txt_totalcount.Name = "txt_totalcount";
            txt_totalcount.Size = new Size(94, 15);
            txt_totalcount.TabIndex = 0;
            txt_totalcount.Text = "Total record(s): 0";
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_totalcount);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 423);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 27);
            panel1.TabIndex = 14;
            // 
            // dgrid_license
            // 
            dgrid_license.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.IndianRed;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgrid_license.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgrid_license.ColumnHeadersHeight = 50;
            dgrid_license.Columns.AddRange(new DataGridViewColumn[] { LicenseID, LicenseType, LicenseNumber, ExpiryDate, ExpiryReminder });
            dgrid_license.Dock = DockStyle.Fill;
            dgrid_license.Location = new Point(0, 111);
            dgrid_license.Name = "dgrid_license";
            dgrid_license.RowTemplate.Height = 25;
            dgrid_license.Size = new Size(800, 312);
            dgrid_license.TabIndex = 13;
            dgrid_license.CellFormatting += dgrid_license_CellFormatting;
            // 
            // txt_search
            // 
            txt_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(3, 3);
            txt_search.Margin = new Padding(3, 3, 1, 3);
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = " Search";
            txt_search.Size = new Size(338, 29);
            txt_search.TabIndex = 0;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.FromArgb(0, 127, 152);
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.ForeColor = Color.White;
            btn_search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btn_search.IconColor = Color.White;
            btn_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_search.IconSize = 20;
            btn_search.Location = new Point(343, 3);
            btn_search.Margin = new Padding(1, 3, 1, 3);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(77, 29);
            btn_search.TabIndex = 1;
            btn_search.Text = "Search";
            btn_search.TextAlign = ContentAlignment.MiddleLeft;
            btn_search.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // btn_refresh
            // 
            btn_refresh.BackColor = Color.FromArgb(0, 127, 152);
            btn_refresh.FlatAppearance.BorderSize = 0;
            btn_refresh.FlatStyle = FlatStyle.Flat;
            btn_refresh.ForeColor = Color.White;
            btn_refresh.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            btn_refresh.IconColor = Color.White;
            btn_refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_refresh.IconSize = 20;
            btn_refresh.Location = new Point(422, 3);
            btn_refresh.Margin = new Padding(1, 3, 1, 3);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(77, 29);
            btn_refresh.TabIndex = 2;
            btn_refresh.Text = "Refresh";
            btn_refresh.TextAlign = ContentAlignment.MiddleLeft;
            btn_refresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(txt_search);
            flowLayoutPanel1.Controls.Add(btn_search);
            flowLayoutPanel1.Controls.Add(btn_refresh);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 40);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 35);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // btn_new
            // 
            btn_new.BackColor = Color.FromArgb(0, 127, 152);
            btn_new.FlatAppearance.BorderSize = 0;
            btn_new.FlatStyle = FlatStyle.Flat;
            btn_new.ForeColor = Color.White;
            btn_new.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btn_new.IconColor = Color.White;
            btn_new.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_new.IconSize = 20;
            btn_new.Location = new Point(3, 3);
            btn_new.Margin = new Padding(3, 3, 1, 3);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(73, 30);
            btn_new.TabIndex = 4;
            btn_new.Text = "New";
            btn_new.TextAlign = ContentAlignment.MiddleLeft;
            btn_new.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_new.UseVisualStyleBackColor = false;
            btn_new.Click += btn_new_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.FromArgb(0, 127, 152);
            btn_edit.FlatAppearance.BorderSize = 0;
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.ForeColor = Color.White;
            btn_edit.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            btn_edit.IconColor = Color.White;
            btn_edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_edit.IconSize = 20;
            btn_edit.Location = new Point(78, 3);
            btn_edit.Margin = new Padding(1, 3, 1, 3);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(73, 30);
            btn_edit.TabIndex = 5;
            btn_edit.Text = "Edit";
            btn_edit.TextAlign = ContentAlignment.MiddleLeft;
            btn_edit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_view
            // 
            btn_view.BackColor = Color.FromArgb(0, 127, 152);
            btn_view.FlatAppearance.BorderSize = 0;
            btn_view.FlatStyle = FlatStyle.Flat;
            btn_view.ForeColor = Color.White;
            btn_view.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btn_view.IconColor = Color.White;
            btn_view.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_view.IconSize = 20;
            btn_view.Location = new Point(153, 3);
            btn_view.Margin = new Padding(1, 3, 1, 3);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(73, 30);
            btn_view.TabIndex = 6;
            btn_view.Text = "View";
            btn_view.TextAlign = ContentAlignment.MiddleLeft;
            btn_view.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_view.UseVisualStyleBackColor = false;
            btn_view.Click += btn_view_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btn_new);
            flowLayoutPanel2.Controls.Add(btn_edit);
            flowLayoutPanel2.Controls.Add(btn_view);
            flowLayoutPanel2.Controls.Add(btn_delete);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 75);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(800, 36);
            flowLayoutPanel2.TabIndex = 12;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.FromArgb(255, 43, 43);
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.ForeColor = Color.White;
            btn_delete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btn_delete.IconColor = Color.White;
            btn_delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_delete.IconSize = 20;
            btn_delete.Location = new Point(228, 3);
            btn_delete.Margin = new Padding(1, 3, 1, 3);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(73, 30);
            btn_delete.TabIndex = 7;
            btn_delete.Text = "Delete";
            btn_delete.TextAlign = ContentAlignment.MiddleLeft;
            btn_delete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // LicenseID
            // 
            LicenseID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            LicenseID.HeaderText = "Code";
            LicenseID.Name = "LicenseID";
            LicenseID.Width = 80;
            // 
            // LicenseType
            // 
            LicenseType.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            LicenseType.HeaderText = "License Type";
            LicenseType.Name = "LicenseType";
            LicenseType.Width = 150;
            // 
            // LicenseNumber
            // 
            LicenseNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            LicenseNumber.HeaderText = "License #";
            LicenseNumber.Name = "LicenseNumber";
            // 
            // ExpiryDate
            // 
            ExpiryDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ExpiryDate.HeaderText = "Expiry Date";
            ExpiryDate.Name = "ExpiryDate";
            // 
            // ExpiryReminder
            // 
            ExpiryReminder.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ExpiryReminder.HeaderText = "Remarks";
            ExpiryReminder.Name = "ExpiryReminder";
            // 
            // emp_licenseInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(dgrid_license);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Name = "emp_licenseInfoForm";
            Text = "emp_licenseInfoForm";
            Load += emp_licenseInfoForm_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_license).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewTextBoxColumn ID;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel2;
        private Label label2;
        private Label txt_totalcount;
        private Panel panel1;
        private DataGridView dgrid_license;
        private TextBox txt_search;
        private FontAwesome.Sharp.IconButton btn_search;
        private FontAwesome.Sharp.IconButton btn_refresh;
        private FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton btn_new;
        private FontAwesome.Sharp.IconButton btn_edit;
        private FontAwesome.Sharp.IconButton btn_view;
        private FlowLayoutPanel flowLayoutPanel2;
        private FontAwesome.Sharp.IconButton btn_delete;
        private DataGridViewTextBoxColumn LicenseID;
        private DataGridViewTextBoxColumn LicenseType;
        private DataGridViewTextBoxColumn LicenseNumber;
        private DataGridViewTextBoxColumn ExpiryDate;
        private DataGridViewTextBoxColumn ExpiryReminder;
    }
}