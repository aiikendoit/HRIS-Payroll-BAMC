namespace HRIS.Forms.Hiring
{
    partial class HiringForm
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
            label1 = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            dgrid_hiring = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            isApproved = new DataGridViewTextBoxColumn();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btn_void = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_hiring).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
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
            panel1.Location = new Point(5, 418);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 27);
            panel1.TabIndex = 14;
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
            flowLayoutPanel1.Location = new Point(5, 5);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(790, 35);
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
            // dgrid_hiring
            // 
            dgrid_hiring.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.IndianRed;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgrid_hiring.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgrid_hiring.ColumnHeadersHeight = 50;
            dgrid_hiring.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, isApproved });
            dgrid_hiring.Dock = DockStyle.Fill;
            dgrid_hiring.Location = new Point(5, 76);
            dgrid_hiring.Name = "dgrid_hiring";
            dgrid_hiring.RowTemplate.Height = 25;
            dgrid_hiring.Size = new Size(790, 369);
            dgrid_hiring.TabIndex = 13;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Department";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Job Vacancy";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Date Requested";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Status";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Requested by";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "isVoided";
            Column7.Name = "Column7";
            // 
            // isApproved
            // 
            isApproved.HeaderText = "isApproved";
            isApproved.Name = "isApproved";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(iconButton4);
            flowLayoutPanel2.Controls.Add(iconButton3);
            flowLayoutPanel2.Controls.Add(iconButton5);
            flowLayoutPanel2.Controls.Add(btn_void);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(5, 40);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(790, 36);
            flowLayoutPanel2.TabIndex = 12;
            // 
            // btn_void
            // 
            btn_void.BackColor = Color.FromArgb(244, 85, 88);
            btn_void.FlatAppearance.BorderSize = 0;
            btn_void.FlatStyle = FlatStyle.Flat;
            btn_void.ForeColor = Color.White;
            btn_void.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btn_void.IconColor = Color.White;
            btn_void.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_void.IconSize = 20;
            btn_void.Location = new Point(228, 3);
            btn_void.Margin = new Padding(1, 3, 1, 3);
            btn_void.Name = "btn_void";
            btn_void.Size = new Size(73, 30);
            btn_void.TabIndex = 7;
            btn_void.Text = "Void";
            btn_void.TextAlign = ContentAlignment.MiddleLeft;
            btn_void.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_void.UseVisualStyleBackColor = false;
            // 
            // HiringForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dgrid_hiring);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Name = "HiringForm";
            Padding = new Padding(5);
            Text = "HiringForm";
            Load += HiringForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_hiring).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewTextBoxColumn ID;
        private Label label1;
        private Panel panel1;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton5;
        private DataGridView dgrid_hiring;
        private FlowLayoutPanel flowLayoutPanel2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn isApproved;
        private FontAwesome.Sharp.IconButton btn_void;
    }
}