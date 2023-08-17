namespace HRIS.Views.Forms.Employee.Documents
{
    partial class PreviewDocs
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
            pictureBoxDocs = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDocs).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxDocs
            // 
            pictureBoxDocs.Location = new Point(10, 10);
            pictureBoxDocs.Margin = new Padding(1);
            pictureBoxDocs.Name = "pictureBoxDocs";
            pictureBoxDocs.Size = new Size(100, 50);
            pictureBoxDocs.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxDocs.TabIndex = 0;
            pictureBoxDocs.TabStop = false;
            // 
            // PreviewDocs
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(pictureBoxDocs);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "PreviewDocs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Preview Document";
            Load += PreviewDocs_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxDocs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxDocs;
    }
}