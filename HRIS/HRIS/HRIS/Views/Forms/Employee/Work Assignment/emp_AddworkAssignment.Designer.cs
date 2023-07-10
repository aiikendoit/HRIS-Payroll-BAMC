namespace HRIS.Forms.Employee.Work_Assignment
{
    partial class emp_AddworkAssignment
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
            panel2 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            txt_enddate = new DateTimePicker();
            btn_cancel = new Button();
            btn_save = new Button();
            txt_department = new ComboBox();
            txt_jobscope = new TextBox();
            label22 = new Label();
            label19 = new Label();
            label18 = new Label();
            label3 = new Label();
            txt_position = new ComboBox();
            label4 = new Label();
            txt_jobdescription = new TextBox();
            label5 = new Label();
            txt_reponsibilities = new TextBox();
            label1 = new Label();
            txt_startdate = new DateTimePicker();
            checkBox_ishead = new CheckBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(402, 40);
            panel2.TabIndex = 34;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(11, 5);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 8);
            label2.Name = "label2";
            label2.Size = new Size(215, 25);
            label2.TabIndex = 2;
            label2.Text = "New Work Assignment";
            // 
            // txt_enddate
            // 
            txt_enddate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_enddate.Format = DateTimePickerFormat.Short;
            txt_enddate.Location = new Point(117, 337);
            txt_enddate.Name = "txt_enddate";
            txt_enddate.Size = new Size(270, 25);
            txt_enddate.TabIndex = 44;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.Transparent;
            btn_cancel.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 152);
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(296, 372);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(91, 36);
            btn_cancel.TabIndex = 43;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(0, 127, 152);
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(199, 372);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(91, 36);
            btn_save.TabIndex = 42;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // txt_department
            // 
            txt_department.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_department.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_department.FormattingEnabled = true;
            txt_department.Location = new Point(117, 46);
            txt_department.Name = "txt_department";
            txt_department.Size = new Size(270, 25);
            txt_department.TabIndex = 41;
            txt_department.SelectedIndexChanged += txt_department_SelectedIndexChanged;
            // 
            // txt_jobscope
            // 
            txt_jobscope.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_jobscope.Location = new Point(117, 220);
            txt_jobscope.Multiline = true;
            txt_jobscope.Name = "txt_jobscope";
            txt_jobscope.Size = new Size(270, 50);
            txt_jobscope.TabIndex = 40;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(14, 340);
            label22.Name = "label22";
            label22.Size = new Size(60, 17);
            label22.TabIndex = 38;
            label22.Text = "End date";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(14, 49);
            label19.Name = "label19";
            label19.Size = new Size(77, 17);
            label19.TabIndex = 35;
            label19.Text = "Department";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(14, 223);
            label18.Name = "label18";
            label18.Size = new Size(69, 17);
            label18.TabIndex = 37;
            label18.Text = "Job Scope";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 80);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 35;
            label3.Text = "Position";
            // 
            // txt_position
            // 
            txt_position.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_position.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_position.FormattingEnabled = true;
            txt_position.Location = new Point(117, 77);
            txt_position.Name = "txt_position";
            txt_position.Size = new Size(270, 25);
            txt_position.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(14, 111);
            label4.Name = "label4";
            label4.Size = new Size(99, 17);
            label4.TabIndex = 37;
            label4.Text = "Job Description";
            // 
            // txt_jobdescription
            // 
            txt_jobdescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_jobdescription.Location = new Point(117, 108);
            txt_jobdescription.Multiline = true;
            txt_jobdescription.Name = "txt_jobdescription";
            txt_jobdescription.Size = new Size(270, 50);
            txt_jobdescription.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(14, 167);
            label5.Name = "label5";
            label5.Size = new Size(98, 17);
            label5.TabIndex = 37;
            label5.Text = "Responsibilities";
            // 
            // txt_reponsibilities
            // 
            txt_reponsibilities.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_reponsibilities.Location = new Point(117, 164);
            txt_reponsibilities.Multiline = true;
            txt_reponsibilities.Name = "txt_reponsibilities";
            txt_reponsibilities.Size = new Size(270, 50);
            txt_reponsibilities.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 309);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 38;
            label1.Text = "Start date";
            // 
            // txt_startdate
            // 
            txt_startdate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_startdate.Format = DateTimePickerFormat.Short;
            txt_startdate.Location = new Point(117, 306);
            txt_startdate.Name = "txt_startdate";
            txt_startdate.Size = new Size(270, 25);
            txt_startdate.TabIndex = 44;
            // 
            // checkBox_ishead
            // 
            checkBox_ishead.AutoSize = true;
            checkBox_ishead.Location = new Point(117, 278);
            checkBox_ishead.Name = "checkBox_ishead";
            checkBox_ishead.Size = new Size(54, 19);
            checkBox_ishead.TabIndex = 45;
            checkBox_ishead.Text = "Head";
            checkBox_ishead.UseVisualStyleBackColor = true;
            // 
            // emp_AddworkAssignment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(402, 424);
            Controls.Add(checkBox_ishead);
            Controls.Add(panel2);
            Controls.Add(txt_startdate);
            Controls.Add(txt_enddate);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(txt_position);
            Controls.Add(txt_department);
            Controls.Add(txt_jobdescription);
            Controls.Add(txt_reponsibilities);
            Controls.Add(label1);
            Controls.Add(txt_jobscope);
            Controls.Add(label22);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label19);
            Controls.Add(label18);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "emp_AddworkAssignment";
            StartPosition = FormStartPosition.CenterParent;
            Load += emp_AddworkAssignment_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label2;
        private DateTimePicker txt_enddate;
        private Button btn_cancel;
        private Button btn_save;
        private ComboBox txt_department;
        private TextBox txt_jobscope;
        private Label label22;
        private Label label19;
        private Label label18;
        private Label label3;
        private ComboBox txt_position;
        private Label label4;
        private TextBox txt_jobdescription;
        private Label label5;
        private TextBox txt_reponsibilities;
        private Label label1;
        private DateTimePicker txt_startdate;
        private CheckBox checkBox_ishead;
    }
}