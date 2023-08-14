namespace HRIS.Forms.Employee.License_information
{
    partial class emp_AddLicense
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
            btn_cancel = new Button();
            btn_save = new Button();
            txt_licensetype = new ComboBox();
            txt_expiryreminder = new TextBox();
            txt_licensenumber = new TextBox();
            label22 = new Label();
            label1 = new Label();
            label19 = new Label();
            label18 = new Label();
            txt_expirydate = new DateTimePicker();
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
            panel2.Size = new Size(399, 40);
            panel2.TabIndex = 20;
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
            label2.Size = new Size(121, 25);
            label2.TabIndex = 2;
            label2.Text = "New License";
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.Transparent;
            btn_cancel.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 152);
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(292, 239);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(91, 36);
            btn_cancel.TabIndex = 5;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(0, 127, 152);
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(195, 239);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(91, 36);
            btn_save.TabIndex = 4;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // txt_licensetype
            // 
            txt_licensetype.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_licensetype.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_licensetype.FormattingEnabled = true;
            txt_licensetype.Location = new Point(154, 56);
            txt_licensetype.Name = "txt_licensetype";
            txt_licensetype.Size = new Size(229, 25);
            txt_licensetype.TabIndex = 0;
            // 
            // txt_expiryreminder
            // 
            txt_expiryreminder.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_expiryreminder.Location = new Point(154, 174);
            txt_expiryreminder.Multiline = true;
            txt_expiryreminder.Name = "txt_expiryreminder";
            txt_expiryreminder.Size = new Size(229, 50);
            txt_expiryreminder.TabIndex = 3;
            // 
            // txt_licensenumber
            // 
            txt_licensenumber.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_licensenumber.Location = new Point(154, 87);
            txt_licensenumber.Multiline = true;
            txt_licensenumber.Name = "txt_licensenumber";
            txt_licensenumber.Size = new Size(229, 50);
            txt_licensenumber.TabIndex = 1;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(51, 146);
            label22.Name = "label22";
            label22.Size = new Size(73, 17);
            label22.TabIndex = 25;
            label22.Text = "Expiry date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 177);
            label1.Name = "label1";
            label1.Size = new Size(100, 17);
            label1.TabIndex = 22;
            label1.Text = "Expiry reminder";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(51, 59);
            label19.Name = "label19";
            label19.Size = new Size(79, 17);
            label19.TabIndex = 21;
            label19.Text = "License type";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(51, 90);
            label18.Name = "label18";
            label18.Size = new Size(62, 17);
            label18.TabIndex = 23;
            label18.Text = "License #";
            // 
            // txt_expirydate
            // 
            txt_expirydate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_expirydate.Format = DateTimePickerFormat.Short;
            txt_expirydate.Location = new Point(154, 143);
            txt_expirydate.Name = "txt_expirydate";
            txt_expirydate.Size = new Size(229, 25);
            txt_expirydate.TabIndex = 2;
            // 
            // emp_AddLicense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(399, 293);
            Controls.Add(txt_expirydate);
            Controls.Add(panel2);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(txt_licensetype);
            Controls.Add(txt_expiryreminder);
            Controls.Add(txt_licensenumber);
            Controls.Add(label22);
            Controls.Add(label1);
            Controls.Add(label19);
            Controls.Add(label18);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "emp_AddLicense";
            StartPosition = FormStartPosition.CenterParent;
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
        private Button btn_cancel;
        private Button btn_save;
        private ComboBox txt_licensetype;
        private TextBox txt_expiryreminder;
        private TextBox txt_licensenumber;
        private Label label22;
        private Label label1;
        private Label label19;
        private Label label18;
        private DateTimePicker txt_expirydate;
    }
}