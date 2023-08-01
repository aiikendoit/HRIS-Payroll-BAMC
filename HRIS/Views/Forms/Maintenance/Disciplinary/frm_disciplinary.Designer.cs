namespace HRIS.Views.Forms.Maintenance.Disciplinary
{
    partial class frm_disciplinary
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
            txt_disciplinarytype = new TextBox();
            label1 = new Label();
            txt_description = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn_cancel
            // 
            btn_cancel.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(312, 232);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(72, 40);
            btn_cancel.TabIndex = 4;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            btn_save.BackColor = SystemColors.ActiveCaption;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(220, 232);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(86, 40);
            btn_save.TabIndex = 3;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // checkBox_isactive
            // 
            checkBox_isactive.AutoSize = true;
            checkBox_isactive.Location = new Point(109, 189);
            checkBox_isactive.Name = "checkBox_isactive";
            checkBox_isactive.Size = new Size(67, 19);
            checkBox_isactive.TabIndex = 2;
            checkBox_isactive.Text = "isActive";
            checkBox_isactive.UseVisualStyleBackColor = true;
            // 
            // txt_disciplinarytype
            // 
            txt_disciplinarytype.Location = new Point(109, 35);
            txt_disciplinarytype.Name = "txt_disciplinarytype";
            txt_disciplinarytype.Size = new Size(275, 23);
            txt_disciplinarytype.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 38);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 9;
            label1.Text = "Disciplinary type";
            // 
            // txt_description
            // 
            txt_description.Location = new Point(109, 64);
            txt_description.Multiline = true;
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(275, 119);
            txt_description.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 67);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 9;
            label2.Text = "Description";
            // 
            // frm_disciplinary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(398, 294);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(checkBox_isactive);
            Controls.Add(txt_description);
            Controls.Add(txt_disciplinarytype);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_disciplinary";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Disciplinary type";
            Load += frm_disciplinary_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cancel;
        private Button btn_save;
        private CheckBox checkBox_isactive;
        private TextBox txt_disciplinarytype;
        private Label label1;
        private TextBox txt_description;
        private Label label2;
    }
}