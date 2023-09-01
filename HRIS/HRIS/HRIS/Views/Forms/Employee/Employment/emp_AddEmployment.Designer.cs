﻿namespace HRIS.Forms.Employee.Employment
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
            dateTimePicker1 = new DateTimePicker();
            button4 = new Button();
            button3 = new Button();
            comboBox3 = new ComboBox();
            textBox1 = new TextBox();
            label22 = new Label();
            label1 = new Label();
            label19 = new Label();
            label3 = new Label();
            dateTimePicker2 = new DateTimePicker();
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
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(166, 115);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(229, 25);
            dateTimePicker1.TabIndex = 44;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 152);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(304, 211);
            button4.Name = "button4";
            button4.Size = new Size(91, 36);
            button4.TabIndex = 43;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 127, 152);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(207, 211);
            button3.Name = "button3";
            button3.Size = new Size(91, 36);
            button3.TabIndex = 42;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = false;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(166, 55);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(229, 25);
            comboBox3.TabIndex = 41;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(166, 146);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 50);
            textBox1.TabIndex = 39;
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
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(166, 86);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(229, 25);
            dateTimePicker2.TabIndex = 44;
            // 
            // emp_AddEmployment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(408, 258);
            Controls.Add(panel2);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(comboBox3);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label22);
            Controls.Add(label1);
            Controls.Add(label19);
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
        private DateTimePicker dateTimePicker1;
        private Button button4;
        private Button button3;
        private ComboBox comboBox3;
        private TextBox textBox1;
        private Label label22;
        private Label label1;
        private Label label19;
        private Label label3;
        private DateTimePicker dateTimePicker2;
    }
}