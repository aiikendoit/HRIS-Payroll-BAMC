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
            textBox2 = new TextBox();
            panel2 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            button4 = new Button();
            button3 = new Button();
            comboBox3 = new ComboBox();
            label22 = new Label();
            label3 = new Label();
            label19 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            textBox4 = new TextBox();
            checkBox1 = new CheckBox();
            label7 = new Label();
            textBox5 = new TextBox();
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
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(174, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 25);
            textBox2.TabIndex = 67;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(174, 172);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(255, 25);
            dateTimePicker1.TabIndex = 66;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 152);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(338, 325);
            button4.Name = "button4";
            button4.Size = new Size(91, 36);
            button4.TabIndex = 65;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 127, 152);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(241, 325);
            button3.Name = "button3";
            button3.Size = new Size(91, 36);
            button3.TabIndex = 64;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = false;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(174, 203);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(255, 25);
            comboBox3.TabIndex = 63;
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(174, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 25);
            textBox1.TabIndex = 67;
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
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(174, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(255, 25);
            textBox3.TabIndex = 67;
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
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(174, 234);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(255, 25);
            comboBox1.TabIndex = 63;
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
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(174, 265);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(255, 25);
            textBox4.TabIndex = 67;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(174, 296);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(135, 19);
            checkBox1.TabIndex = 68;
            checkBox1.Text = "Qualified Dependent";
            checkBox1.UseVisualStyleBackColor = true;
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
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(174, 141);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(141, 25);
            textBox5.TabIndex = 67;
            // 
            // emp_AddDependent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(440, 376);
            Controls.Add(checkBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(panel2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button4);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(comboBox3);
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
        private TextBox textBox2;
        private Panel panel2;
        private DateTimePicker dateTimePicker1;
        private Button button4;
        private Button button3;
        private ComboBox comboBox3;
        private Label label22;
        private Label label3;
        private Label label19;
        private Label label1;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox textBox4;
        private CheckBox checkBox1;
        private Label label7;
        private TextBox textBox5;
    }
}