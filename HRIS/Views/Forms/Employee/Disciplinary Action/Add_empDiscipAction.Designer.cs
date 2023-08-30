namespace HRIS.Views.Forms.Employee.Disciplinary_Action
{
    partial class Add_empDiscipAction
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
            label2 = new Label();
            label3 = new Label();
            textBox_Description = new TextBox();
            comboBox_offenseType = new ComboBox();
            comboBox_discplnryType = new ComboBox();
            button_attach = new Button();
            label_filePath = new Label();
            btn_save = new Button();
            dateTimePicker_Start = new DateTimePicker();
            dateTimePicker_End = new DateTimePicker();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 0;
            label1.Text = "Offense Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 67);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 0;
            label2.Text = "Disciplinary Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 105);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 0;
            label3.Text = "Description";
            // 
            // textBox_Description
            // 
            textBox_Description.Location = new Point(165, 100);
            textBox_Description.Name = "textBox_Description";
            textBox_Description.Size = new Size(260, 29);
            textBox_Description.TabIndex = 1;
            // 
            // comboBox_offenseType
            // 
            comboBox_offenseType.FormattingEnabled = true;
            comboBox_offenseType.Location = new Point(165, 26);
            comboBox_offenseType.Name = "comboBox_offenseType";
            comboBox_offenseType.Size = new Size(260, 29);
            comboBox_offenseType.TabIndex = 2;
            // 
            // comboBox_discplnryType
            // 
            comboBox_discplnryType.FormattingEnabled = true;
            comboBox_discplnryType.Location = new Point(165, 63);
            comboBox_discplnryType.Name = "comboBox_discplnryType";
            comboBox_discplnryType.Size = new Size(260, 29);
            comboBox_discplnryType.TabIndex = 2;
            // 
            // button_attach
            // 
            button_attach.Location = new Point(165, 170);
            button_attach.Name = "button_attach";
            button_attach.Size = new Size(75, 29);
            button_attach.TabIndex = 3;
            button_attach.Text = "Attach";
            button_attach.UseVisualStyleBackColor = true;
            button_attach.Click += button_attach_Click;
            // 
            // label_filePath
            // 
            label_filePath.AutoSize = true;
            label_filePath.Location = new Point(247, 174);
            label_filePath.Margin = new Padding(4, 0, 4, 0);
            label_filePath.MaximumSize = new Size(173, 21);
            label_filePath.MinimumSize = new Size(100, 21);
            label_filePath.Name = "label_filePath";
            label_filePath.Size = new Size(100, 21);
            label_filePath.TabIndex = 0;
            label_filePath.Text = "File Path";
            // 
            // btn_save
            // 
            btn_save.Location = new Point(337, 219);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(88, 41);
            btn_save.TabIndex = 3;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // dateTimePicker_Start
            // 
            dateTimePicker_Start.Format = DateTimePickerFormat.Short;
            dateTimePicker_Start.Location = new Point(165, 135);
            dateTimePicker_Start.MaxDate = new DateTime(2023, 8, 30, 0, 0, 0, 0);
            dateTimePicker_Start.Name = "dateTimePicker_Start";
            dateTimePicker_Start.Size = new Size(128, 29);
            dateTimePicker_Start.TabIndex = 4;
            dateTimePicker_Start.Value = new DateTime(2023, 8, 30, 0, 0, 0, 0);
            // 
            // dateTimePicker_End
            // 
            dateTimePicker_End.Format = DateTimePickerFormat.Short;
            dateTimePicker_End.Location = new Point(299, 135);
            dateTimePicker_End.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dateTimePicker_End.MinDate = new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dateTimePicker_End.Name = "dateTimePicker_End";
            dateTimePicker_End.Size = new Size(126, 29);
            dateTimePicker_End.TabIndex = 4;
            dateTimePicker_End.Value = new DateTime(2023, 8, 30, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 141);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 0;
            label4.Text = "Start / End";
            // 
            // Add_empDiscipAction
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 282);
            Controls.Add(dateTimePicker_End);
            Controls.Add(dateTimePicker_Start);
            Controls.Add(btn_save);
            Controls.Add(button_attach);
            Controls.Add(comboBox_discplnryType);
            Controls.Add(comboBox_offenseType);
            Controls.Add(textBox_Description);
            Controls.Add(label_filePath);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Add_empDiscipAction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Disciplinary Action";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox_Description;
        private ComboBox comboBox_offenseType;
        private ComboBox comboBox_discplnryType;
        private Button button_attach;
        private Label label_filePath;
        private Button btn_save;
        private DateTimePicker dateTimePicker_Start;
        private DateTimePicker dateTimePicker_End;
        private Label label4;
    }
}