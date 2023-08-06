namespace HRIS.Views.Forms.Maintenance.Leaves
{
    partial class frm_leavetype
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
            txt_leavetype = new TextBox();
            label1 = new Label();
            checkBox_isPaid = new CheckBox();
            SuspendLayout();
            // 
            // btn_cancel
            // 
            btn_cancel.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(270, 112);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(72, 40);
            btn_cancel.TabIndex = 18;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = SystemColors.ActiveCaption;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(178, 112);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(86, 40);
            btn_save.TabIndex = 17;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // checkBox_isactive
            // 
            checkBox_isactive.AutoSize = true;
            checkBox_isactive.Location = new Point(103, 66);
            checkBox_isactive.Name = "checkBox_isactive";
            checkBox_isactive.Size = new Size(67, 19);
            checkBox_isactive.TabIndex = 16;
            checkBox_isactive.Text = "isActive";
            checkBox_isactive.UseVisualStyleBackColor = true;
            // 
            // txt_leavetype
            // 
            txt_leavetype.Location = new Point(103, 37);
            txt_leavetype.Name = "txt_leavetype";
            txt_leavetype.Size = new Size(239, 23);
            txt_leavetype.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 37);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 14;
            label1.Text = "Leave type";
            // 
            // checkBox_isPaid
            // 
            checkBox_isPaid.AutoSize = true;
            checkBox_isPaid.Location = new Point(192, 66);
            checkBox_isPaid.Name = "checkBox_isPaid";
            checkBox_isPaid.Size = new Size(57, 19);
            checkBox_isPaid.TabIndex = 19;
            checkBox_isPaid.Text = "isPaid";
            checkBox_isPaid.UseVisualStyleBackColor = true;
            // 
            // frm_leavetype
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(369, 184);
            Controls.Add(checkBox_isPaid);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(checkBox_isactive);
            Controls.Add(txt_leavetype);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_leavetype";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Leave type";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cancel;
        private Button btn_save;
        private CheckBox checkBox_isactive;
        private TextBox txt_leavetype;
        private Label label1;
        private CheckBox checkBox_isPaid;
    }
}