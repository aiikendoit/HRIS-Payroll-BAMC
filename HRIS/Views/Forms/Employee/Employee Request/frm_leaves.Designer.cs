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
            btn_cancel = new Button();
            btn_save = new Button();
            panel3 = new Panel();
            txt_dateto = new DateTimePicker();
            txt_datefrom = new DateTimePicker();
            radiobtn_onefullweek = new RadioButton();
            txt_totaldays = new TextBox();
            label7 = new Label();
            radiobtn_staggered = new RadioButton();
            label6 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            txt_leavetype = new ComboBox();
            label2 = new Label();
            txt_leavecredits = new TextBox();
            label3 = new Label();
            txt_name = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.Transparent;
            btn_cancel.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 152);
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(572, 709);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(91, 36);
            btn_cancel.TabIndex = 45;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(0, 127, 152);
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(475, 709);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(91, 36);
            btn_save.TabIndex = 44;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(txt_dateto);
            panel3.Controls.Add(txt_datefrom);
            panel3.Controls.Add(radiobtn_onefullweek);
            panel3.Controls.Add(txt_totaldays);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(radiobtn_staggered);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(panel1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(878, 248);
            panel3.TabIndex = 48;
            // 
            // txt_dateto
            // 
            txt_dateto.Format = DateTimePickerFormat.Short;
            txt_dateto.Location = new Point(277, 167);
            txt_dateto.Name = "txt_dateto";
            txt_dateto.Size = new Size(127, 23);
            txt_dateto.TabIndex = 11;
            txt_dateto.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // txt_datefrom
            // 
            txt_datefrom.Format = DateTimePickerFormat.Short;
            txt_datefrom.Location = new Point(85, 167);
            txt_datefrom.Name = "txt_datefrom";
            txt_datefrom.Size = new Size(127, 23);
            txt_datefrom.TabIndex = 12;
            txt_datefrom.ValueChanged += txt_datefrom_ValueChanged;
            // 
            // radiobtn_onefullweek
            // 
            radiobtn_onefullweek.AutoSize = true;
            radiobtn_onefullweek.Location = new Point(171, 136);
            radiobtn_onefullweek.Name = "radiobtn_onefullweek";
            radiobtn_onefullweek.Size = new Size(104, 19);
            radiobtn_onefullweek.TabIndex = 9;
            radiobtn_onefullweek.TabStop = true;
            radiobtn_onefullweek.Text = "One Full Week ";
            radiobtn_onefullweek.UseVisualStyleBackColor = true;
            // 
            // txt_totaldays
            // 
            txt_totaldays.Location = new Point(85, 196);
            txt_totaldays.Name = "txt_totaldays";
            txt_totaldays.ReadOnly = true;
            txt_totaldays.Size = new Size(127, 23);
            txt_totaldays.TabIndex = 1;
            txt_totaldays.Text = "1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 199);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 0;
            label7.Text = "Total days";
            // 
            // radiobtn_staggered
            // 
            radiobtn_staggered.AutoSize = true;
            radiobtn_staggered.Location = new Point(87, 136);
            radiobtn_staggered.Name = "radiobtn_staggered";
            radiobtn_staggered.Size = new Size(78, 19);
            radiobtn_staggered.TabIndex = 10;
            radiobtn_staggered.TabStop = true;
            radiobtn_staggered.Text = "Staggered";
            radiobtn_staggered.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(226, 171);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 6;
            label6.Text = "Date to";
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
            panel1.Size = new Size(878, 93);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(878, 5);
            panel2.TabIndex = 4;
            // 
            // txt_leavetype
            // 
            txt_leavetype.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_leavetype.FormattingEnabled = true;
            txt_leavetype.Location = new Point(82, 47);
            txt_leavetype.Name = "txt_leavetype";
            txt_leavetype.Size = new Size(235, 23);
            txt_leavetype.TabIndex = 3;
            txt_leavetype.SelectedIndexChanged += txt_leavetype_SelectedIndexChanged;
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
            // txt_leavecredits
            // 
            txt_leavecredits.Location = new Point(410, 47);
            txt_leavecredits.Name = "txt_leavecredits";
            txt_leavecredits.ReadOnly = true;
            txt_leavecredits.Size = new Size(236, 23);
            txt_leavecredits.TabIndex = 1;
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
            // txt_name
            // 
            txt_name.Location = new Point(81, 18);
            txt_name.Name = "txt_name";
            txt_name.ReadOnly = true;
            txt_name.Size = new Size(236, 23);
            txt_name.TabIndex = 1;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 171);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 7;
            label5.Text = "Date From";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 111);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 8;
            label4.Text = "Request Type";
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 248);
            panel4.Name = "panel4";
            panel4.Size = new Size(878, 403);
            panel4.TabIndex = 49;
            // 
            // frm_leaves
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(878, 757);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Name = "frm_leaves";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Leaves";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_cancel;
        private Button btn_save;
        private Panel panel3;
        private DateTimePicker txt_dateto;
        private DateTimePicker txt_datefrom;
        private RadioButton radiobtn_onefullweek;
        private TextBox txt_totaldays;
        private Label label7;
        private RadioButton radiobtn_staggered;
        private Label label6;
        private Panel panel1;
        private Panel panel2;
        private ComboBox txt_leavetype;
        private Label label2;
        private TextBox txt_leavecredits;
        private Label label3;
        private TextBox txt_name;
        private Label label1;
        private Label label5;
        private Label label4;
        private Panel panel4;
    }
}