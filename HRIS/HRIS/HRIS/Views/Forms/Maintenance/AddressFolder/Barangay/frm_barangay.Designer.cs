namespace HRIS.Views.Forms.Maintenance.AddressFolder.Barangay
{
    partial class frm_barangay
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
            txt_towncity = new ComboBox();
            txt_barangayname = new TextBox();
            checkBox_isactive = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            btn_save = new Button();
            txt_province = new ComboBox();
            label3 = new Label();
            btn_saveandnew = new Button();
            btn_cancel = new Button();
            SuspendLayout();
            // 
            // txt_towncity
            // 
            txt_towncity.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_towncity.FormattingEnabled = true;
            txt_towncity.Location = new Point(132, 42);
            txt_towncity.Name = "txt_towncity";
            txt_towncity.Size = new Size(308, 23);
            txt_towncity.TabIndex = 0;
            // 
            // txt_barangayname
            // 
            txt_barangayname.Location = new Point(132, 71);
            txt_barangayname.Name = "txt_barangayname";
            txt_barangayname.Size = new Size(308, 23);
            txt_barangayname.TabIndex = 1;
            // 
            // checkBox_isactive
            // 
            checkBox_isactive.AutoSize = true;
            checkBox_isactive.Location = new Point(132, 100);
            checkBox_isactive.Name = "checkBox_isactive";
            checkBox_isactive.Size = new Size(70, 19);
            checkBox_isactive.TabIndex = 2;
            checkBox_isactive.Text = "is Active";
            checkBox_isactive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 42);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 3;
            label1.Text = "Town  City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 74);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 4;
            label2.Text = "Barangay Name";
            // 
            // btn_save
            // 
            btn_save.BackColor = SystemColors.ActiveCaption;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(262, 134);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(99, 40);
            btn_save.TabIndex = 5;
            btn_save.Text = "Save && Close";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // txt_province
            // 
            txt_province.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_province.FormattingEnabled = true;
            txt_province.Location = new Point(132, 12);
            txt_province.Name = "txt_province";
            txt_province.Size = new Size(308, 23);
            txt_province.TabIndex = 0;
            txt_province.SelectedIndexChanged += txt_province_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 15);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 3;
            label3.Text = "Province";
            // 
            // btn_saveandnew
            // 
            btn_saveandnew.BackColor = SystemColors.ActiveCaption;
            btn_saveandnew.FlatAppearance.BorderSize = 0;
            btn_saveandnew.FlatStyle = FlatStyle.Flat;
            btn_saveandnew.Location = new Point(136, 134);
            btn_saveandnew.Name = "btn_saveandnew";
            btn_saveandnew.Size = new Size(120, 40);
            btn_saveandnew.TabIndex = 6;
            btn_saveandnew.Text = "Save && Create new";
            btn_saveandnew.UseVisualStyleBackColor = false;
            btn_saveandnew.Click += btn_saveandnew_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(367, 134);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(72, 40);
            btn_cancel.TabIndex = 5;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // frm_barangay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(452, 200);
            Controls.Add(btn_saveandnew);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(checkBox_isactive);
            Controls.Add(txt_barangayname);
            Controls.Add(txt_province);
            Controls.Add(txt_towncity);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_barangay";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Barangay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox txt_towncity;
        private TextBox txt_barangayname;
        private CheckBox checkBox_isactive;
        private Label label1;
        private Label label2;
        private Button btn_save;
        private ComboBox txt_province;
        private Label label3;
        private Button btn_saveandnew;
        private Button btn_cancel;
    }
}