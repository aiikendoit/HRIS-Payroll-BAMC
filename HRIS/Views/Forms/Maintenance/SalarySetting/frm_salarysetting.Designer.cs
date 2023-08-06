namespace HRIS.Views.Forms.Maintenance.SalarySetting
{
    partial class frm_salarysetting
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
            txt_salarytype = new TextBox();
            label1 = new Label();
            txt_employmenttype = new ComboBox();
            label2 = new Label();
            checkBox_isBasicpay = new CheckBox();
            checkBox_bonus = new CheckBox();
            checkBox_13month = new CheckBox();
            Checkbox_isPercentage = new CheckBox();
            checkBox_cola = new CheckBox();
            checkBox_taxable = new CheckBox();
            SuspendLayout();
            // 
            // btn_cancel
            // 
            btn_cancel.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(336, 187);
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
            btn_save.Location = new Point(258, 187);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(72, 40);
            btn_save.TabIndex = 28;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // checkBox_isactive
            // 
            checkBox_isactive.AutoSize = true;
            checkBox_isactive.Location = new Point(119, 88);
            checkBox_isactive.Name = "checkBox_isactive";
            checkBox_isactive.Size = new Size(67, 19);
            checkBox_isactive.TabIndex = 27;
            checkBox_isactive.Text = "isActive";
            checkBox_isactive.UseVisualStyleBackColor = true;
            // 
            // txt_salarytype
            // 
            txt_salarytype.Location = new Point(119, 59);
            txt_salarytype.Name = "txt_salarytype";
            txt_salarytype.Size = new Size(289, 23);
            txt_salarytype.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 62);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 25;
            label1.Text = "Salary type";
            // 
            // txt_employmenttype
            // 
            txt_employmenttype.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_employmenttype.FormattingEnabled = true;
            txt_employmenttype.Location = new Point(119, 30);
            txt_employmenttype.Name = "txt_employmenttype";
            txt_employmenttype.Size = new Size(289, 23);
            txt_employmenttype.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 33);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 25;
            label2.Text = "Employment type";
            // 
            // checkBox_isBasicpay
            // 
            checkBox_isBasicpay.AutoSize = true;
            checkBox_isBasicpay.Location = new Point(119, 113);
            checkBox_isBasicpay.Name = "checkBox_isBasicpay";
            checkBox_isBasicpay.Size = new Size(72, 19);
            checkBox_isBasicpay.TabIndex = 27;
            checkBox_isBasicpay.Text = "BasicPay";
            checkBox_isBasicpay.UseVisualStyleBackColor = true;
            // 
            // checkBox_bonus
            // 
            checkBox_bonus.AutoSize = true;
            checkBox_bonus.Location = new Point(298, 113);
            checkBox_bonus.Name = "checkBox_bonus";
            checkBox_bonus.Size = new Size(59, 19);
            checkBox_bonus.TabIndex = 27;
            checkBox_bonus.Text = "Bonus";
            checkBox_bonus.UseVisualStyleBackColor = true;
            // 
            // checkBox_13month
            // 
            checkBox_13month.AutoSize = true;
            checkBox_13month.Location = new Point(119, 138);
            checkBox_13month.Name = "checkBox_13month";
            checkBox_13month.Size = new Size(77, 19);
            checkBox_13month.TabIndex = 27;
            checkBox_13month.Text = "13 Month";
            checkBox_13month.UseVisualStyleBackColor = true;
            // 
            // Checkbox_isPercentage
            // 
            Checkbox_isPercentage.AutoSize = true;
            Checkbox_isPercentage.Location = new Point(200, 113);
            Checkbox_isPercentage.Name = "Checkbox_isPercentage";
            Checkbox_isPercentage.Size = new Size(85, 19);
            Checkbox_isPercentage.TabIndex = 27;
            Checkbox_isPercentage.Text = "Percentage";
            Checkbox_isPercentage.UseVisualStyleBackColor = true;
            // 
            // checkBox_cola
            // 
            checkBox_cola.AutoSize = true;
            checkBox_cola.Location = new Point(200, 138);
            checkBox_cola.Name = "checkBox_cola";
            checkBox_cola.Size = new Size(57, 19);
            checkBox_cola.TabIndex = 27;
            checkBox_cola.Text = "COLA";
            checkBox_cola.UseVisualStyleBackColor = true;
            // 
            // checkBox_taxable
            // 
            checkBox_taxable.AutoSize = true;
            checkBox_taxable.Location = new Point(298, 138);
            checkBox_taxable.Name = "checkBox_taxable";
            checkBox_taxable.Size = new Size(65, 19);
            checkBox_taxable.TabIndex = 27;
            checkBox_taxable.Text = "Taxable";
            checkBox_taxable.UseVisualStyleBackColor = true;
            // 
            // frm_salarysetting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(420, 247);
            Controls.Add(txt_employmenttype);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(checkBox_taxable);
            Controls.Add(checkBox_cola);
            Controls.Add(checkBox_13month);
            Controls.Add(Checkbox_isPercentage);
            Controls.Add(checkBox_bonus);
            Controls.Add(checkBox_isBasicpay);
            Controls.Add(checkBox_isactive);
            Controls.Add(txt_salarytype);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_salarysetting";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Salary type";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cancel;
        private Button btn_save;
        private CheckBox checkBox_isactive;
        private TextBox txt_salarytype;
        private Label label1;
        private ComboBox txt_employmenttype;
        private Label label2;
        private CheckBox checkBox_isBasicpay;
        private CheckBox checkBox_bonus;
        private CheckBox checkBox_13month;
        private CheckBox Checkbox_isPercentage;
        private CheckBox checkBox_cola;
        private CheckBox checkBox_taxable;
    }
}