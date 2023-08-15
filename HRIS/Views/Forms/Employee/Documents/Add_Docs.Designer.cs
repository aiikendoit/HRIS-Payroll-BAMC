namespace HRIS.Views.Forms.Employee.Documents
{
    partial class Add_Docs
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
            label3 = new Label();
            comboBox_DocType = new ComboBox();
            textBox_Description = new TextBox();
            label4 = new Label();
            richTextBox_Remarks = new RichTextBox();
            label5 = new Label();
            button1 = new Button();
            btn_save = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 53);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 0;
            label2.Text = "Document Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(51, 86);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 0;
            label3.Text = "Description";
            // 
            // comboBox_DocType
            // 
            comboBox_DocType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_DocType.FormattingEnabled = true;
            comboBox_DocType.Location = new Point(148, 47);
            comboBox_DocType.Name = "comboBox_DocType";
            comboBox_DocType.Size = new Size(258, 29);
            comboBox_DocType.TabIndex = 1;
            // 
            // textBox_Description
            // 
            textBox_Description.Location = new Point(148, 82);
            textBox_Description.Name = "textBox_Description";
            textBox_Description.Size = new Size(258, 29);
            textBox_Description.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(69, 119);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 0;
            label4.Text = "Remarks";
            // 
            // richTextBox_Remarks
            // 
            richTextBox_Remarks.Location = new Point(148, 117);
            richTextBox_Remarks.Name = "richTextBox_Remarks";
            richTextBox_Remarks.Size = new Size(258, 77);
            richTextBox_Remarks.TabIndex = 3;
            richTextBox_Remarks.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 204);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 4;
            label5.Text = "filename";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.Location = new Point(148, 200);
            button1.Name = "button1";
            button1.Size = new Size(91, 29);
            button1.TabIndex = 5;
            button1.Text = "Attached";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.System;
            btn_save.Location = new Point(326, 268);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(80, 44);
            btn_save.TabIndex = 5;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // Add_Docs
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(434, 330);
            Controls.Add(btn_save);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(richTextBox_Remarks);
            Controls.Add(textBox_Description);
            Controls.Add(comboBox_DocType);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Add_Docs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Document";
            Load += Add_Docs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private ComboBox comboBox_DocType;
        private TextBox textBox_Description;
        private Label label4;
        private RichTextBox richTextBox_Remarks;
        private Label label5;
        private Button button1;
        private Button btn_save;
    }
}