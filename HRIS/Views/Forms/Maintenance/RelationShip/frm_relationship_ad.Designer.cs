﻿namespace HRIS.Views.Forms.Maintenance.RelationShip
{
    partial class frm_relationship_ad
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
            btn_save = new Button();
            checkBox_isactive = new CheckBox();
            label1 = new Label();
            txt_relationship = new TextBox();
            btn_cancel = new Button();
            SuspendLayout();
            // 
            // btn_save
            // 
            btn_save.BackColor = SystemColors.ActiveCaption;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Location = new Point(211, 106);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(73, 36);
            btn_save.TabIndex = 7;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // checkBox_isactive
            // 
            checkBox_isactive.AutoSize = true;
            checkBox_isactive.Location = new Point(111, 72);
            checkBox_isactive.Name = "checkBox_isactive";
            checkBox_isactive.Size = new Size(67, 19);
            checkBox_isactive.TabIndex = 6;
            checkBox_isactive.Text = "isActive";
            checkBox_isactive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 46);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 5;
            label1.Text = "Relationship";
            // 
            // txt_relationship
            // 
            txt_relationship.Location = new Point(111, 43);
            txt_relationship.Name = "txt_relationship";
            txt_relationship.Size = new Size(252, 23);
            txt_relationship.TabIndex = 4;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.White;
            btn_cancel.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(290, 106);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(73, 36);
            btn_cancel.TabIndex = 7;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // frm_relationship_ad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(392, 178);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(checkBox_isactive);
            Controls.Add(label1);
            Controls.Add(txt_relationship);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_relationship_ad";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Relationship";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_save;
        private CheckBox checkBox_isactive;
        private Label label1;
        private TextBox txt_relationship;
        private Button btn_cancel;
    }
}