namespace HRIS.Views.Forms.Maintenance.Employment
{
    partial class frm_employmenttype
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
            txt_employmenttype = new TextBox();
            label1 = new Label();
            checkBox_organicemployee = new CheckBox();
            checkBox_inorganicemployee = new CheckBox();
            SuspendLayout();
            // 
            // btn_cancel
            // 
            btn_cancel.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(310, 130);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(72, 40);
            btn_cancel.TabIndex = 13;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = SystemColors.ActiveCaption;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(228, 130);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(76, 40);
            btn_save.TabIndex = 12;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // checkBox_isactive
            // 
            checkBox_isactive.AutoSize = true;
            checkBox_isactive.Location = new Point(116, 72);
            checkBox_isactive.Name = "checkBox_isactive";
            checkBox_isactive.Size = new Size(67, 19);
            checkBox_isactive.TabIndex = 11;
            checkBox_isactive.Text = "isActive";
            checkBox_isactive.UseVisualStyleBackColor = true;
            // 
            // txt_employmenttype
            // 
            txt_employmenttype.Location = new Point(116, 43);
            txt_employmenttype.Name = "txt_employmenttype";
            txt_employmenttype.Size = new Size(266, 23);
            txt_employmenttype.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 46);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 9;
            label1.Text = "Employment type";
            // 
            // checkBox_organicemployee
            // 
            checkBox_organicemployee.AutoSize = true;
            checkBox_organicemployee.Location = new Point(116, 97);
            checkBox_organicemployee.Name = "checkBox_organicemployee";
            checkBox_organicemployee.Size = new Size(123, 19);
            checkBox_organicemployee.TabIndex = 11;
            checkBox_organicemployee.Text = "Organic Employee";
            checkBox_organicemployee.UseVisualStyleBackColor = true;
            // 
            // checkBox_inorganicemployee
            // 
            checkBox_inorganicemployee.AutoSize = true;
            checkBox_inorganicemployee.Location = new Point(245, 97);
            checkBox_inorganicemployee.Name = "checkBox_inorganicemployee";
            checkBox_inorganicemployee.Size = new Size(133, 19);
            checkBox_inorganicemployee.TabIndex = 11;
            checkBox_inorganicemployee.Text = "InOrganic Employee";
            checkBox_inorganicemployee.UseVisualStyleBackColor = true;
            // 
            // frm_employmenttype
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(394, 193);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(checkBox_inorganicemployee);
            Controls.Add(checkBox_organicemployee);
            Controls.Add(checkBox_isactive);
            Controls.Add(txt_employmenttype);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_employmenttype";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Employment type";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cancel;
        private Button btn_save;
        private CheckBox checkBox_isactive;
        private TextBox txt_employmenttype;
        private Label label1;
        private CheckBox checkBox_organicemployee;
        private CheckBox checkBox_inorganicemployee;
    }
}