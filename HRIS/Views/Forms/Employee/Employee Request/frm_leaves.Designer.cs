namespace HRIS.Views.Forms.Employee.Employee_Request
{
    partial class frm_leaves
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
            panel1 = new Panel();
            label1 = new Label();
            txt_name = new TextBox();
            label2 = new Label();
            txt_leavetype = new ComboBox();
            label3 = new Label();
            txt_leavecredits = new TextBox();
            panel2 = new Panel();
            label4 = new Label();
            radiobtn_staggered = new RadioButton();
            radiobtn_onefullweek = new RadioButton();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txt_leavetype);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_leavecredits);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(663, 93);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(81, 18);
            txt_name.Name = "txt_name";
            txt_name.ReadOnly = true;
            txt_name.Size = new Size(236, 23);
            txt_name.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Leave Type";
            // 
            // txt_leavetype
            // 
            txt_leavetype.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_leavetype.FormattingEnabled = true;
            txt_leavetype.Location = new Point(82, 47);
            txt_leavetype.Name = "txt_leavetype";
            txt_leavetype.Size = new Size(235, 23);
            txt_leavetype.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(329, 51);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 0;
            label3.Text = "Leave credits";
            // 
            // txt_leavecredits
            // 
            txt_leavecredits.Location = new Point(410, 47);
            txt_leavecredits.Name = "txt_leavecredits";
            txt_leavecredits.ReadOnly = true;
            txt_leavecredits.Size = new Size(236, 23);
            txt_leavecredits.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(663, 5);
            panel2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 109);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 2;
            label4.Text = "Request Type";
            // 
            // radiobtn_staggered
            // 
            radiobtn_staggered.AutoSize = true;
            radiobtn_staggered.Location = new Point(87, 134);
            radiobtn_staggered.Name = "radiobtn_staggered";
            radiobtn_staggered.Size = new Size(78, 19);
            radiobtn_staggered.TabIndex = 3;
            radiobtn_staggered.TabStop = true;
            radiobtn_staggered.Text = "Staggered";
            radiobtn_staggered.UseVisualStyleBackColor = true;
            // 
            // radiobtn_onefullweek
            // 
            radiobtn_onefullweek.AutoSize = true;
            radiobtn_onefullweek.Location = new Point(171, 134);
            radiobtn_onefullweek.Name = "radiobtn_onefullweek";
            radiobtn_onefullweek.Size = new Size(104, 19);
            radiobtn_onefullweek.TabIndex = 3;
            radiobtn_onefullweek.TabStop = true;
            radiobtn_onefullweek.Text = "One Full Week ";
            radiobtn_onefullweek.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 180);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 2;
            label5.Text = "Date From";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(87, 176);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(127, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(228, 180);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 2;
            label6.Text = "Date to";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(279, 176);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(127, 23);
            dateTimePicker2.TabIndex = 4;
            // 
            // frm_leaves
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(663, 501);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(radiobtn_onefullweek);
            Controls.Add(radiobtn_staggered);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Name = "frm_leaves";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Leaves";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox txt_leavetype;
        private Label label2;
        private TextBox txt_leavecredits;
        private Label label3;
        private TextBox txt_name;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private RadioButton radiobtn_staggered;
        private RadioButton radiobtn_onefullweek;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private DateTimePicker dateTimePicker2;
    }
}