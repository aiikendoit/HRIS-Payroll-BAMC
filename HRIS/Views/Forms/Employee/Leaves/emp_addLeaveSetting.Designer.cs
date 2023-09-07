namespace HRIS.Forms.Employee.Leaves
{
    partial class emp_addLeaveSetting
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
            label_header = new Label();
            btn_cancel = new Button();
            btn_save = new Button();
            txt_leavetype = new ComboBox();
            txt_remarks = new TextBox();
            label22 = new Label();
            label1 = new Label();
            label19 = new Label();
            txt_daysperyear = new TextBox();
            label3 = new Label();
            txt_effectivitydate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(label_header);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(456, 40);
            panel2.TabIndex = 45;
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
            // label_header
            // 
            label_header.AutoSize = true;
            label_header.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label_header.Location = new Point(46, 8);
            label_header.Name = "label_header";
            label_header.Size = new Size(176, 25);
            label_header.TabIndex = 2;
            label_header.Text = "New Leave Setting";
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.Transparent;
            btn_cancel.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 152);
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(362, 211);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(80, 36);
            btn_cancel.TabIndex = 53;
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
            btn_save.Location = new Point(276, 211);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(80, 36);
            btn_save.TabIndex = 52;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // txt_leavetype
            // 
            txt_leavetype.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_leavetype.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_leavetype.FormattingEnabled = true;
            txt_leavetype.Location = new Point(173, 55);
            txt_leavetype.Name = "txt_leavetype";
            txt_leavetype.Size = new Size(269, 25);
            txt_leavetype.TabIndex = 51;
            // 
            // txt_remarks
            // 
            txt_remarks.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_remarks.Location = new Point(173, 146);
            txt_remarks.Multiline = true;
            txt_remarks.Name = "txt_remarks";
            txt_remarks.Size = new Size(269, 50);
            txt_remarks.TabIndex = 50;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(49, 123);
            label22.Name = "label22";
            label22.Size = new Size(92, 17);
            label22.TabIndex = 49;
            label22.Text = "Effectivity date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(49, 149);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 47;
            label1.Text = "Remarks";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(49, 58);
            label19.Name = "label19";
            label19.Size = new Size(70, 17);
            label19.TabIndex = 46;
            label19.Text = "Leave type";
            // 
            // txt_daysperyear
            // 
            txt_daysperyear.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_daysperyear.Location = new Point(173, 86);
            txt_daysperyear.Name = "txt_daysperyear";
            txt_daysperyear.PlaceholderText = "0";
            txt_daysperyear.Size = new Size(143, 25);
            txt_daysperyear.TabIndex = 56;
            txt_daysperyear.Text = "0";
            txt_daysperyear.TextChanged += txt_daysperyear_TextChanged;
            txt_daysperyear.Enter += txt_daysperyear_Enter;
            txt_daysperyear.KeyDown += txt_daysperyear_KeyDown;
            txt_daysperyear.KeyPress += textBox2_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(49, 89);
            label3.Name = "label3";
            label3.Size = new Size(120, 17);
            label3.TabIndex = 46;
            label3.Text = "Total Days Per Year";
            // 
            // txt_effectivitydate
            // 
            txt_effectivitydate.AllowNull = true;
            txt_effectivitydate.Location = new Point(173, 117);
            txt_effectivitydate.Name = "txt_effectivitydate";
            txt_effectivitydate.Size = new Size(143, 23);
            txt_effectivitydate.TabIndex = 57;
            txt_effectivitydate.Value = null;
            txt_effectivitydate.Watermark = "Select a date";
            // 
            // emp_addLeaveSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(456, 268);
            Controls.Add(txt_effectivitydate);
            Controls.Add(txt_daysperyear);
            Controls.Add(panel2);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(txt_leavetype);
            Controls.Add(txt_remarks);
            Controls.Add(label22);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label19);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "emp_addLeaveSetting";
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
        private Label label_header;
        private Button btn_cancel;
        private Button btn_save;
        private ComboBox txt_leavetype;
        private TextBox txt_remarks;
        private Label label22;
        private Label label1;
        private Label label19;
        private TextBox txt_daysperyear;
        private Label label3;
        private Syncfusion.WinForms.Input.SfDateTimeEdit txt_effectivitydate;
    }
}