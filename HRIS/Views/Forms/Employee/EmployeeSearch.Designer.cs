namespace HRIS.Views.Forms.Employee
{
    partial class EmployeeSearch
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
            dgrid_employee = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            EmployeeID = new DataGridViewTextBoxColumn();
            Firstname = new DataGridViewTextBoxColumn();
            Middlename = new DataGridViewTextBoxColumn();
            Lastname = new DataGridViewTextBoxColumn();
            Suffix = new DataGridViewTextBoxColumn();
            Gender = new DataGridViewTextBoxColumn();
            Birthday = new DataGridViewTextBoxColumn();
            txt_lastname = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            btn_newEmployee = new FontAwesome.Sharp.IconButton();
            btn_editEmployee = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            txt_firstname = new TextBox();
            btn_search = new FontAwesome.Sharp.IconButton();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_employee).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dgrid_employee);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(2, 0, 0, 0);
            panel2.Size = new Size(745, 297);
            panel2.TabIndex = 12;
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
            dgrid_employee.Columns.AddRange(new DataGridViewColumn[] { ID, EmployeeID, Firstname, Middlename, Lastname, Suffix, Gender, Birthday });
            dgrid_employee.Dock = DockStyle.Fill;
            dgrid_employee.Location = new Point(2, 0);
            dgrid_employee.Name = "dgrid_employee";
            dgrid_employee.RowTemplate.Height = 25;
            dgrid_employee.Size = new Size(743, 297);
            dgrid_employee.TabIndex = 0;
            dgrid_employee.TabStop = false;
            dgrid_employee.CellClick += dgrid_employee_CellClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Width = 43;
            // 
            // EmployeeID
            // 
            EmployeeID.HeaderText = "Employee ID";
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Width = 90;
            // 
            // Firstname
            // 
            Firstname.HeaderText = "First Name";
            Firstname.Name = "Firstname";
            Firstname.Width = 82;
            // 
            // Middlename
            // 
            Middlename.HeaderText = "Middle Name";
            Middlename.Name = "Middlename";
            Middlename.Width = 96;
            // 
            // Lastname
            // 
            Lastname.HeaderText = "Last Name";
            Lastname.Name = "Lastname";
            Lastname.Width = 81;
            // 
            // Suffix
            // 
            Suffix.HeaderText = "Suffix";
            Suffix.Name = "Suffix";
            Suffix.Width = 62;
            // 
            // Gender
            // 
            Gender.HeaderText = "Gender";
            Gender.Name = "Gender";
            Gender.Width = 70;
            // 
            // Birthday
            // 
            Birthday.HeaderText = "Birthday";
            Birthday.Name = "Birthday";
            Birthday.Width = 76;
            // 
            // txt_lastname
            // 
            txt_lastname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_lastname.Location = new Point(82, 3);
            txt_lastname.Margin = new Padding(3, 3, 1, 3);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.Size = new Size(538, 29);
            txt_lastname.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txt_lastname);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(745, 35);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 35);
            label1.TabIndex = 2;
            label1.Text = "Last Name:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(btn_newEmployee);
            flowLayoutPanel3.Controls.Add(btn_editEmployee);
            flowLayoutPanel3.Dock = DockStyle.Bottom;
            flowLayoutPanel3.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel3.Location = new Point(0, 367);
            flowLayoutPanel3.Margin = new Padding(0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(0, 0, 3, 0);
            flowLayoutPanel3.Size = new Size(745, 55);
            flowLayoutPanel3.TabIndex = 13;
            // 
            // btn_newEmployee
            // 
            btn_newEmployee.BackColor = Color.FromArgb(0, 127, 152);
            btn_newEmployee.FlatAppearance.BorderSize = 0;
            btn_newEmployee.FlatStyle = FlatStyle.Flat;
            btn_newEmployee.ForeColor = Color.White;
            btn_newEmployee.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btn_newEmployee.IconColor = Color.White;
            btn_newEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_newEmployee.IconSize = 20;
            btn_newEmployee.Location = new Point(616, 3);
            btn_newEmployee.Margin = new Padding(3, 3, 1, 3);
            btn_newEmployee.Name = "btn_newEmployee";
            btn_newEmployee.Size = new Size(125, 48);
            btn_newEmployee.TabIndex = 4;
            btn_newEmployee.TabStop = false;
            btn_newEmployee.Text = "Register as \r\nNew Employee";
            btn_newEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btn_newEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_newEmployee.UseVisualStyleBackColor = false;
            btn_newEmployee.Click += btn_newEmployee_Click;
            // 
            // btn_editEmployee
            // 
            btn_editEmployee.BackColor = Color.FromArgb(0, 127, 152);
            btn_editEmployee.FlatAppearance.BorderSize = 0;
            btn_editEmployee.FlatStyle = FlatStyle.Flat;
            btn_editEmployee.ForeColor = Color.White;
            btn_editEmployee.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            btn_editEmployee.IconColor = Color.White;
            btn_editEmployee.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_editEmployee.IconSize = 20;
            btn_editEmployee.Location = new Point(498, 3);
            btn_editEmployee.Margin = new Padding(1, 3, 1, 3);
            btn_editEmployee.Name = "btn_editEmployee";
            btn_editEmployee.Size = new Size(114, 48);
            btn_editEmployee.TabIndex = 3;
            btn_editEmployee.TabStop = false;
            btn_editEmployee.Text = "Edit Employee";
            btn_editEmployee.TextAlign = ContentAlignment.MiddleLeft;
            btn_editEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_editEmployee.UseVisualStyleBackColor = false;
            btn_editEmployee.Visible = false;
            btn_editEmployee.Click += btn_editEmployee_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(txt_firstname);
            flowLayoutPanel2.Controls.Add(btn_search);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 35);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(745, 35);
            flowLayoutPanel2.TabIndex = 14;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 35);
            label2.TabIndex = 2;
            label2.Text = "First Name:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_firstname
            // 
            txt_firstname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_firstname.Location = new Point(82, 3);
            txt_firstname.Margin = new Padding(3, 3, 1, 3);
            txt_firstname.Name = "txt_firstname";
            txt_firstname.Size = new Size(538, 29);
            txt_firstname.TabIndex = 1;
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
            btn_search.Location = new Point(622, 3);
            btn_search.Margin = new Padding(1, 3, 1, 3);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(81, 29);
            btn_search.TabIndex = 2;
            btn_search.Text = "Search";
            btn_search.TextAlign = ContentAlignment.MiddleLeft;
            btn_search.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // EmployeeSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(745, 422);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel3);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmployeeSearch";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Employee Search";
            KeyDown += EmployeeSearch_KeyDown;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgrid_employee).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private TextBox txt_lastname;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dgrid_employee;
        private FlowLayoutPanel flowLayoutPanel3;
        private FontAwesome.Sharp.IconButton btn_newEmployee;
        private FontAwesome.Sharp.IconButton btn_editEmployee;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
        private TextBox txt_firstname;
        private FontAwesome.Sharp.IconButton btn_search;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewTextBoxColumn Firstname;
        private DataGridViewTextBoxColumn Middlename;
        private DataGridViewTextBoxColumn Lastname;
        private DataGridViewTextBoxColumn Suffix;
        private DataGridViewTextBoxColumn Gender;
        private DataGridViewTextBoxColumn Birthday;
    }
}