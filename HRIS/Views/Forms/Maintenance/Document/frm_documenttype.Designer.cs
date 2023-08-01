namespace HRIS.Views.Forms.Maintenance.Document
{
    partial class frm_documenttype
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
            txt_documenttype = new TextBox();
            label1 = new Label();
            checkBox_isCertificate = new CheckBox();
            SuspendLayout();
            // 
            // btn_cancel
            // 
            btn_cancel.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(324, 108);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(72, 40);
            btn_cancel.TabIndex = 13;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            btn_save.BackColor = SystemColors.ActiveCaption;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(232, 108);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(86, 40);
            btn_save.TabIndex = 12;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // checkBox_isactive
            // 
            checkBox_isactive.AutoSize = true;
            checkBox_isactive.Location = new Point(107, 65);
            checkBox_isactive.Name = "checkBox_isactive";
            checkBox_isactive.Size = new Size(67, 19);
            checkBox_isactive.TabIndex = 11;
            checkBox_isactive.Text = "isActive";
            checkBox_isactive.UseVisualStyleBackColor = true;
            // 
            // txt_documenttype
            // 
            txt_documenttype.Location = new Point(107, 36);
            txt_documenttype.Name = "txt_documenttype";
            txt_documenttype.Size = new Size(289, 23);
            txt_documenttype.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 39);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 9;
            label1.Text = "Document type";
            // 
            // checkBox_isCertificate
            // 
            checkBox_isCertificate.AutoSize = true;
            checkBox_isCertificate.Location = new Point(180, 65);
            checkBox_isCertificate.Name = "checkBox_isCertificate";
            checkBox_isCertificate.Size = new Size(88, 19);
            checkBox_isCertificate.TabIndex = 11;
            checkBox_isCertificate.Text = "isCertificate";
            checkBox_isCertificate.UseVisualStyleBackColor = true;
            // 
            // frm_documenttype
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(408, 173);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(checkBox_isCertificate);
            Controls.Add(checkBox_isactive);
            Controls.Add(txt_documenttype);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_documenttype";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Document Type";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cancel;
        private Button btn_save;
        private CheckBox checkBox_isactive;
        private TextBox txt_documenttype;
        private Label label1;
        private CheckBox checkBox_isCertificate;
    }
}