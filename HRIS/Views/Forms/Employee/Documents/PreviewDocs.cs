using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRIS.Models;
using HRIS.Presenter;


namespace HRIS.Views.Forms.Employee.Documents
{
    public partial class PreviewDocs : Form, IEmployeeDocumentView
    {

        private readonly EmployeeDocument_Presenter _presenter;
        public PreviewDocs(int pk_employeedocument)
        {
            InitializeComponent();
            _presenter = new EmployeeDocument_Presenter(this);
            _presenter.loadEmployeeDocs(pk_employeedocument);
        }

        public void DisplayEmployeeDocuments(List<Employeedocument> Employeedocuments)
        {
            if (Employeedocuments != null && Employeedocuments.Count > 0)
            {
                Models.Employeedocument employeedocument = Employeedocuments[0];
                byte[] documentData = employeedocument.EmployeeDocs; //db column retrieve data

                try
                {
                    if (documentData != null && documentData.Length > 0)
                    {
                        MemoryStream memoryStream = new MemoryStream(documentData);

                        using (var stream = new MemoryStream(documentData))
                        {
                            if (IsPDFStream(stream))
                            {
                                pdfViewerControl1.Load(memoryStream);
                                pdfViewerControl1.Visible = true;
                                pictureBoxDocs.Visible = false;
                            }
                            else if (IsImageStream(stream))
                            {
                                pictureBoxDocs.Image = Image.FromStream(memoryStream);
                                pictureBoxDocs.Visible = true;
                                pdfViewerControl1.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show("Unsupported document type.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Document data is empty or invalid.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading document: " + ex.Message);
                }
            }
        }
        private bool IsPDFStream(Stream stream)//retrieve pdf data
        {
            byte[] header = new byte[4];
            int bytesRead = stream.Read(header, 0, 4);
            stream.Seek(0, SeekOrigin.Begin); // Reset the stream position

            if (bytesRead == 4 &&
                header[0] == 0x25 && // %
                header[1] == 0x50 && // P
                header[2] == 0x44 && // D
                header[3] == 0x46)   // F
            {
                return true;
            }

            return false;
        }

        private bool IsImageStream(Stream stream)//retrieve data in different file extensions
        {
            byte[] header = new byte[8];
            int bytesRead = stream.Read(header, 0, 8);
            stream.Seek(0, SeekOrigin.Begin); // Reset the stream position

            // JPEG: 0xFF, 0xD8
            // PNG: 0x89, 0x50, 0x4E, 0x47
            // GIF: "GIF87a" or "GIF89a" (ASCII)

            if (bytesRead >= 2 && header[0] == 0xFF && header[1] == 0xD8) // JPEG
            {
                return true;
            }

            if (bytesRead >= 8 &&
                header[0] == 0x89 &&
                header[1] == 0x50 &&
                header[2] == 0x4E &&
                header[3] == 0x47) // PNG
            {
                return true;
            }

            if (bytesRead >= 6 &&
                (Encoding.ASCII.GetString(header, 0, 6) == "GIF87a" ||
                 Encoding.ASCII.GetString(header, 0, 6) == "GIF89a")) // GIF
            {
                return true;
            }

            // Add more formats as needed

            return false;
        }
        public void DisplayEmployeeDocumentsData(List<object> Employeedocuments)
        {

        }

        private void PreviewDocs_Load(object sender, EventArgs e)
        {

        }
    }
}
