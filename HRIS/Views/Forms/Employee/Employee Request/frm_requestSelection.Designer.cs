namespace HRIS.Views.Forms.Employee.Employee_Request
{
    partial class frm_requestSelection
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_leaves = new FontAwesome.Sharp.IconButton();
            btn_advances = new FontAwesome.Sharp.IconButton();
            btn_schedule = new FontAwesome.Sharp.IconButton();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btn_leaves);
            flowLayoutPanel1.Controls.Add(btn_advances);
            flowLayoutPanel1.Controls.Add(btn_schedule);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(532, 329);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_leaves
            // 
            btn_leaves.BackColor = Color.FromArgb(0, 127, 152);
            btn_leaves.FlatAppearance.BorderSize = 0;
            btn_leaves.FlatStyle = FlatStyle.Flat;
            btn_leaves.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_leaves.ForeColor = Color.White;
            btn_leaves.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            btn_leaves.IconColor = Color.White;
            btn_leaves.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_leaves.IconSize = 40;
            btn_leaves.Location = new Point(8, 8);
            btn_leaves.Margin = new Padding(3, 3, 5, 3);
            btn_leaves.Name = "btn_leaves";
            btn_leaves.Size = new Size(166, 83);
            btn_leaves.TabIndex = 5;
            btn_leaves.Text = "LEAVES";
            btn_leaves.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_leaves.UseVisualStyleBackColor = false;
            btn_leaves.Click += btn_leaves_Click;
            // 
            // btn_advances
            // 
            btn_advances.BackColor = Color.FromArgb(0, 127, 152);
            btn_advances.FlatAppearance.BorderSize = 0;
            btn_advances.FlatStyle = FlatStyle.Flat;
            btn_advances.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_advances.ForeColor = Color.White;
            btn_advances.IconChar = FontAwesome.Sharp.IconChar.HandHoldingUsd;
            btn_advances.IconColor = Color.White;
            btn_advances.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_advances.IconSize = 40;
            btn_advances.Location = new Point(182, 8);
            btn_advances.Margin = new Padding(3, 3, 5, 3);
            btn_advances.Name = "btn_advances";
            btn_advances.Size = new Size(166, 83);
            btn_advances.TabIndex = 6;
            btn_advances.Text = "ADVANCES";
            btn_advances.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_advances.UseVisualStyleBackColor = false;
            // 
            // btn_schedule
            // 
            btn_schedule.BackColor = Color.FromArgb(0, 127, 152);
            btn_schedule.FlatAppearance.BorderSize = 0;
            btn_schedule.FlatStyle = FlatStyle.Flat;
            btn_schedule.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_schedule.ForeColor = Color.White;
            btn_schedule.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            btn_schedule.IconColor = Color.White;
            btn_schedule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_schedule.IconSize = 40;
            btn_schedule.Location = new Point(356, 8);
            btn_schedule.Margin = new Padding(3, 3, 5, 3);
            btn_schedule.Name = "btn_schedule";
            btn_schedule.Size = new Size(166, 83);
            btn_schedule.TabIndex = 7;
            btn_schedule.Text = "SCHEDULE";
            btn_schedule.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_schedule.UseVisualStyleBackColor = false;
            // 
            // frm_requestSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 329);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_requestSelection";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Request Selection";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton btn_leaves;
        private FontAwesome.Sharp.IconButton btn_advances;
        private FontAwesome.Sharp.IconButton btn_schedule;
    }
}