namespace HRIS.Forms.Employee.Family_and_Dependents
{
    partial class emp_FamilyDependentsForm
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
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            ID = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dgrid_family = new DataGridView();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            PkEmployeedependents_ID = new DataGridViewTextBoxColumn();
            Fullname = new DataGridViewTextBoxColumn();
            Birthdate = new DataGridViewTextBoxColumn();
            Relationship = new DataGridViewTextBoxColumn();
            Civilsatatus = new DataGridViewTextBoxColumn();
            contactno = new DataGridViewTextBoxColumn();
            qualifiedD = new DataGridViewCheckBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_family).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 5);
            label2.Name = "label2";
            label2.Size = new Size(258, 32);
            label2.TabIndex = 2;
            label2.Text = "Family && Dependents";
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
            panel1.TabIndex = 33;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
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
            flowLayoutPanel1.TabIndex = 31;
            // 
            // dgrid_family
            // 
            dgrid_family.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.IndianRed;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgrid_family.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgrid_family.ColumnHeadersHeight = 50;
            dgrid_family.Columns.AddRange(new DataGridViewColumn[] { PkEmployeedependents_ID, Fullname, Birthdate, Relationship, Civilsatatus, contactno, qualifiedD, Column1 });
            dgrid_family.Dock = DockStyle.Fill;
            dgrid_family.Location = new Point(0, 111);
            dgrid_family.Name = "dgrid_family";
            dgrid_family.RowTemplate.Height = 25;
            dgrid_family.Size = new Size(800, 312);
            dgrid_family.TabIndex = 32;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(11, 5);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
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
            panel2.TabIndex = 34;
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
            flowLayoutPanel2.TabIndex = 35;
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
            // PkEmployeedependents_ID
            // 
            PkEmployeedependents_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            PkEmployeedependents_ID.HeaderText = "ID";
            PkEmployeedependents_ID.Name = "PkEmployeedependents_ID";
            PkEmployeedependents_ID.Width = 80;
            // 
            // Fullname
            // 
            Fullname.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Fullname.HeaderText = "Fullname";
            Fullname.Name = "Fullname";
            Fullname.Width = 81;
            // 
            // Birthdate
            // 
            Birthdate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Birthdate.HeaderText = "Birthdate";
            Birthdate.Name = "Birthdate";
            Birthdate.Width = 80;
            // 
            // Relationship
            // 
            Relationship.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Relationship.HeaderText = "Relationship";
            Relationship.Name = "Relationship";
            Relationship.Width = 97;
            // 
            // Civilsatatus
            // 
            Civilsatatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Civilsatatus.HeaderText = "Civil Status";
            Civilsatatus.Name = "Civilsatatus";
            Civilsatatus.Width = 120;
            // 
            // contactno
            // 
            contactno.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            contactno.HeaderText = "Contact #";
            contactno.Name = "contactno";
            // 
            // qualifiedD
            // 
            qualifiedD.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            qualifiedD.HeaderText = "Qualified Dependent";
            qualifiedD.Name = "qualifiedD";
            qualifiedD.Resizable = DataGridViewTriState.True;
            qualifiedD.SortMode = DataGridViewColumnSortMode.Automatic;
            qualifiedD.Width = 150;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "";
            Column1.Name = "Column1";
            // 
            // emp_FamilyDependentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(dgrid_family);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Name = "emp_FamilyDependentsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "emp_FamilyDependentsForm";
            Load += emp_FamilyDependentsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_family).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel panel1;
        private DataGridViewTextBoxColumn ID;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dgrid_family;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton5;
        private DataGridViewTextBoxColumn PkEmployeedependents_ID;
        private DataGridViewTextBoxColumn Fullname;
        private DataGridViewTextBoxColumn Birthdate;
        private DataGridViewTextBoxColumn Relationship;
        private DataGridViewTextBoxColumn Civilsatatus;
        private DataGridViewTextBoxColumn contactno;
        private DataGridViewCheckBoxColumn qualifiedD;
        private DataGridViewTextBoxColumn Column1;
    }
}