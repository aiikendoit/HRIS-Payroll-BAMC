namespace HRIS.Views.Forms.Maintenance.Positions
{
    partial class frm_position
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
            btn_update = new Button();
            checkBox_isactive = new CheckBox();
            label1 = new Label();
            txt_position = new TextBox();
            txt_department = new ComboBox();
            label2 = new Label();
            dgrid_position = new DataGridView();
            btn_delete = new Button();
            btn_create = new Button();
            btn_cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgrid_position).BeginInit();
            SuspendLayout();
            // 
            // btn_update
            // 
            btn_update.Location = new Point(241, 112);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(73, 36);
            btn_update.TabIndex = 7;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // checkBox_isactive
            // 
            checkBox_isactive.AutoSize = true;
            checkBox_isactive.Location = new Point(97, 87);
            checkBox_isactive.Name = "checkBox_isactive";
            checkBox_isactive.Size = new Size(67, 19);
            checkBox_isactive.TabIndex = 6;
            checkBox_isactive.Text = "isActive";
            checkBox_isactive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 61);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 5;
            label1.Text = "Position";
            // 
            // txt_position
            // 
            txt_position.Location = new Point(97, 58);
            txt_position.Name = "txt_position";
            txt_position.Size = new Size(377, 23);
            txt_position.TabIndex = 4;
            // 
            // txt_department
            // 
            txt_department.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_department.FormattingEnabled = true;
            txt_department.Location = new Point(97, 29);
            txt_department.Name = "txt_department";
            txt_department.Size = new Size(377, 23);
            txt_department.TabIndex = 8;
            txt_department.SelectedIndexChanged += txt_department_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 32);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 9;
            label2.Text = "Department";
            // 
            // dgrid_position
            // 
            dgrid_position.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrid_position.Location = new Point(97, 154);
            dgrid_position.Name = "dgrid_position";
            dgrid_position.RowTemplate.Height = 25;
            dgrid_position.Size = new Size(377, 150);
            dgrid_position.TabIndex = 10;
            dgrid_position.CellClick += dgrid_position_CellClick;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(320, 112);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(73, 36);
            btn_delete.TabIndex = 11;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_create
            // 
            btn_create.Location = new Point(162, 112);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(73, 36);
            btn_create.TabIndex = 12;
            btn_create.Text = "Create";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(399, 112);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(73, 36);
            btn_cancel.TabIndex = 13;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // frm_position
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(499, 330);
            Controls.Add(btn_cancel);
            Controls.Add(btn_create);
            Controls.Add(btn_delete);
            Controls.Add(dgrid_position);
            Controls.Add(label2);
            Controls.Add(txt_department);
            Controls.Add(btn_update);
            Controls.Add(checkBox_isactive);
            Controls.Add(label1);
            Controls.Add(txt_position);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_position";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Position type";
            Load += frm_position_Load;
            ((System.ComponentModel.ISupportInitialize)dgrid_position).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_update;
        private CheckBox checkBox_isactive;
        private Label label1;
        private TextBox txt_position;
        private ComboBox txt_department;
        private Label label2;
        private DataGridView dgrid_position;
        private Button btn_delete;
        private Button btn_create;
        private Button btn_cancel;
    }
}