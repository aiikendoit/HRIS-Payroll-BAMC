namespace HRIS.Forms.Employee.Employment
{
    partial class emp_AddEmployment
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
            txt_employmenttype = new ComboBox();
            txt_remarks = new TextBox();
            label22 = new Label();
            label1 = new Label();
            label19 = new Label();
            label3 = new Label();
            txt_enddate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            txt_startdate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
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
            panel2.Size = new Size(408, 40);
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
            label2.Size = new Size(169, 25);
            label2.TabIndex = 2;
            label2.Text = "New Employment";
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.Transparent;
            btn_cancel.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 152);
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(304, 211);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(91, 36);
            btn_cancel.TabIndex = 43;
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
            btn_save.Location = new Point(207, 211);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(91, 36);
            btn_save.TabIndex = 42;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // txt_employmenttype
            // 
            txt_employmenttype.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_employmenttype.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_employmenttype.FormattingEnabled = true;
            txt_employmenttype.Location = new Point(166, 55);
            txt_employmenttype.Name = "txt_employmenttype";
            txt_employmenttype.Size = new Size(229, 25);
            txt_employmenttype.TabIndex = 41;
            // 
            // txt_remarks
            // 
            txt_remarks.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_remarks.Location = new Point(166, 146);
            txt_remarks.Multiline = true;
            txt_remarks.Name = "txt_remarks";
            txt_remarks.Size = new Size(229, 50);
            txt_remarks.TabIndex = 39;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(51, 118);
            label22.Name = "label22";
            label22.Size = new Size(60, 17);
            label22.TabIndex = 38;
            label22.Text = "End date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 149);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 36;
            label1.Text = "Remarks";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(53, 58);
            label19.Name = "label19";
            label19.Size = new Size(109, 17);
            label19.TabIndex = 35;
            label19.Text = "Employment type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(51, 89);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 38;
            label3.Text = "Start date";
            // 
            // txt_enddate
            // 
            txt_enddate.AllowNull = true;
            txt_enddate.Location = new Point(166, 115);
            txt_enddate.Name = "txt_enddate";
            txt_enddate.Size = new Size(143, 23);
            txt_enddate.TabIndex = 45;
            txt_enddate.ToolTipText = "";
            txt_enddate.Watermark = "Select a date";
            // 
            // txt_startdate
            // 
            txt_startdate.AllowNull = true;
            txt_startdate.Location = new Point(166, 86);
            txt_startdate.Name = "txt_startdate";
            txt_startdate.Size = new Size(143, 23);
            txt_startdate.TabIndex = 45;
            txt_startdate.ToolTipText = "";
            txt_startdate.Watermark = "Select a date";
            // 
            // emp_AddEmployment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(408, 258);
            Controls.Add(txt_startdate);
            Controls.Add(txt_enddate);
            Controls.Add(panel2);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(txt_employmenttype);
            Controls.Add(label3);
            Controls.Add(txt_remarks);
            Controls.Add(label22);
            Controls.Add(label1);
            Controls.Add(label19);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "emp_AddEmployment";
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
        private ComboBox txt_employmenttype;
        private TextBox txt_remarks;
        private Label label22;
        private Label label1;
        private Label label19;
        private Label label3;
        private Syncfusion.WinForms.Input.SfDateTimeEdit txt_enddate;
        private Syncfusion.WinForms.Input.SfDateTimeEdit txt_startdate;
    }
}