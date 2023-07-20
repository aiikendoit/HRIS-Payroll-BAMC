using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRIS.Views.Forms.Maintenance.NationalityFolder;

namespace HRIS.Views.Forms.Maintenance.NationalityFolder
{
    public partial class NationalityForm : Form, INationalityView
    {
        private readonly nationality_Presenter _presenter;
        public NationalityForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_nationality);
            _presenter = new nationality_Presenter(this);
            _presenter.loadNationality();
        }

        public void ClearFields()
        {
        }

        public void DisplayNationality(List<Nationality> Nationalities)
        {
            dgrid_nationality.DataSource = Nationalities;
            dgrid_nationality.Columns[0].HeaderText = "ID";
            if (dgrid_nationality.ColumnCount == 7)
            {
                //Remove unnecessary column
                dgrid_nationality.Columns.RemoveAt(6);
                dgrid_nationality.Columns.RemoveAt(5);
            }
            dgrid_nationality.AutoGenerateColumns = false;
        }

        private void NationalityForm_Load(object sender, EventArgs e)
        {

        }
    }
}
