namespace HRIS.Views.Forms.Maintenance.AddressFolder.ProvincesFolder
{
    partial class frm_province
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
            btn_cancel = new Button();
            btn_save = new Button();
            checkBox_isactive = new CheckBox();
            txt_province = new TextBox();
            label1 = new Label();
            txt_region = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn_cancel
            // 
            btn_cancel.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(289, 127);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(72, 40);
            btn_cancel.TabIndex = 36;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = SystemColors.ActiveCaption;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(204, 127);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(79, 40);
            btn_save.TabIndex = 35;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // checkBox_isactive
            // 
            checkBox_isactive.AutoSize = true;
            checkBox_isactive.Location = new Point(93, 84);
            checkBox_isactive.Name = "checkBox_isactive";
            checkBox_isactive.Size = new Size(67, 19);
            checkBox_isactive.TabIndex = 34;
            checkBox_isactive.Text = "isActive";
            checkBox_isactive.UseVisualStyleBackColor = true;
            // 
            // txt_province
            // 
            txt_province.Location = new Point(93, 55);
            txt_province.Name = "txt_province";
            txt_province.Size = new Size(268, 23);
            txt_province.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 58);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 37;
            label1.Text = "Province";
            // 
            // txt_region
            // 
            txt_region.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_region.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_region.FormattingEnabled = true;
            txt_region.Location = new Point(93, 26);
            txt_region.Name = "txt_region";
            txt_region.Size = new Size(268, 25);
            txt_region.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 31);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 39;
            label2.Text = "Region";
            // 
            // frm_province
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(373, 186);
            Controls.Add(label2);
            Controls.Add(txt_region);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(checkBox_isactive);
            Controls.Add(txt_province);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_province";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Province";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cancel;
        private Button btn_save;
        private CheckBox checkBox_isactive;
        private TextBox txt_province;
        private Label label1;
        private ComboBox txt_region;
        private Label label2;
    }
}