namespace HRIS.Views.Forms.Maintenance.Bank
{
    partial class frm_bank_add
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
            btn_save = new Button();
            checkBox_isactive = new CheckBox();
            label1 = new Label();
            txt_bank = new TextBox();
            btn_cancel = new Button();
            SuspendLayout();
            // 
            // btn_save
            // 
            btn_save.BackColor = SystemColors.ActiveCaption;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(228, 103);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(81, 40);
            btn_save.TabIndex = 7;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // checkBox_isactive
            // 
            checkBox_isactive.AutoSize = true;
            checkBox_isactive.Location = new Point(107, 68);
            checkBox_isactive.Name = "checkBox_isactive";
            checkBox_isactive.Size = new Size(67, 19);
            checkBox_isactive.TabIndex = 6;
            checkBox_isactive.Text = "isActive";
            checkBox_isactive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 42);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 5;
            label1.Text = "Bank name";
            // 
            // txt_bank
            // 
            txt_bank.Location = new Point(107, 39);
            txt_bank.Name = "txt_bank";
            txt_bank.Size = new Size(280, 23);
            txt_bank.TabIndex = 4;
            // 
            // btn_cancel
            // 
            btn_cancel.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(315, 103);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(72, 40);
            btn_cancel.TabIndex = 8;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // frm_bank_add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(399, 167);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(checkBox_isactive);
            Controls.Add(label1);
            Controls.Add(txt_bank);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_bank_add";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bank";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_save;
        private CheckBox checkBox_isactive;
        private Label label1;
        private TextBox txt_bank;
        private Button btn_cancel;
    }
}