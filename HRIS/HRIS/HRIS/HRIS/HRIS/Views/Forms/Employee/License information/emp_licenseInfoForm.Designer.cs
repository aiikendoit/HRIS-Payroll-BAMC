﻿namespace HRIS.Forms.Employee.License_information
{
    partial class emp_licenseInfoForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            ID = new DataGridViewTextBoxColumn();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            dgrid_license = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel2 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_license).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(11, 7);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 40);
            panel2.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 5);
            label2.Name = "label2";
            label2.Size = new Size(242, 32);
            label2.TabIndex = 2;
            label2.Text = "License Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(5, 6);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Total record(s): 0";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 423);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 27);
            panel1.TabIndex = 14;
            // 
            // dgrid_license
            // 
            dgrid_license.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.IndianRed;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgrid_license.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgrid_license.ColumnHeadersHeight = 50;
            dgrid_license.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgrid_license.Dock = DockStyle.Fill;
            dgrid_license.Location = new Point(0, 111);
            dgrid_license.Name = "dgrid_license";
            dgrid_license.RowTemplate.Height = 25;
            dgrid_license.Size = new Size(800, 312);
            dgrid_license.TabIndex = 13;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "License type";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "License #";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Expiry date";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Expiry Reminder";
            Column5.Name = "Column5";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(3, 3);
            textBox1.Margin = new Padding(3, 3, 1, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = " Search";
            textBox1.Size = new Size(338, 29);
            textBox1.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(0, 127, 152);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(343, 3);
            iconButton1.Margin = new Padding(1, 3, 1, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(77, 29);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "Search";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(0, 127, 152);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 20;
            iconButton2.Location = new Point(422, 3);
            iconButton2.Margin = new Padding(1, 3, 1, 3);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(77, 29);
            iconButton2.TabIndex = 2;
            iconButton2.Text = "Refresh";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(iconButton1);
            flowLayoutPanel1.Controls.Add(iconButton2);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 40);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 35);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.FromArgb(0, 127, 152);
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            iconButton4.IconColor = Color.White;
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 20;
            iconButton4.Location = new Point(3, 3);
            iconButton4.Margin = new Padding(3, 3, 1, 3);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(73, 30);
            iconButton4.TabIndex = 4;
            iconButton4.Text = "New";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = false;
            iconButton4.Click += iconButton4_Click;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.FromArgb(0, 127, 152);
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 20;
            iconButton3.Location = new Point(78, 3);
            iconButton3.Margin = new Padding(1, 3, 1, 3);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(73, 30);
            iconButton3.TabIndex = 5;
            iconButton3.Text = "Edit";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            iconButton5.BackColor = Color.FromArgb(0, 127, 152);
            iconButton5.FlatAppearance.BorderSize = 0;
            iconButton5.FlatStyle = FlatStyle.Flat;
            iconButton5.ForeColor = Color.White;
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.Eye;
            iconButton5.IconColor = Color.White;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 20;
            iconButton5.Location = new Point(153, 3);
            iconButton5.Margin = new Padding(1, 3, 1, 3);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(73, 30);
            iconButton5.TabIndex = 6;
            iconButton5.Text = "View";
            iconButton5.TextAlign = ContentAlignment.MiddleLeft;
            iconButton5.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton5.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(iconButton4);
            flowLayoutPanel2.Controls.Add(iconButton3);
            flowLayoutPanel2.Controls.Add(iconButton5);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 75);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(800, 36);
            flowLayoutPanel2.TabIndex = 12;
            // 
            // emp_licenseInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(dgrid_license);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Name = "emp_licenseInfoForm";
            Text = "emp_licenseInfoForm";
            Load += emp_licenseInfoForm_Load;
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_license).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewTextBoxColumn ID;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private DataGridView dgrid_license;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FlowLayoutPanel flowLayoutPanel2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}