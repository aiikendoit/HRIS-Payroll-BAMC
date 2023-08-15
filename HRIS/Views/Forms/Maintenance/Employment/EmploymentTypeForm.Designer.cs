namespace HRIS.Forms.Maintenance.Employment
{
    partial class EmploymentTypeForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmploymentTypeForm));
            dgrid_employmenttype = new DataGridView();
            panel1 = new Panel();
            txt_totalcount = new Label();
            btn_new = new FontAwesome.Sharp.IconButton();
            btn_edit = new FontAwesome.Sharp.IconButton();
            txt_search = new TextBox();
            btn_search = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btn_view = new FontAwesome.Sharp.IconButton();
            btn_refresh = new FontAwesome.Sharp.IconButton();
            ID = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            isActive = new DataGridViewTextBoxColumn();
            EmploymentID = new DataGridViewTextBoxColumn();
            EmploymentDescription = new DataGridViewTextBoxColumn();
            isOrganic = new DataGridViewCheckBoxColumn();
            isInOrganic = new DataGridViewCheckBoxColumn();
            Createddate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgrid_employmenttype).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgrid_employmenttype
            // 
            dgrid_employmenttype.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.IndianRed;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgrid_employmenttype.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgrid_employmenttype.ColumnHeadersHeight = 50;
            dgrid_employmenttype.Columns.AddRange(new DataGridViewColumn[] { isActive, EmploymentID, EmploymentDescription, isOrganic, isInOrganic, Createddate });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgrid_employmenttype.DefaultCellStyle = dataGridViewCellStyle2;
            dgrid_employmenttype.Dock = DockStyle.Fill;
            dgrid_employmenttype.Location = new Point(0, 108);
            dgrid_employmenttype.Name = "dgrid_employmenttype";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgrid_employmenttype.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgrid_employmenttype.RowTemplate.Height = 25;
            dgrid_employmenttype.Size = new Size(800, 315);
            dgrid_employmenttype.TabIndex = 58;
            dgrid_employmenttype.CellFormatting += dgrid_employmenttype_CellFormatting;
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_totalcount);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 423);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 27);
            panel1.TabIndex = 59;
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
            btn_new.Location = new Point(0, 3);
            btn_new.Margin = new Padding(0, 3, 1, 3);
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
            btn_edit.Location = new Point(75, 3);
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
            // txt_search
            // 
            txt_search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(0, 3);
            txt_search.Margin = new Padding(0, 3, 1, 3);
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
            btn_search.Location = new Point(340, 3);
            btn_search.Margin = new Padding(1, 3, 1, 3);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(77, 29);
            btn_search.TabIndex = 1;
            btn_search.Text = "Search";
            btn_search.TextAlign = ContentAlignment.MiddleLeft;
            btn_search.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btn_new);
            flowLayoutPanel2.Controls.Add(btn_edit);
            flowLayoutPanel2.Controls.Add(btn_view);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 72);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(800, 36);
            flowLayoutPanel2.TabIndex = 57;
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
            btn_view.Location = new Point(150, 3);
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
            btn_refresh.Location = new Point(419, 3);
            btn_refresh.Margin = new Padding(1, 3, 1, 3);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new Size(77, 29);
            btn_refresh.TabIndex = 2;
            btn_refresh.Text = "Refresh";
            btn_refresh.TextAlign = ContentAlignment.MiddleLeft;
            btn_refresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_refresh.UseVisualStyleBackColor = false;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(20);
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 2);
            label2.Name = "label2";
            label2.Size = new Size(197, 30);
            label2.TabIndex = 2;
            label2.Text = "Employment type";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 37);
            panel2.TabIndex = 60;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(txt_search);
            flowLayoutPanel1.Controls.Add(btn_search);
            flowLayoutPanel1.Controls.Add(btn_refresh);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 37);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 35);
            flowLayoutPanel1.TabIndex = 56;
            // 
            // isActive
            // 
            isActive.HeaderText = "isActive";
            isActive.Name = "isActive";
            // 
            // EmploymentID
            // 
            EmploymentID.HeaderText = "ID";
            EmploymentID.Name = "EmploymentID";
            // 
            // EmploymentDescription
            // 
            EmploymentDescription.HeaderText = "Description";
            EmploymentDescription.Name = "EmploymentDescription";
            // 
            // isOrganic
            // 
            isOrganic.HeaderText = "isOrganic";
            isOrganic.Name = "isOrganic";
            isOrganic.Resizable = DataGridViewTriState.True;
            isOrganic.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // isInOrganic
            // 
            isInOrganic.HeaderText = "isInOrganic";
            isInOrganic.Name = "isInOrganic";
            isInOrganic.Resizable = DataGridViewTriState.True;
            isInOrganic.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Createddate
            // 
            Createddate.HeaderText = "Createddate";
            Createddate.Name = "Createddate";
            // 
            // EmploymentTypeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(dgrid_employmenttype);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Name = "EmploymentTypeForm";
            Text = "EmploymentTypeForm";
            ((System.ComponentModel.ISupportInitialize)dgrid_employmenttype).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgrid_employmenttype;
        private Panel panel1;
        private Label txt_totalcount;
        private FontAwesome.Sharp.IconButton btn_new;
        private FontAwesome.Sharp.IconButton btn_edit;
        private TextBox txt_search;
        private FontAwesome.Sharp.IconButton btn_search;
        private FlowLayoutPanel flowLayoutPanel2;
        private FontAwesome.Sharp.IconButton btn_view;
        private FontAwesome.Sharp.IconButton btn_refresh;
        private DataGridViewTextBoxColumn ID;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridViewTextBoxColumn isActive;
        private DataGridViewTextBoxColumn EmploymentID;
        private DataGridViewTextBoxColumn EmploymentDescription;
        private DataGridViewCheckBoxColumn isOrganic;
        private DataGridViewCheckBoxColumn isInOrganic;
        private DataGridViewTextBoxColumn Createddate;
    }
}