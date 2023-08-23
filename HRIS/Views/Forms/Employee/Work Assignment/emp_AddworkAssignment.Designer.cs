namespace HRIS.Forms.Employee.Work_Assignment
{
    partial class emp_AddworkAssignment
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
            Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings messageBoxSettings1 = new Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings();
            Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings pdfViewerPrinterSettings1 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emp_AddworkAssignment));
            Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings textSearchSettings1 = new Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings();
            panel2 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            label_header = new Label();
            btn_cancel = new Button();
            btn_save = new Button();
            txt_department = new ComboBox();
            label22 = new Label();
            label19 = new Label();
            label3 = new Label();
            txt_position = new ComboBox();
            label4 = new Label();
            txt_jobdescription = new TextBox();
            label1 = new Label();
            checkBox_ishead = new CheckBox();
            txt_enddate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            txt_startdate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            btn_attachfile = new Button();
            openFileDialog1 = new OpenFileDialog();
            pdfViewerControl1 = new Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(label_header);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1084, 40);
            panel2.TabIndex = 34;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(11, 5);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // label_header
            // 
            label_header.AutoSize = true;
            label_header.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label_header.Location = new Point(46, 8);
            label_header.Name = "label_header";
            label_header.Size = new Size(215, 25);
            label_header.TabIndex = 2;
            label_header.Text = "New Work Assignment";
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.Transparent;
            btn_cancel.FlatAppearance.BorderColor = Color.FromArgb(0, 127, 152);
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Location = new Point(296, 347);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(91, 36);
            btn_cancel.TabIndex = 9;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(0, 127, 152);
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(199, 347);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(91, 36);
            btn_save.TabIndex = 8;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // txt_department
            // 
            txt_department.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_department.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_department.FormattingEnabled = true;
            txt_department.Location = new Point(117, 46);
            txt_department.Name = "txt_department";
            txt_department.Size = new Size(270, 25);
            txt_department.TabIndex = 0;
            txt_department.SelectedIndexChanged += txt_department_SelectedIndexChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(11, 312);
            label22.Name = "label22";
            label22.Size = new Size(60, 17);
            label22.TabIndex = 38;
            label22.Text = "End date";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(14, 49);
            label19.Name = "label19";
            label19.Size = new Size(77, 17);
            label19.TabIndex = 35;
            label19.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 80);
            label3.Name = "label3";
            label3.Size = new Size(54, 17);
            label3.TabIndex = 35;
            label3.Text = "Position";
            // 
            // txt_position
            // 
            txt_position.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_position.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_position.FormattingEnabled = true;
            txt_position.Location = new Point(117, 77);
            txt_position.Name = "txt_position";
            txt_position.Size = new Size(270, 25);
            txt_position.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(14, 111);
            label4.Name = "label4";
            label4.Size = new Size(99, 17);
            label4.TabIndex = 37;
            label4.Text = "Job Description";
            // 
            // txt_jobdescription
            // 
            txt_jobdescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_jobdescription.Location = new Point(118, 140);
            txt_jobdescription.Multiline = true;
            txt_jobdescription.Name = "txt_jobdescription";
            txt_jobdescription.PlaceholderText = "File Path";
            txt_jobdescription.ReadOnly = true;
            txt_jobdescription.Size = new Size(270, 94);
            txt_jobdescription.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 281);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 38;
            label1.Text = "Start date";
            // 
            // checkBox_ishead
            // 
            checkBox_ishead.AutoSize = true;
            checkBox_ishead.Location = new Point(114, 252);
            checkBox_ishead.Name = "checkBox_ishead";
            checkBox_ishead.Size = new Size(73, 19);
            checkBox_ishead.TabIndex = 5;
            checkBox_ishead.Text = "Manager";
            checkBox_ishead.UseVisualStyleBackColor = true;
            // 
            // txt_enddate
            // 
            txt_enddate.AllowNull = true;
            txt_enddate.Location = new Point(115, 309);
            txt_enddate.Name = "txt_enddate";
            txt_enddate.Size = new Size(272, 23);
            txt_enddate.TabIndex = 7;
            txt_enddate.Value = null;
            txt_enddate.Watermark = "Select a date";
            // 
            // txt_startdate
            // 
            txt_startdate.AllowNull = true;
            txt_startdate.Location = new Point(115, 281);
            txt_startdate.Name = "txt_startdate";
            txt_startdate.Size = new Size(272, 23);
            txt_startdate.TabIndex = 6;
            txt_startdate.Value = null;
            txt_startdate.Watermark = "Select a date";
            // 
            // btn_attachfile
            // 
            btn_attachfile.Location = new Point(117, 111);
            btn_attachfile.Name = "btn_attachfile";
            btn_attachfile.Size = new Size(75, 23);
            btn_attachfile.TabIndex = 39;
            btn_attachfile.Text = "Attach File";
            btn_attachfile.UseVisualStyleBackColor = true;
            btn_attachfile.Click += btn_attachfile_Click;
            // 
            // pdfViewerControl1
            // 
            pdfViewerControl1.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool;
            pdfViewerControl1.EnableContextMenu = true;
            pdfViewerControl1.EnableNotificationBar = true;
            pdfViewerControl1.HorizontalScrollOffset = 0;
            pdfViewerControl1.IsBookmarkEnabled = true;
            pdfViewerControl1.IsTextSearchEnabled = true;
            pdfViewerControl1.IsTextSelectionEnabled = true;
            pdfViewerControl1.Location = new Point(394, 46);
            messageBoxSettings1.EnableNotification = true;
            pdfViewerControl1.MessageBoxSettings = messageBoxSettings1;
            pdfViewerControl1.MinimumZoomPercentage = 50;
            pdfViewerControl1.Name = "pdfViewerControl1";
            pdfViewerControl1.PageBorderThickness = 1;
            pdfViewerPrinterSettings1.Copies = 1;
            pdfViewerPrinterSettings1.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto;
            pdfViewerPrinterSettings1.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize;
            pdfViewerPrinterSettings1.PrintLocation = (PointF)resources.GetObject("pdfViewerPrinterSettings1.PrintLocation");
            pdfViewerPrinterSettings1.ShowPrintStatusDialog = true;
            pdfViewerControl1.PrinterSettings = pdfViewerPrinterSettings1;
            pdfViewerControl1.ReferencePath = null;
            pdfViewerControl1.ScrollDisplacementValue = 0;
            pdfViewerControl1.ShowHorizontalScrollBar = true;
            pdfViewerControl1.ShowToolBar = true;
            pdfViewerControl1.ShowVerticalScrollBar = true;
            pdfViewerControl1.Size = new Size(668, 642);
            pdfViewerControl1.SpaceBetweenPages = 8;
            pdfViewerControl1.TabIndex = 40;
            pdfViewerControl1.Text = "pdfViewerControl1";
            textSearchSettings1.CurrentInstanceColor = Color.FromArgb(127, 255, 171, 64);
            textSearchSettings1.HighlightAllInstance = true;
            textSearchSettings1.OtherInstanceColor = Color.FromArgb(127, 254, 255, 0);
            pdfViewerControl1.TextSearchSettings = textSearchSettings1;
            pdfViewerControl1.VerticalScrollOffset = 0;
            pdfViewerControl1.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Default;
            pdfViewerControl1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.Default;
            // 
            // emp_AddworkAssignment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1084, 726);
            Controls.Add(pdfViewerControl1);
            Controls.Add(btn_attachfile);
            Controls.Add(txt_enddate);
            Controls.Add(txt_startdate);
            Controls.Add(checkBox_ishead);
            Controls.Add(panel2);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(txt_position);
            Controls.Add(txt_department);
            Controls.Add(txt_jobdescription);
            Controls.Add(label1);
            Controls.Add(label22);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label19);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "emp_AddworkAssignment";
            StartPosition = FormStartPosition.CenterParent;
            Load += emp_AddworkAssignment_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label_header;
        private Button btn_cancel;
        private Button btn_save;
        private ComboBox txt_department;
        private Label label22;
        private Label label19;
        private Label label3;
        private ComboBox txt_position;
        private Label label4;
        private TextBox txt_jobdescription;
        private Label label1;
        private CheckBox checkBox_ishead;
        private Syncfusion.WinForms.Input.SfDateTimeEdit txt_enddate;
        private Syncfusion.WinForms.Input.SfDateTimeEdit txt_startdate;
        private Button btn_attachfile;
        private OpenFileDialog openFileDialog1;
        private Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl pdfViewerControl1;
    }
}