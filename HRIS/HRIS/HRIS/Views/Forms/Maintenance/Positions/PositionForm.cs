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

namespace HRIS.Views.Forms.Maintenance.Positions
{
    public partial class PositionForm : Form, IPositionView
    {
        private readonly position_Presenter position_presenter;
        public PositionForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_position);
            position_presenter = new position_Presenter(this);
            position_presenter.LoadPosition();
        }

        public void DisplayPosition(List<Position> positions)
        {
            dgrid_position.DataSource = positions;
            dgrid_position.Columns[0].HeaderText = "ID";
            if (dgrid_position.ColumnCount == 10)
            {
                //Remove unnecessary column
                dgrid_position.Columns.RemoveAt(8);
                dgrid_position.Columns.RemoveAt(7);
                dgrid_position.Columns.RemoveAt(6);
                dgrid_position.Columns.RemoveAt(1);
            }
            dgrid_position.AutoGenerateColumns = false;
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            var p = new frm_position();
            p.ShowDialog();
        }
    }
}
