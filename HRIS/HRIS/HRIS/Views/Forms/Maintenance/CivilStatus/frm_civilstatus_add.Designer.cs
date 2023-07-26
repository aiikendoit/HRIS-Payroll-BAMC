namespace HRIS.Views.Forms.Maintenance.CivilStatus
{
    partial class frm_civilstatus_add
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
            txt_civilstatus = new TextBox();
            label1 = new Label();
            checkBox_isactive = new CheckBox();
            btn_save = new Button();
            SuspendLayout();
            // 
            // txt_civilstatus
            // 
            txt_civilstatus.Location = new Point(108, 40);
            txt_civilstatus.Name = "txt_civilstatus";
            txt_civilstatus.Size = new Size(218, 23);
            txt_civilstatus.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 43);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "Civil Status";
            // 
            // checkBox_isactive
            // 
            checkBox_isactive.AutoSize = true;
            checkBox_isactive.Location = new Point(108, 69);
            checkBox_isactive.Name = "checkBox_isactive";
            checkBox_isactive.Size = new Size(67, 19);
            checkBox_isactive.TabIndex = 2;
            checkBox_isactive.Text = "isActive";
            checkBox_isactive.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(253, 107);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(73, 36);
            btn_save.TabIndex = 3;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // frm_civilstatus_add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(360, 155);
            Controls.Add(btn_save);
            Controls.Add(checkBox_isactive);
            Controls.Add(label1);
            Controls.Add(txt_civilstatus);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_civilstatus_add";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Civil Status";
            Load += frm_civilstatus_add_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_civilstatus;
        private Label label1;
        private CheckBox checkBox_isactive;
        private Button btn_save;
    }
}