﻿namespace HRIS.Views.Forms.Employee.Documents
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
            Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings messageBoxSettings1 = new Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings();
            Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings pdfViewerPrinterSettings1 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewDocs));
            Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings textSearchSettings1 = new Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings();
            pictureBoxDocs = new PictureBox();
            pdfViewerControl1 = new Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDocs).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxDocs
            // 
            pictureBoxDocs.Dock = DockStyle.Fill;
            pictureBoxDocs.Location = new Point(0, 0);
            pictureBoxDocs.Margin = new Padding(1);
            pictureBoxDocs.Name = "pictureBoxDocs";
            pictureBoxDocs.Size = new Size(784, 561);
            pictureBoxDocs.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxDocs.TabIndex = 0;
            pictureBoxDocs.TabStop = false;
            // 
            // pdfViewerControl1
            // 
            pdfViewerControl1.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool;
            pdfViewerControl1.Dock = DockStyle.Fill;
            pdfViewerControl1.EnableContextMenu = true;
            pdfViewerControl1.EnableNotificationBar = true;
            pdfViewerControl1.HorizontalScrollOffset = 0;
            pdfViewerControl1.IsBookmarkEnabled = true;
            pdfViewerControl1.IsTextSearchEnabled = true;
            pdfViewerControl1.IsTextSelectionEnabled = true;
            pdfViewerControl1.Location = new Point(0, 0);
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
            pdfViewerControl1.Size = new Size(784, 561);
            pdfViewerControl1.SpaceBetweenPages = 8;
            pdfViewerControl1.TabIndex = 1;
            pdfViewerControl1.Text = "pdfViewerControl1";
            textSearchSettings1.CurrentInstanceColor = Color.FromArgb(127, 255, 171, 64);
            textSearchSettings1.HighlightAllInstance = true;
            textSearchSettings1.OtherInstanceColor = Color.FromArgb(127, 254, 255, 0);
            pdfViewerControl1.TextSearchSettings = textSearchSettings1;
            pdfViewerControl1.ThemeName = "Default";
            pdfViewerControl1.VerticalScrollOffset = 0;
            pdfViewerControl1.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Default;
            pdfViewerControl1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.Default;
            // 
            // PreviewDocs
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(pdfViewerControl1);
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
        private Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl pdfViewerControl1;
    }
}