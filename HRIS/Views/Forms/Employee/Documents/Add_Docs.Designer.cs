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
            label1 = new Label();
            employee_label = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            label5 = new Label();
            button1 = new Button();
            btn_save = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 21);
            label1.TabIndex = 0;
            label1.Text = "Employee Name";
            // 
            // employee_label
            // 
            employee_label.AutoSize = true;
            employee_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            employee_label.Location = new Point(148, 23);
            employee_label.Margin = new Padding(4, 0, 4, 0);
            employee_label.Name = "employee_label";
            employee_label.Size = new Size(31, 21);
            employee_label.TabIndex = 0;
            employee_label.Text = "___";
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(148, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(258, 29);
            comboBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 29);
            textBox1.TabIndex = 2;
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
            // richTextBox1
            // 
            richTextBox1.Location = new Point(148, 117);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(258, 77);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
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
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(employee_label);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Add_Docs";
            Text = "Add Document";
            Load += Add_Docs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label employee_label;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label4;
        private RichTextBox richTextBox1;
        private Label label5;
        private Button button1;
        private Button btn_save;
    }
}