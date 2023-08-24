namespace HRIS.Forms.Employee.Documents
{
    partial class emp_DocumentsForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btn_new = new FontAwesome.Sharp.IconButton();
            btn_Edit = new FontAwesome.Sharp.IconButton();
            btn_viewDocs = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label2 = new Label();
            label_total = new Label();
            ID = new DataGridViewTextBoxColumn();
            dgrid_documents = new DataGridView();
            Code = new DataGridViewTextBoxColumn();
            DocType = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Remarks = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            txt_search = new TextBox();
            btn_search = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            flowLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgrid_documents).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btn_new);
            flowLayoutPanel2.Controls.Add(btn_Edit);
            flowLayoutPanel2.Controls.Add(btn_viewDocs);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 75);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(800, 36);
            flowLayoutPanel2.TabIndex = 32;
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
            // btn_Edit
            // 
            btn_Edit.BackColor = Color.FromArgb(0, 127, 152);
            btn_Edit.FlatAppearance.BorderSize = 0;
            btn_Edit.FlatStyle = FlatStyle.Flat;
            btn_Edit.ForeColor = Color.White;
            btn_Edit.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            btn_Edit.IconColor = Color.White;
            btn_Edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Edit.IconSize = 20;
            btn_Edit.Location = new Point(78, 3);
            btn_Edit.Margin = new Padding(1, 3, 1, 3);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(73, 30);
            btn_Edit.TabIndex = 5;
            btn_Edit.Text = "Edit";
            btn_Edit.TextAlign = ContentAlignment.MiddleLeft;
            btn_Edit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_viewDocs
            // 
            btn_viewDocs.BackColor = Color.FromArgb(0, 127, 152);
            btn_viewDocs.FlatAppearance.BorderSize = 0;
            btn_viewDocs.FlatStyle = FlatStyle.Flat;
            btn_viewDocs.ForeColor = Color.White;
            btn_viewDocs.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btn_viewDocs.IconColor = Color.White;
            btn_viewDocs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_viewDocs.IconSize = 20;
            btn_viewDocs.Location = new Point(153, 3);
            btn_viewDocs.Margin = new Padding(1, 3, 1, 3);
            btn_viewDocs.Name = "btn_viewDocs";
            btn_viewDocs.Size = new Size(73, 30);
            btn_viewDocs.TabIndex = 6;
            btn_viewDocs.Text = "View";
            btn_viewDocs.TextAlign = ContentAlignment.MiddleLeft;
            btn_viewDocs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_viewDocs.UseVisualStyleBackColor = false;
            btn_viewDocs.Click += btn_viewDocs_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 40);
            panel2.TabIndex = 35;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.FileContract;
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
            label2.Size = new Size(144, 32);
            label2.TabIndex = 2;
            label2.Text = "Documents";
            // 
            // label_total
            // 
            label_total.AutoSize = true;
            label_total.ForeColor = Color.Black;
            label_total.Location = new Point(5, 6);
            label_total.Name = "label_total";
            label_total.Size = new Size(94, 15);
            label_total.TabIndex = 0;
            label_total.Text = "Total record(s): 0";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // dgrid_documents
            // 
            dgrid_documents.AllowUserToAddRows = false;
            dgrid_documents.AllowUserToDeleteRows = false;
            dgrid_documents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.IndianRed;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgrid_documents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgrid_documents.ColumnHeadersHeight = 50;
            dgrid_documents.Columns.AddRange(new DataGridViewColumn[] { Code, DocType, Description, Remarks, Column1 });
            dgrid_documents.Dock = DockStyle.Fill;
            dgrid_documents.Location = new Point(0, 111);
            dgrid_documents.Name = "dgrid_documents";
            dgrid_documents.ReadOnly = true;
            dgrid_documents.RowTemplate.Height = 25;
            dgrid_documents.Size = new Size(800, 312);
            dgrid_documents.TabIndex = 33;
            dgrid_documents.CellFormatting += dgrid_documents_CellFormatting;
            // 
            // Code
            // 
            Code.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Code.HeaderText = "Code";
            Code.Name = "Code";
            Code.ReadOnly = true;
            Code.Width = 80;
            // 
            // DocType
            // 
            DocType.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DocType.HeaderText = "Document Type";
            DocType.Name = "DocType";
            DocType.ReadOnly = true;
            DocType.Width = 150;
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 92;
            // 
            // Remarks
            // 
            Remarks.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Remarks.HeaderText = "Remarks";
            Remarks.Name = "Remarks";
            Remarks.ReadOnly = true;
            Remarks.Width = 77;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
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
            btn_search.Size = new Size(77, 29);
            btn_search.TabIndex = 1;
            btn_search.Text = "Search";
            btn_search.TextAlign = ContentAlignment.MiddleLeft;
            btn_search.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_search.UseVisualStyleBackColor = false;
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
            flowLayoutPanel1.Controls.Add(txt_search);
            flowLayoutPanel1.Controls.Add(btn_search);
            flowLayoutPanel1.Controls.Add(iconButton2);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 40);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 35);
            flowLayoutPanel1.TabIndex = 31;
            // 
            // panel1
            // 
            panel1.Controls.Add(label_total);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 423);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 27);
            panel1.TabIndex = 34;
            // 
            // emp_DocumentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(dgrid_documents);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "emp_DocumentsForm";
            Text = "emp_DocumentsForm";
            Load += emp_DocumentsForm_Load;
            flowLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgrid_documents).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel2;
        private FontAwesome.Sharp.IconButton btn_new;
        private FontAwesome.Sharp.IconButton btn_Edit;
        private FontAwesome.Sharp.IconButton btn_viewDocs;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label2;
        private Label label_total;
        private DataGridViewTextBoxColumn ID;
        private DataGridView dgrid_documents;
        private TextBox txt_search;
        private FontAwesome.Sharp.IconButton btn_search;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn DocType;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Remarks;
        private DataGridViewTextBoxColumn Column1;
    }
}