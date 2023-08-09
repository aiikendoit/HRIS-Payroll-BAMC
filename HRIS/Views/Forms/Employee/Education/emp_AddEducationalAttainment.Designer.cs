namespace HRIS.Forms.Employee.Education
{
    partial class emp_AddEducationalAttainment
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
            txt_educationalAttainment = new ComboBox();
            txt_schoolattended = new TextBox();
            label22 = new Label();
            label19 = new Label();
            label18 = new Label();
            label1 = new Label();
            txt_educationaldegree = new TextBox();
            label3 = new Label();
            txt_degreetype = new ComboBox();
            btn_cancel = new Button();
            btn_save = new Button();
            txt_yeargraduated = new DateTimePicker();
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
            panel2.Size = new Size(434, 40);
            panel2.TabIndex = 11;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
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
            label2.Size = new Size(266, 25);
            label2.TabIndex = 2;
            label2.Text = "New Educational Attainment";
            // 
            // txt_educationalAttainment
            // 
            txt_educationalAttainment.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_educationalAttainment.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_educationalAttainment.FormattingEnabled = true;
            txt_educationalAttainment.Location = new Point(182, 55);
            txt_educationalAttainment.Name = "txt_educationalAttainment";
            txt_educationalAttainment.Size = new Size(240, 25);
            txt_educationalAttainment.TabIndex = 0;
            // 
            // txt_schoolattended
            // 
            txt_schoolattended.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_schoolattended.Location = new Point(182, 89);
            txt_schoolattended.Multiline = true;
            txt_schoolattended.Name = "txt_schoolattended";
            txt_schoolattended.Size = new Size(240, 50);
            txt_schoolattended.TabIndex = 1;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(35, 145);
            label22.Name = "label22";
            label22.Size = new Size(99, 17);
            label22.TabIndex = 14;
            label22.Text = "Year Graduated";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(35, 58);
            label19.Name = "label19";
            label19.Size = new Size(141, 17);
            label19.TabIndex = 12;
            label19.Text = "Educational Attainment";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(35, 89);
            label18.Name = "label18";
            label18.Size = new Size(104, 17);
            label18.TabIndex = 13;
            label18.Text = "School Attended";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 176);
            label1.Name = "label1";
            label1.Size = new Size(122, 17);
            label1.TabIndex = 13;
            label1.Text = "Educational Degree";
            // 
            // txt_educationaldegree
            // 
            txt_educationaldegree.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_educationaldegree.Location = new Point(182, 176);
            txt_educationaldegree.Multiline = true;
            txt_educationaldegree.Name = "txt_educationaldegree";
            txt_educationaldegree.Size = new Size(240, 50);
            txt_educationaldegree.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(35, 232);
            label3.Name = "label3";
            label3.Size = new Size(80, 17);
            label3.TabIndex = 14;
            label3.Text = "Degree type";
            // 
            // txt_degreetype
            // 
            txt_degreetype.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_degreetype.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_degreetype.FormattingEnabled = true;
            txt_degreetype.Location = new Point(182, 232);
            txt_degreetype.Name = "txt_degreetype";
            txt_degreetype.Size = new Size(240, 25);
            txt_degreetype.TabIndex = 4;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.Transparent;
            btn_cancel.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 152);
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(341, 277);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(81, 36);
            btn_cancel.TabIndex = 6;
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
            btn_save.Location = new Point(254, 277);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(81, 36);
            btn_save.TabIndex = 5;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // txt_yeargraduated
            // 
            txt_yeargraduated.CustomFormat = "yyyy";
            txt_yeargraduated.Format = DateTimePickerFormat.Custom;
            txt_yeargraduated.Location = new Point(182, 147);
            txt_yeargraduated.Name = "txt_yeargraduated";
            txt_yeargraduated.ShowUpDown = true;
            txt_yeargraduated.Size = new Size(71, 23);
            txt_yeargraduated.TabIndex = 2;
            txt_yeargraduated.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // emp_AddEducationalAttainment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(434, 328);
            Controls.Add(txt_yeargraduated);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(txt_degreetype);
            Controls.Add(txt_educationalAttainment);
            Controls.Add(txt_educationaldegree);
            Controls.Add(label3);
            Controls.Add(txt_schoolattended);
            Controls.Add(label22);
            Controls.Add(label1);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(panel2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "emp_AddEducationalAttainment";
            StartPosition = FormStartPosition.CenterParent;
            Load += emp_AddEducationalAttainment_Load;
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
        private ComboBox txt_educationalAttainment;
        private TextBox txt_schoolattended;
        private Label label22;
        private Label label19;
        private Label label18;
        private Label label1;
        private TextBox txt_educationaldegree;
        private Label label3;
        private ComboBox txt_degreetype;
        private Button btn_cancel;
        private Button btn_save;
        private DateTimePicker txt_yeargraduated;
    }
}