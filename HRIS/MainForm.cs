using HRIS.Classes;

namespace HRIS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World!");
            Testmessage ts = new Testmessage();
            ts.testaccess();
           
        }
    }
}