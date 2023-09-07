namespace HRIS.Forms.Maintenance
{
    partial class frm_AddressMaintenance
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
            txt_region = new ComboBox();
            txt_barangay = new ComboBox();
            txt_towncity = new ComboBox();
            txt_province = new ComboBox();
            txt_address3 = new TextBox();
            txt_address2 = new TextBox();
            txt_address1 = new TextBox();
            label22 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            btn_cancel = new Button();
            btn_save = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_zipcode = new ComboBox();
            txt_completeaddress = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // txt_region
            // 
            txt_region.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_region.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_region.FormattingEnabled = true;
            txt_region.Location = new Point(136, 164);
            txt_region.Name = "txt_region";
            txt_region.Size = new Size(337, 23);
            txt_region.TabIndex = 6;
            txt_region.TextChanged += txt_address1_TextChanged_2;
            // 
            // txt_barangay
            // 
            txt_barangay.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_barangay.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_barangay.FormattingEnabled = true;
            txt_barangay.Location = new Point(136, 139);
            txt_barangay.Name = "txt_barangay";
            txt_barangay.Size = new Size(337, 23);
            txt_barangay.TabIndex = 5;
            txt_barangay.TextChanged += txt_address1_TextChanged_2;
            // 
            // txt_towncity
            // 
            txt_towncity.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_towncity.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_towncity.FormattingEnabled = true;
            txt_towncity.Location = new Point(136, 114);
            txt_towncity.Name = "txt_towncity";
            txt_towncity.Size = new Size(337, 23);
            txt_towncity.TabIndex = 4;
            txt_towncity.SelectedIndexChanged += txt_towncity_SelectedIndexChanged_1;
            txt_towncity.TextChanged += txt_address1_TextChanged_2;
            // 
            // txt_province
            // 
            txt_province.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_province.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_province.FormattingEnabled = true;
            txt_province.Location = new Point(136, 89);
            txt_province.Name = "txt_province";
            txt_province.Size = new Size(337, 23);
            txt_province.TabIndex = 3;
            txt_province.SelectedIndexChanged += txt_province_SelectedIndexChanged_1;
            txt_province.TextChanged += txt_address1_TextChanged_2;
            // 
            // txt_address3
            // 
            txt_address3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_address3.Location = new Point(136, 62);
            txt_address3.Name = "txt_address3";
            txt_address3.Size = new Size(337, 23);
            txt_address3.TabIndex = 2;
            txt_address3.TextChanged += txt_address1_TextChanged_2;
            // 
            // txt_address2
            // 
            txt_address2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_address2.Location = new Point(136, 37);
            txt_address2.Name = "txt_address2";
            txt_address2.Size = new Size(337, 23);
            txt_address2.TabIndex = 1;
            txt_address2.TextChanged += txt_address1_TextChanged_2;
            // 
            // txt_address1
            // 
            txt_address1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_address1.Location = new Point(136, 12);
            txt_address1.Name = "txt_address1";
            txt_address1.Size = new Size(337, 23);
            txt_address1.TabIndex = 0;
            txt_address1.TextChanged += txt_address1_TextChanged_2;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(12, 168);
            label22.Name = "label22";
            label22.Size = new Size(44, 15);
            label22.TabIndex = 13;
            label22.Text = "Region";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(117, 43);
            label20.Name = "label20";
            label20.Size = new Size(13, 15);
            label20.TabIndex = 14;
            label20.Text = "2";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(12, 142);
            label19.Name = "label19";
            label19.Size = new Size(56, 15);
            label19.TabIndex = 10;
            label19.Text = "Barangay";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(12, 15);
            label18.Name = "label18";
            label18.Size = new Size(117, 15);
            label18.TabIndex = 11;
            label18.Text = "Building No./Street 1";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(12, 118);
            label17.Name = "label17";
            label17.Size = new Size(61, 15);
            label17.TabIndex = 15;
            label17.Text = "Town/City";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(12, 94);
            label16.Name = "label16";
            label16.Size = new Size(84, 15);
            label16.TabIndex = 12;
            label16.Text = "Province/State";
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.Transparent;
            btn_cancel.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 152);
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(234, 306);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(91, 36);
            btn_cancel.TabIndex = 10;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click_1;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(0, 127, 152);
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(137, 306);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(91, 36);
            btn_save.TabIndex = 9;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(117, 71);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 14;
            label1.Text = "3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 193);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 13;
            label2.Text = "ZIP Code";
            // 
            // txt_zipcode
            // 
            txt_zipcode.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_zipcode.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_zipcode.FormattingEnabled = true;
            txt_zipcode.Location = new Point(136, 189);
            txt_zipcode.Name = "txt_zipcode";
            txt_zipcode.Size = new Size(337, 23);
            txt_zipcode.TabIndex = 7;
            txt_zipcode.TextChanged += txt_address1_TextChanged_2;
            // 
            // txt_completeaddress
            // 
            txt_completeaddress.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_completeaddress.Location = new Point(136, 214);
            txt_completeaddress.Multiline = true;
            txt_completeaddress.Name = "txt_completeaddress";
            txt_completeaddress.ReadOnly = true;
            txt_completeaddress.Size = new Size(337, 85);
            txt_completeaddress.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 218);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 25;
            label3.Text = "Complete Address";
            // 
            // frm_AddressMaintenance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(482, 351);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(txt_zipcode);
            Controls.Add(txt_region);
            Controls.Add(txt_barangay);
            Controls.Add(txt_towncity);
            Controls.Add(txt_province);
            Controls.Add(txt_completeaddress);
            Controls.Add(txt_address3);
            Controls.Add(txt_address2);
            Controls.Add(label2);
            Controls.Add(txt_address1);
            Controls.Add(label22);
            Controls.Add(label1);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_AddressMaintenance";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Address Information";
            Load += frm_AddressMaintenance_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox txt_region;
        private ComboBox txt_barangay;
        private ComboBox txt_towncity;
        private ComboBox txt_province;
        private TextBox txt_address3;
        private TextBox txt_address2;
        private TextBox txt_address1;
        private Label label22;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Button btn_cancel;
        private Button btn_save;
        private Label label1;
        private Label label2;
        private ComboBox txt_zipcode;
        private TextBox txt_completeaddress;
        private Label label3;
    }
}