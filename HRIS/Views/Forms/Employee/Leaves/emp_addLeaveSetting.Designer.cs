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
            dateTimePicker1 = new DateTimePicker();
            button4 = new Button();
            button3 = new Button();
            txt_employmenttype = new ComboBox();
            textBox1 = new TextBox();
            label22 = new Label();
            label1 = new Label();
            label19 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
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
            panel2.Size = new Size(421, 40);
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
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(173, 173);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(229, 25);
            dateTimePicker1.TabIndex = 55;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 152);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(311, 211);
            button4.Name = "button4";
            button4.Size = new Size(91, 36);
            button4.TabIndex = 53;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 127, 152);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(214, 211);
            button3.Name = "button3";
            button3.Size = new Size(91, 36);
            button3.TabIndex = 52;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = false;
            // 
            // txt_employmenttype
            // 
            txt_employmenttype.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_employmenttype.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_employmenttype.FormattingEnabled = true;
            txt_employmenttype.Location = new Point(173, 55);
            txt_employmenttype.Name = "txt_employmenttype";
            txt_employmenttype.Size = new Size(229, 25);
            txt_employmenttype.TabIndex = 51;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(173, 117);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(229, 50);
            textBox1.TabIndex = 50;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(49, 176);
            label22.Name = "label22";
            label22.Size = new Size(92, 17);
            label22.TabIndex = 49;
            label22.Text = "Effectivity date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(49, 120);
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
            label19.Size = new Size(109, 17);
            label19.TabIndex = 46;
            label19.Text = "Employment type";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(173, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(106, 25);
            textBox2.TabIndex = 56;
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
            // emp_addLeaveSetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(421, 265);
            Controls.Add(textBox2);
            Controls.Add(panel2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(txt_employmenttype);
            Controls.Add(textBox1);
            Controls.Add(label22);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label19);
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
        private DateTimePicker dateTimePicker1;
        private Button button4;
        private Button button3;
        private ComboBox txt_employmenttype;
        private TextBox textBox1;
        private Label label22;
        private Label label1;
        private Label label19;
        private TextBox textBox2;
        private Label label3;
    }
}