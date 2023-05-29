using HRIS.Class;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Maintenance
{
    public partial class MaintenanceForm : Form
    {
        public MaintenanceForm()
        {
            InitializeComponent();
        }

        private void MaintenanceForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // The user selected a file, so we can proceed to load the picture
                string filePath = openFileDialog1.FileName;

                // Load the image from the file
                Image image = Image.FromFile(filePath);

                // Now you can use the loaded image as needed, for example, displaying it in a PictureBox control
                pictureBox2.Image = image;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_AddressMaintenance frm_AddressMaintenance = new frm_AddressMaintenance();
            frm_AddressMaintenance.ShowDialog();
        }
    }
}
