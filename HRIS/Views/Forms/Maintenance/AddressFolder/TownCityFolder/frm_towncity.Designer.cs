namespace HRIS.Views.Forms.Maintenance.AddressFolder.TownCityFolder
{
    partial class frm_towncity
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
            label2 = new Label();
            drpdwn_province = new ComboBox();
            btn_cancel = new Button();
            btn_save = new Button();
            checkBox_isactive = new CheckBox();
            txt_towncity = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 28);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 46;
            label2.Text = "Province";
            // 
            // drpdwn_province
            // 
            drpdwn_province.DropDownStyle = ComboBoxStyle.DropDownList;
            drpdwn_province.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            drpdwn_province.FormattingEnabled = true;
            drpdwn_province.Location = new Point(99, 23);
            drpdwn_province.Name = "drpdwn_province";
            drpdwn_province.Size = new Size(256, 25);
            drpdwn_province.TabIndex = 45;
            // 
            // btn_cancel
            // 
            btn_cancel.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(283, 124);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(72, 40);
            btn_cancel.TabIndex = 43;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = SystemColors.ActiveCaption;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(198, 124);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(79, 40);
            btn_save.TabIndex = 42;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // checkBox_isactive
            // 
            checkBox_isactive.AutoSize = true;
            checkBox_isactive.Location = new Point(99, 81);
            checkBox_isactive.Name = "checkBox_isactive";
            checkBox_isactive.Size = new Size(67, 19);
            checkBox_isactive.TabIndex = 41;
            checkBox_isactive.Text = "isActive";
            checkBox_isactive.UseVisualStyleBackColor = true;
            // 
            // txt_towncity
            // 
            txt_towncity.Location = new Point(99, 52);
            txt_towncity.Name = "txt_towncity";
            txt_towncity.Size = new Size(256, 23);
            txt_towncity.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 44;
            label1.Text = "Town / City";
            // 
            // frm_towncity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 186);
            Controls.Add(label2);
            Controls.Add(drpdwn_province);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(checkBox_isactive);
            Controls.Add(txt_towncity);
            Controls.Add(label1);
            Name = "frm_towncity";
            Text = "frm_towncity";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox drpdwn_province;
        private Button btn_cancel;
        private Button btn_save;
        private CheckBox checkBox_isactive;
        private TextBox txt_towncity;
        private Label label1;
    }
}