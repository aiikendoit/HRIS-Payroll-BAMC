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
            textBox15 = new TextBox();
            textBox13 = new TextBox();
            textBox10 = new TextBox();
            label22 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            button4 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_zipcode = new ComboBox();
            txt_ = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // txt_region
            // 
            txt_region.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_region.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_region.FormattingEnabled = true;
            txt_region.Location = new Point(136, 88);
            txt_region.Name = "txt_region";
            txt_region.Size = new Size(337, 23);
            txt_region.TabIndex = 6;
            txt_region.SelectedIndexChanged += txt_region_SelectedIndexChanged;
            // 
            // txt_barangay
            // 
            txt_barangay.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_barangay.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_barangay.FormattingEnabled = true;
            txt_barangay.Location = new Point(136, 163);
            txt_barangay.Name = "txt_barangay";
            txt_barangay.Size = new Size(337, 23);
            txt_barangay.TabIndex = 5;
            txt_barangay.SelectedIndexChanged += txt_barangay_SelectedIndexChanged;
            // 
            // txt_towncity
            // 
            txt_towncity.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_towncity.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_towncity.FormattingEnabled = true;
            txt_towncity.Location = new Point(136, 138);
            txt_towncity.Name = "txt_towncity";
            txt_towncity.Size = new Size(337, 23);
            txt_towncity.TabIndex = 4;
            txt_towncity.SelectedIndexChanged += txt_towncity_SelectedIndexChanged;
            // 
            // txt_province
            // 
            txt_province.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_province.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_province.FormattingEnabled = true;
            txt_province.Location = new Point(136, 113);
            txt_province.Name = "txt_province";
            txt_province.Size = new Size(337, 23);
            txt_province.TabIndex = 3;
            txt_province.SelectedIndexChanged += txt_province_SelectedIndexChanged;
            // 
            // textBox15
            // 
            textBox15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox15.Location = new Point(136, 62);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(337, 23);
            textBox15.TabIndex = 2;
            // 
            // textBox13
            // 
            textBox13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox13.Location = new Point(136, 37);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(337, 23);
            textBox13.TabIndex = 1;
            // 
            // textBox10
            // 
            textBox10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox10.Location = new Point(136, 12);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(337, 23);
            textBox10.TabIndex = 0;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(12, 92);
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
            label19.Location = new Point(12, 166);
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
            label17.Location = new Point(12, 142);
            label17.Name = "label17";
            label17.Size = new Size(61, 15);
            label17.TabIndex = 15;
            label17.Text = "Town/City";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(12, 118);
            label16.Name = "label16";
            label16.Size = new Size(84, 15);
            label16.TabIndex = 12;
            label16.Text = "Province/State";
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 152);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(234, 305);
            button4.Name = "button4";
            button4.Size = new Size(91, 36);
            button4.TabIndex = 10;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(0, 127, 152);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(137, 305);
            button3.Name = "button3";
            button3.Size = new Size(91, 36);
            button3.TabIndex = 9;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = false;
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
            label2.Location = new Point(12, 192);
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
            txt_zipcode.Location = new Point(136, 188);
            txt_zipcode.Name = "txt_zipcode";
            txt_zipcode.Size = new Size(337, 23);
            txt_zipcode.TabIndex = 7;
            // 
            // txt_
            // 
            txt_.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_.Location = new Point(136, 213);
            txt_.Multiline = true;
            txt_.Name = "txt_";
            txt_.Size = new Size(337, 85);
            txt_.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 217);
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
            ClientSize = new Size(482, 359);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(txt_zipcode);
            Controls.Add(txt_region);
            Controls.Add(txt_barangay);
            Controls.Add(txt_towncity);
            Controls.Add(txt_province);
            Controls.Add(txt_);
            Controls.Add(textBox15);
            Controls.Add(textBox13);
            Controls.Add(label2);
            Controls.Add(textBox10);
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
            Text = "7";
            Load += frm_AddressMaintenance_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox txt_region;
        private ComboBox txt_barangay;
        private ComboBox txt_towncity;
        private ComboBox txt_province;
        private TextBox textBox15;
        private TextBox textBox13;
        private TextBox textBox10;
        private Label label22;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Button button4;
        private Button button3;
        private Label label1;
        private Label label2;
        private ComboBox txt_zipcode;
        private TextBox txt_;
        private Label label3;
    }
}