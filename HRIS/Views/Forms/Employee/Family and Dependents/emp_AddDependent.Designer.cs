namespace HRIS.Forms.Employee.Family_and_Dependents
{
    partial class emp_AddDependent
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
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            txt_Lastname = new TextBox();
            panel2 = new Panel();
            txt_BDate = new DateTimePicker();
            btn_Cancel = new Button();
            btn_Save = new Button();
            txt_relationshipcombo = new ComboBox();
            label22 = new Label();
            label3 = new Label();
            label19 = new Label();
            label1 = new Label();
            txt_Firstname = new TextBox();
            label4 = new Label();
            txt_Middlename = new TextBox();
            label5 = new Label();
            txt_civilstatuscombo = new ComboBox();
            label6 = new Label();
            txt_Contactnumber = new TextBox();
            combo_QD = new CheckBox();
            label7 = new Label();
            txt_Suffixname = new TextBox();
            txt_address = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
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
            label2.Size = new Size(156, 25);
            label2.TabIndex = 2;
            label2.Text = "New Dependent";
            // 
            // txt_Lastname
            // 
            txt_Lastname.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Lastname.Location = new Point(174, 48);
            txt_Lastname.Name = "txt_Lastname";
            txt_Lastname.Size = new Size(255, 25);
            txt_Lastname.TabIndex = 67;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 40);
            panel2.TabIndex = 57;
            // 
            // txt_BDate
            // 
            txt_BDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_BDate.Format = DateTimePickerFormat.Short;
            txt_BDate.Location = new Point(174, 172);
            txt_BDate.Name = "txt_BDate";
            txt_BDate.Size = new Size(255, 25);
            txt_BDate.TabIndex = 66;
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = Color.Transparent;
            btn_Cancel.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 152);
            btn_Cancel.FlatStyle = FlatStyle.Flat;
            btn_Cancel.Location = new Point(338, 426);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(91, 36);
            btn_Cancel.TabIndex = 65;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            btn_Save.BackColor = Color.FromArgb(0, 127, 152);
            btn_Save.FlatAppearance.BorderSize = 0;
            btn_Save.FlatStyle = FlatStyle.Flat;
            btn_Save.ForeColor = Color.White;
            btn_Save.Location = new Point(241, 426);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(91, 36);
            btn_Save.TabIndex = 64;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = false;
            btn_Save.Click += button3_Click;
            // 
            // txt_relationshipcombo
            // 
            txt_relationshipcombo.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_relationshipcombo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_relationshipcombo.FormattingEnabled = true;
            txt_relationshipcombo.Location = new Point(174, 203);
            txt_relationshipcombo.Name = "txt_relationshipcombo";
            txt_relationshipcombo.Size = new Size(255, 25);
            txt_relationshipcombo.TabIndex = 63;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(50, 175);
            label22.Name = "label22";
            label22.Size = new Size(60, 17);
            label22.TabIndex = 61;
            label22.Text = "Birthdate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(50, 51);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 58;
            label3.Text = "Last Name";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(50, 206);
            label19.Name = "label19";
            label19.Size = new Size(79, 17);
            label19.TabIndex = 59;
            label19.Text = "Relationship";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 82);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 58;
            label1.Text = "First Name";
            // 
            // txt_Firstname
            // 
            txt_Firstname.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Firstname.Location = new Point(174, 79);
            txt_Firstname.Name = "txt_Firstname";
            txt_Firstname.Size = new Size(255, 25);
            txt_Firstname.TabIndex = 67;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(50, 113);
            label4.Name = "label4";
            label4.Size = new Size(88, 17);
            label4.TabIndex = 58;
            label4.Text = "Middle Name";
            // 
            // txt_Middlename
            // 
            txt_Middlename.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Middlename.Location = new Point(174, 110);
            txt_Middlename.Name = "txt_Middlename";
            txt_Middlename.Size = new Size(255, 25);
            txt_Middlename.TabIndex = 67;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(50, 237);
            label5.Name = "label5";
            label5.Size = new Size(70, 17);
            label5.TabIndex = 59;
            label5.Text = "Civil Status";
            // 
            // txt_civilstatuscombo
            // 
            txt_civilstatuscombo.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_civilstatuscombo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_civilstatuscombo.FormattingEnabled = true;
            txt_civilstatuscombo.Location = new Point(174, 234);
            txt_civilstatuscombo.Name = "txt_civilstatuscombo";
            txt_civilstatuscombo.Size = new Size(255, 25);
            txt_civilstatuscombo.TabIndex = 63;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(50, 268);
            label6.Name = "label6";
            label6.Size = new Size(104, 17);
            label6.TabIndex = 58;
            label6.Text = "Contact Number";
            // 
            // txt_Contactnumber
            // 
            txt_Contactnumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Contactnumber.Location = new Point(174, 265);
            txt_Contactnumber.Name = "txt_Contactnumber";
            txt_Contactnumber.Size = new Size(255, 25);
            txt_Contactnumber.TabIndex = 67;
            // 
            // combo_QD
            // 
            combo_QD.AutoSize = true;
            combo_QD.Location = new Point(174, 375);
            combo_QD.Name = "combo_QD";
            combo_QD.Size = new Size(135, 19);
            combo_QD.TabIndex = 68;
            combo_QD.Text = "Qualified Dependent";
            combo_QD.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(50, 144);
            label7.Name = "label7";
            label7.Size = new Size(39, 17);
            label7.TabIndex = 58;
            label7.Text = "Suffix";
            // 
            // txt_Suffixname
            // 
            txt_Suffixname.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Suffixname.Location = new Point(174, 141);
            txt_Suffixname.Name = "txt_Suffixname";
            txt_Suffixname.Size = new Size(141, 25);
            txt_Suffixname.TabIndex = 67;
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_address.Location = new Point(174, 296);
            txt_address.Multiline = true;
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(254, 73);
            txt_address.TabIndex = 69;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(50, 299);
            label8.Name = "label8";
            label8.Size = new Size(56, 17);
            label8.TabIndex = 70;
            label8.Text = "Address";
            // 
            // emp_AddDependent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(440, 473);
            Controls.Add(label8);
            Controls.Add(txt_address);
            Controls.Add(combo_QD);
            Controls.Add(txt_Suffixname);
            Controls.Add(txt_Middlename);
            Controls.Add(txt_Firstname);
            Controls.Add(txt_Contactnumber);
            Controls.Add(txt_Lastname);
            Controls.Add(panel2);
            Controls.Add(txt_BDate);
            Controls.Add(btn_Cancel);
            Controls.Add(label7);
            Controls.Add(btn_Save);
            Controls.Add(label4);
            Controls.Add(txt_civilstatuscombo);
            Controls.Add(txt_relationshipcombo);
            Controls.Add(label1);
            Controls.Add(label22);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label19);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "emp_AddDependent";
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label2;
        private TextBox txt_Lastname;
        private Panel panel2;
        private DateTimePicker txt_BDate;
        private Button btn_Cancel;
        private Button btn_Save;
        private ComboBox txt_relationshipcombo;
        private Label label22;
        private Label label3;
        private Label label19;
        private Label label1;
        private TextBox txt_Firstname;
        private Label label4;
        private TextBox txt_Middlename;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox txt_Contactnumber;
        private CheckBox combo_QD;
        private Label label7;
        private TextBox txt_Suffixname;
        private TextBox txt_address;
        private Label label8;
        private ComboBox txt_civilstatuscombo;
    }
}