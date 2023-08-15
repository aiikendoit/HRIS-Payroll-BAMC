namespace HRIS.Forms.Employee
{
    partial class EmployeeForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            txt_search = new TextBox();
            btn_search = new FontAwesome.Sharp.IconButton();
            btn_refresh = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btn_new = new FontAwesome.Sharp.IconButton();
            btn_edit = new FontAwesome.Sharp.IconButton();
            btn_view = new FontAwesome.Sharp.IconButton();
            dgrid_employee = new DataGridView();
            panel1 = new Panel();
            txt_totalcount = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            btn_inactiveEmployee = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            btn_userRegistration = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_employee).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(txt_search);
            flowLayoutPanel1.Controls.Add(btn_search);
            flowLayoutPanel1.Controls.Add(btn_refresh);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(5, 5);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1086, 35);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // txt_search
            // 
            txt_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(3, 3);
            txt_search.Margin = new Padding(3, 3, 1, 3);
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = " Search";
            txt_search.Size = new Size(338, 29);
            txt_search.TabIndex = 0;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.FromArgb(0, 127, 152);
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.ForeColor = Color.White;
            btn_search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btn_search.IconColor = Color.White;
            btn_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_search.IconSize = 20;
            btn_search.Location = new Point(343, 3);
            btn_search.Margin = new Padding(1, 3, 1, 3);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(81, 29);
            btn_search.TabIndex = 1;
            btn_search.Text = "Search";
            btn_search.TextAlign = ContentAlignment.MiddleLeft;
            btn_search.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // btn_refresh
            // 
            btn_refresh.BackColor = Color.FromArgb(0, 127, 152);
            btn_refresh.FlatAppearance.BorderSize = 0;
            btn_refresh.FlatStyle = FlatStyle.Flat;
            btn_refresh.ForeColor = Color.White;
            btn_refresh.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            btn_refresh.IconColor = Color.White;
            btn_refresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_refresh.IconSize = 20;
            btn_refresh.Location = new Point(426, 3);
            btn_refresh.Margin = new Padding(1, 3, 1, 3);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(81, 29);
            btn_refresh.TabIndex = 2;
            btn_refresh.Text = "Refresh";
            btn_refresh.TextAlign = ContentAlignment.MiddleLeft;
            btn_refresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btn_new);
            flowLayoutPanel2.Controls.Add(btn_edit);
            flowLayoutPanel2.Controls.Add(btn_view);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(5, 40);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1086, 36);
            flowLayoutPanel2.TabIndex = 3;
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
            btn_new.Click += iconButton4_Click;
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
            btn_view.Click += btn_view_Click;
            // 
            // dgrid_employee
            // 
            dgrid_employee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.IndianRed;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgrid_employee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgrid_employee.ColumnHeadersHeight = 50;
            dgrid_employee.Dock = DockStyle.Fill;
            dgrid_employee.Location = new Point(5, 76);
            dgrid_employee.Name = "dgrid_employee";
            dgrid_employee.RowTemplate.Height = 25;
            dgrid_employee.Size = new Size(919, 542);
            dgrid_employee.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_totalcount);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(5, 618);
            panel1.Name = "panel1";
            panel1.Size = new Size(1086, 27);
            panel1.TabIndex = 5;
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
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(5, 76);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(2, 0, 0, 0);
            panel2.Size = new Size(1086, 542);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 127, 152);
            panel3.Controls.Add(btn_inactiveEmployee);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(btn_userRegistration);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(924, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(167, 542);
            panel3.TabIndex = 7;
            // 
            // btn_inactiveEmployee
            // 
            btn_inactiveEmployee.BackColor = Color.FromArgb(0, 127, 152);
            btn_inactiveEmployee.Cursor = Cursors.Hand;
            btn_inactiveEmployee.Dock = DockStyle.Top;
            btn_inactiveEmployee.FlatAppearance.BorderSize = 0;
            btn_inactiveEmployee.FlatStyle = FlatStyle.Flat;
            btn_inactiveEmployee.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_inactiveEmployee.ForeColor = Color.White;
            btn_inactiveEmployee.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_inactiveEmployee.IconColor = Color.White;
            btn_inactiveEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_inactiveEmployee.IconSize = 20;
            btn_inactiveEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            btn_inactiveEmployee.Location = new Point(0, 82);
            btn_inactiveEmployee.Margin = new Padding(4, 3, 4, 3);
            btn_inactiveEmployee.Name = "btn_inactiveEmployee";
            btn_inactiveEmployee.Padding = new Padding(10, 0, 0, 0);
            btn_inactiveEmployee.Size = new Size(167, 28);
            btn_inactiveEmployee.TabIndex = 26;
            btn_inactiveEmployee.Tag = "Archive Employee";
            btn_inactiveEmployee.Text = "Archive Employee";
            btn_inactiveEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btn_inactiveEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_inactiveEmployee.UseVisualStyleBackColor = false;
            btn_inactiveEmployee.Click += btn_inactiveEmployee_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(86, 180, 206);
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(0, 55);
            label3.Name = "label3";
            label3.Padding = new Padding(5, 0, 0, 0);
            label3.Size = new Size(167, 27);
            label3.TabIndex = 28;
            label3.Text = "VIEW";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_userRegistration
            // 
            btn_userRegistration.BackColor = Color.FromArgb(0, 127, 152);
            btn_userRegistration.Cursor = Cursors.Hand;
            btn_userRegistration.Dock = DockStyle.Top;
            btn_userRegistration.FlatAppearance.BorderSize = 0;
            btn_userRegistration.FlatStyle = FlatStyle.Flat;
            btn_userRegistration.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_userRegistration.ForeColor = Color.White;
            btn_userRegistration.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            btn_userRegistration.IconColor = Color.White;
            btn_userRegistration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_userRegistration.IconSize = 20;
            btn_userRegistration.ImageAlign = ContentAlignment.MiddleLeft;
            btn_userRegistration.Location = new Point(0, 27);
            btn_userRegistration.Margin = new Padding(4, 3, 4, 3);
            btn_userRegistration.Name = "btn_userRegistration";
            btn_userRegistration.Padding = new Padding(10, 0, 0, 0);
            btn_userRegistration.Size = new Size(167, 28);
            btn_userRegistration.TabIndex = 25;
            btn_userRegistration.Tag = "User Registration";
            btn_userRegistration.Text = "User Registration";
            btn_userRegistration.TextAlign = ContentAlignment.MiddleLeft;
            btn_userRegistration.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_userRegistration.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(86, 180, 206);
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(5, 0, 0, 0);
            label2.Size = new Size(167, 27);
            label2.TabIndex = 27;
            label2.Text = "ACTION";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(139, 215, 231);
            ClientSize = new Size(1096, 650);
            Controls.Add(dgrid_employee);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            DoubleBuffered = true;
            Name = "EmployeeForm";
            Padding = new Padding(5);
            Text = "EmployeeForm";
            Load += EmployeeForm_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrid_employee).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txt_search;
        private FontAwesome.Sharp.IconButton btn_search;
        private FontAwesome.Sharp.IconButton btn_refresh;
        private FlowLayoutPanel flowLayoutPanel2;
        private FontAwesome.Sharp.IconButton btn_new;
        private FontAwesome.Sharp.IconButton btn_edit;
        private FontAwesome.Sharp.IconButton btn_view;
        private DataGridView dgrid_employee;
        private Panel panel1;
        private Label txt_totalcount;
        private Panel panel2;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btn_inactiveEmployee;
        private FontAwesome.Sharp.IconButton btn_userRegistration;
        private Label label2;
        private Label label3;
    }
}