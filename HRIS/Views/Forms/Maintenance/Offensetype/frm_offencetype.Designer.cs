namespace HRIS.Views.Forms.Maintenance.Offensetype
{
    partial class frm_offencetype
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
            txt_offenctype = new TextBox();
            label1 = new Label();
            txt_severity = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn_cancel
            // 
            btn_cancel.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(285, 131);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(72, 40);
            btn_cancel.TabIndex = 29;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = SystemColors.ActiveCaption;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(193, 131);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(86, 40);
            btn_save.TabIndex = 28;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // checkBox_isactive
            // 
            checkBox_isactive.AutoSize = true;
            checkBox_isactive.Location = new Point(89, 86);
            checkBox_isactive.Name = "checkBox_isactive";
            checkBox_isactive.Size = new Size(67, 19);
            checkBox_isactive.TabIndex = 27;
            checkBox_isactive.Text = "isActive";
            checkBox_isactive.UseVisualStyleBackColor = true;
            // 
            // txt_offenctype
            // 
            txt_offenctype.Location = new Point(89, 24);
            txt_offenctype.Name = "txt_offenctype";
            txt_offenctype.Size = new Size(268, 23);
            txt_offenctype.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 30;
            label1.Text = "Offense";
            // 
            // txt_severity
            // 
            txt_severity.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_severity.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_severity.FormattingEnabled = true;
            txt_severity.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            txt_severity.Location = new Point(89, 53);
            txt_severity.Name = "txt_severity";
            txt_severity.Size = new Size(268, 25);
            txt_severity.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 32;
            label2.Text = "Severity";
            // 
            // frm_offencetype
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(376, 183);
            Controls.Add(label2);
            Controls.Add(txt_severity);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(checkBox_isactive);
            Controls.Add(txt_offenctype);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_offencetype";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Offense type";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cancel;
        private Button btn_save;
        private CheckBox checkBox_isactive;
        private TextBox txt_offenctype;
        private Label label1;
        private ComboBox txt_severity;
        private Label label2;
    }
}