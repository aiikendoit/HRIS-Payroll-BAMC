namespace HRIS.Forms.Hiring
{
    partial class frm_HiringAdd
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
            button4 = new Button();
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox9 = new TextBox();
            label13 = new Label();
            textBox2 = new TextBox();
            label15 = new Label();
            label7 = new Label();
            label6 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 152);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(352, 316);
            button4.Name = "button4";
            button4.Size = new Size(91, 36);
            button4.TabIndex = 5;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 127, 152);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(255, 316);
            button3.Name = "button3";
            button3.Size = new Size(91, 36);
            button3.TabIndex = 4;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(189, 152);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(253, 25);
            dateTimePicker1.TabIndex = 2;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(190, 181);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(253, 129);
            textBox9.TabIndex = 3;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(56, 155);
            label13.Name = "label13";
            label13.Size = new Size(86, 17);
            label13.TabIndex = 24;
            label13.Text = "Date Needed";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(189, 83);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 65);
            textBox2.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(57, 184);
            label15.Name = "label15";
            label15.Size = new Size(58, 17);
            label15.TabIndex = 22;
            label15.Text = "Remarks";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(56, 86);
            label7.Name = "label7";
            label7.Size = new Size(121, 17);
            label7.TabIndex = 20;
            label7.Text = "Job Vacant Position";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(56, 58);
            label6.Name = "label6";
            label6.Size = new Size(77, 17);
            label6.TabIndex = 15;
            label6.Text = "Department";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(8, 9);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 14;
            iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 9);
            label2.Name = "label2";
            label2.Size = new Size(184, 32);
            label2.TabIndex = 13;
            label2.Text = "Hiring Request";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(189, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(253, 25);
            comboBox1.TabIndex = 0;
            // 
            // frm_HiringAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(455, 365);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox9);
            Controls.Add(label13);
            Controls.Add(textBox2);
            Controls.Add(label15);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(iconPictureBox1);
            Controls.Add(label2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_HiringAdd";
            StartPosition = FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox9;
        private Label label13;
        private TextBox textBox2;
        private Label label15;
        private Label label7;
        private Label label6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label2;
        private ComboBox comboBox1;
    }
}