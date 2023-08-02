namespace HRIS.Forms.Maintenance.Bank
{
    partial class BankForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankForm));
            flowLayoutPanel2 = new FlowLayoutPanel();
            btn_save = new FontAwesome.Sharp.IconButton();
            btn_edit = new FontAwesome.Sharp.IconButton();
            btn_view = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txt_search = new TextBox();
            btn_search = new FontAwesome.Sharp.IconButton();
            btn_refresh = new FontAwesome.Sharp.IconButton();
            dgrid_bank = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_bank).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btn_save);
            flowLayoutPanel2.Controls.Add(btn_edit);
            flowLayoutPanel2.Controls.Add(btn_view);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 72);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(673, 36);
            flowLayoutPanel2.TabIndex = 27;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(0, 127, 152);
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.ForeColor = Color.White;
            btn_save.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btn_save.IconColor = Color.White;
            btn_save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_save.IconSize = 20;
            btn_save.Location = new Point(0, 3);
            btn_save.Margin = new Padding(0, 3, 1, 3);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(73, 30);
            btn_save.TabIndex = 4;
            btn_save.Text = "New";
            btn_save.TextAlign = ContentAlignment.MiddleLeft;
            btn_save.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
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
            flowLayoutPanel1.Size = new Size(673, 35);
            flowLayoutPanel1.TabIndex = 26;
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
            // dgrid_bank
            // 
            dgrid_bank.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.IndianRed;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgrid_bank.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgrid_bank.ColumnHeadersHeight = 50;
            dgrid_bank.Dock = DockStyle.Fill;
            dgrid_bank.Location = new Point(0, 108);
            dgrid_bank.Name = "dgrid_bank";
            dgrid_bank.RowTemplate.Height = 25;
            dgrid_bank.Size = new Size(673, 262);
            dgrid_bank.TabIndex = 28;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 370);
            panel1.Name = "panel1";
            panel1.Size = new Size(673, 27);
            panel1.TabIndex = 29;
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
            label2.Size = new Size(64, 30);
            label2.TabIndex = 2;
            label2.Text = "Bank";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(673, 37);
            panel2.TabIndex = 30;
            // 
            // BankForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(673, 397);
            Controls.Add(dgrid_bank);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "BankForm";
            Text = "BankForm";
            Load += BankForm_Load;
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgrid_bank).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private FontAwesome.Sharp.IconButton btn_save;
        private FontAwesome.Sharp.IconButton btn_edit;
        private FontAwesome.Sharp.IconButton btn_view;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txt_search;
        private FontAwesome.Sharp.IconButton btn_search;
        private FontAwesome.Sharp.IconButton btn_refresh;
        private DataGridView dgrid_bank;
        private DataGridViewTextBoxColumn ID;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel2;
    }
}