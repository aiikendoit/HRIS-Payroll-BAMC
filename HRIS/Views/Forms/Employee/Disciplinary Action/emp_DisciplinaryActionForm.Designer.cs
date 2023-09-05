namespace HRIS.Forms.Employee.Disciplinary_Action
{
    partial class emp_DisciplinaryActionForm
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
            panel2 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            txt_totalcount = new Label();
            panel1 = new Panel();
            ID = new DataGridViewTextBoxColumn();
            dgrid_disciplinaryAction = new DataGridView();
            Code = new DataGridViewTextBoxColumn();
            offensetypeDescr = new DataGridViewTextBoxColumn();
            disciplinaryTypeName = new DataGridViewTextBoxColumn();
            empDA_Descr = new DataGridViewTextBoxColumn();
            datestart = new DataGridViewTextBoxColumn();
            dateEnd = new DataGridViewTextBoxColumn();
            file = new DataGridViewTextBoxColumn();
            createdDate = new DataGridViewTextBoxColumn();
            createdBy = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            viewButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn = new DataGridViewButtonColumn();
            textBox1 = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_new = new FontAwesome.Sharp.IconButton();
            btn_edit = new FontAwesome.Sharp.IconButton();
            btn_view = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_disciplinaryAction).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 40);
            panel2.TabIndex = 25;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.BalanceScale;
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
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 5);
            label2.Name = "label2";
            label2.Size = new Size(232, 32);
            label2.TabIndex = 2;
            label2.Text = "Disciplinary Action";
            // 
            // txt_totalcount
            // 
            txt_totalcount.AutoSize = true;
            txt_totalcount.ForeColor = Color.Black;
            txt_totalcount.Location = new Point(5, 6);
            txt_totalcount.Name = "txt_totalcount";
            txt_totalcount.Size = new Size(94, 15);
            txt_totalcount.TabIndex = 0;
            txt_totalcount.Text = "Total record(s): 0";
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_totalcount);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 423);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 27);
            panel1.TabIndex = 24;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // dgrid_disciplinaryAction
            // 
            dgrid_disciplinaryAction.AllowUserToAddRows = false;
            dgrid_disciplinaryAction.AllowUserToDeleteRows = false;
            dgrid_disciplinaryAction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.IndianRed;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgrid_disciplinaryAction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgrid_disciplinaryAction.ColumnHeadersHeight = 50;
            dgrid_disciplinaryAction.Columns.AddRange(new DataGridViewColumn[] { Code, offensetypeDescr, disciplinaryTypeName, empDA_Descr, datestart, dateEnd, file, createdDate, createdBy, Column1, viewButtonColumn, editButtonColumn });
            dgrid_disciplinaryAction.Dock = DockStyle.Fill;
            dgrid_disciplinaryAction.Location = new Point(0, 111);
            dgrid_disciplinaryAction.Name = "dgrid_disciplinaryAction";
            dgrid_disciplinaryAction.ReadOnly = true;
            dgrid_disciplinaryAction.RowTemplate.Height = 25;
            dgrid_disciplinaryAction.Size = new Size(800, 339);
            dgrid_disciplinaryAction.TabIndex = 23;
            dgrid_disciplinaryAction.CellContentClick += dgrid_disciplinaryAction_CellContentClick;
            // 
            // Code
            // 
            Code.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Code.HeaderText = "Code";
            Code.Name = "Code";
            Code.ReadOnly = true;
            Code.Width = 80;
            // 
            // offensetypeDescr
            // 
            offensetypeDescr.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            offensetypeDescr.HeaderText = "Offense Type";
            offensetypeDescr.Name = "offensetypeDescr";
            offensetypeDescr.ReadOnly = true;
            // 
            // disciplinaryTypeName
            // 
            disciplinaryTypeName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            disciplinaryTypeName.HeaderText = "Disciplinary Type";
            disciplinaryTypeName.Name = "disciplinaryTypeName";
            disciplinaryTypeName.ReadOnly = true;
            disciplinaryTypeName.Width = 110;
            // 
            // empDA_Descr
            // 
            empDA_Descr.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            empDA_Descr.HeaderText = "Description";
            empDA_Descr.Name = "empDA_Descr";
            empDA_Descr.ReadOnly = true;
            empDA_Descr.Width = 92;
            // 
            // datestart
            // 
            datestart.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            datestart.HeaderText = "Date Start";
            datestart.Name = "datestart";
            datestart.ReadOnly = true;
            datestart.Width = 77;
            // 
            // dateEnd
            // 
            dateEnd.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dateEnd.HeaderText = "Date End";
            dateEnd.Name = "dateEnd";
            dateEnd.ReadOnly = true;
            dateEnd.Width = 73;
            // 
            // file
            // 
            file.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            file.HeaderText = "File";
            file.Name = "file";
            file.ReadOnly = true;
            file.Visible = false;
            // 
            // createdDate
            // 
            createdDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            createdDate.HeaderText = "Created Date";
            createdDate.Name = "createdDate";
            createdDate.ReadOnly = true;
            createdDate.Visible = false;
            // 
            // createdBy
            // 
            createdBy.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            createdBy.HeaderText = "Created By";
            createdBy.Name = "createdBy";
            createdBy.ReadOnly = true;
            createdBy.Visible = false;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // viewButtonColumn
            // 
            viewButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            viewButtonColumn.HeaderText = "";
            viewButtonColumn.Name = "viewButtonColumn";
            viewButtonColumn.ReadOnly = true;
            viewButtonColumn.Resizable = DataGridViewTriState.True;
            viewButtonColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            viewButtonColumn.Width = 60;
            // 
            // editButtonColumn
            // 
            editButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            editButtonColumn.HeaderText = "";
            editButtonColumn.Name = "editButtonColumn";
            editButtonColumn.ReadOnly = true;
            editButtonColumn.Resizable = DataGridViewTriState.True;
            editButtonColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            editButtonColumn.Width = 60;
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
            flowLayoutPanel1.TabIndex = 21;
            // 
            // btn_new
            // 
            btn_new.BackColor = Color.FromArgb(0, 127, 152);
            btn_new.FlatAppearance.BorderSize = 0;
            btn_new.FlatStyle = FlatStyle.Flat;
            btn_new.ForeColor = Color.White;
            btn_new.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btn_new.IconColor = Color.White;
            btn_new.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_new.IconSize = 20;
            btn_new.Location = new Point(3, 3);
            btn_new.Margin = new Padding(3, 3, 1, 3);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(73, 30);
            btn_new.TabIndex = 4;
            btn_new.Text = "New";
            btn_new.TextAlign = ContentAlignment.MiddleLeft;
            btn_new.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_new.UseVisualStyleBackColor = false;
            btn_new.Click += btn_new_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.FromArgb(0, 127, 152);
            btn_edit.FlatAppearance.BorderSize = 0;
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.ForeColor = Color.White;
            btn_edit.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            btn_edit.IconColor = Color.White;
            btn_edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_edit.IconSize = 20;
            btn_edit.Location = new Point(78, 3);
            btn_edit.Margin = new Padding(1, 3, 1, 3);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(73, 30);
            btn_edit.TabIndex = 5;
            btn_edit.Text = "Edit";
            btn_edit.TextAlign = ContentAlignment.MiddleLeft;
            btn_edit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_view
            // 
            btn_view.BackColor = Color.FromArgb(0, 127, 152);
            btn_view.FlatAppearance.BorderSize = 0;
            btn_view.FlatStyle = FlatStyle.Flat;
            btn_view.ForeColor = Color.White;
            btn_view.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btn_view.IconColor = Color.White;
            btn_view.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_view.IconSize = 20;
            btn_view.Location = new Point(153, 3);
            btn_view.Margin = new Padding(1, 3, 1, 3);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(73, 30);
            btn_view.TabIndex = 6;
            btn_view.Text = "View";
            btn_view.TextAlign = ContentAlignment.MiddleLeft;
            btn_view.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_view.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btn_new);
            flowLayoutPanel2.Controls.Add(btn_edit);
            flowLayoutPanel2.Controls.Add(btn_view);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 75);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(800, 36);
            flowLayoutPanel2.TabIndex = 22;
            // 
            // emp_DisciplinaryActionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dgrid_disciplinaryAction);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Name = "emp_DisciplinaryActionForm";
            Text = "emp_DisciplinaryActionForm";
            Load += emp_DisciplinaryActionForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_disciplinaryAction).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label2;
        private Label txt_totalcount;
        private Panel panel1;
        private DataGridViewTextBoxColumn ID;
        private DataGridView dgrid_disciplinaryAction;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton btn_new;
        private FontAwesome.Sharp.IconButton btn_edit;
        private FontAwesome.Sharp.IconButton btn_view;
        private FlowLayoutPanel flowLayoutPanel2;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn offensetypeDescr;
        private DataGridViewTextBoxColumn disciplinaryTypeName;
        private DataGridViewTextBoxColumn empDA_Descr;
        private DataGridViewTextBoxColumn datestart;
        private DataGridViewTextBoxColumn dateEnd;
        private DataGridViewTextBoxColumn file;
        private DataGridViewTextBoxColumn createdDate;
        private DataGridViewTextBoxColumn createdBy;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewButtonColumn viewButtonColumn;
        private DataGridViewButtonColumn editButtonColumn;
    }
}