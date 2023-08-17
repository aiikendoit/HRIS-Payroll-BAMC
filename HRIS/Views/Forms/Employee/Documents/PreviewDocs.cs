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
        //private string _imagePath;
        //private byte[] _imageData;
        //public PreviewDocs(string? imagePath)
        private readonly EmployeeDocument_Presenter _presenter;
        public PreviewDocs(int pk_employeedocument)
        {
            InitializeComponent();
            _presenter = new EmployeeDocument_Presenter(this);
            _presenter.loadEmployeeDocs(pk_employeedocument);
        }

        public void DisplayEmployeeDocuments(List<Employeedocument> Employeedocuments)
        {
            //preview document
            if (Employeedocuments != null && Employeedocuments.Count > 0)
            {
                Models.Employeedocument employeedocument = Employeedocuments[0];
                byte[] img = employeedocument.EmployeeDocs;

                try
                {
                    if (img != null && img.Length > 0)
                    {
                        using (MemoryStream memoryStream = new MemoryStream(img))
                        {
                            // Set the stream position to the beginning
                            memoryStream.Seek(0, SeekOrigin.Begin);

                            // Load the image from the stream
                            pictureBoxDocs.Image = Image.FromStream(memoryStream);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Image data is empty or invalid.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }


        }

        public void DisplayEmployeeDocumentsData(List<object> Employeedocuments)
        {

        }

        private void PreviewDocs_Load(object sender, EventArgs e)
        {

        }
    }
}
