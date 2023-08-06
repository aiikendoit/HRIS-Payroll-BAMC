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

namespace HRIS.Views.Forms.Maintenance.WageFactor
{
    public partial class WageFactorForm : Form, IWageFactorView
    {
        private readonly wagefactor_Presenter wagefactor_Presenter;
        public WageFactorForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_wagefactor);
            wagefactor_Presenter = new wagefactor_Presenter(this);
            wagefactor_Presenter.LoadWagefactor();
        }

        public void DisplayWageFactor(List<Wagefactor> wageFactorList)
        {
            dgrid_wagefactor.DataSource = wageFactorList;
            dgrid_wagefactor.Columns[0].HeaderText = "ID";
            dgrid_wagefactor.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgrid_wagefactor.ColumnCount == 7)
            {
                dgrid_wagefactor.Columns.RemoveAt(6);
            }
            dgrid_wagefactor.AutoGenerateColumns = false;
            txt_totalcount.Text = "Total count(s): " + dgrid_wagefactor.RowCount.ToString();
        }

        private void dgrid_wagefactor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgrid_wagefactor.Columns[0].Width = 80;
            dgrid_wagefactor.Columns[1].Width = 100;
        }
    }
}
