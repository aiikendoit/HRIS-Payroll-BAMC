using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using HRIS.Views.Forms.Maintenance.Disciplinary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Maintenance.Disciplinary
{
    public partial class DiscplinaryForm : Form, IDisciplinaryView
    {
        private readonly disciplinarytype_Presenter disciplinarytype_Presenter;
        public DiscplinaryForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_disciplinary);
            disciplinarytype_Presenter = new disciplinarytype_Presenter(this);
            disciplinarytype_Presenter.LoadDisciplinary();
        }

        public void DisplayDisciplinaryType(List<Disciplinarytype> disciplinaries)
        {
            dgrid_disciplinary.DataSource = disciplinaries;
            dgrid_disciplinary.Columns[0].HeaderText = "ID";
            dgrid_disciplinary.Columns[1].HeaderText = "Disciplinary type";
            dgrid_disciplinary.Columns["Createddate"].HeaderText = "Created date";
            dgrid_disciplinary.Columns["Createdby"].HeaderText = "Created by";
            dgrid_disciplinary.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgrid_disciplinary.ColumnCount == 7)
            {
                //Remove unnecessary column
                dgrid_disciplinary.Columns.RemoveAt(6);
                dgrid_disciplinary.Columns.RemoveAt(2);
            }
            dgrid_disciplinary.AutoGenerateColumns = false;
            txt_totalcount.Text = "Total record(s): " + dgrid_disciplinary.RowCount.ToString();
        }

        private void DiscplinaryForm_Load(object sender, EventArgs e)
        {

        }

        private void dgrid_disciplinary_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgrid_disciplinary.Columns[0].Width = 80;
            dgrid_disciplinary.Columns[1].Width = 250;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            var dp = new frm_disciplinary();
            dp.ShowDialog();
            disciplinarytype_Presenter.LoadDisciplinary();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var selecteddisciplinary = dgrid_disciplinary.SelectedRows[0].DataBoundItem as Disciplinarytype;
            if (selecteddisciplinary != null)
            {
                var dp = new frm_disciplinary();
                dp.isupdate = true;
                dp.putdata(this, selecteddisciplinary);
                dp.ShowDialog(this);
                disciplinarytype_Presenter.LoadDisciplinary();
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            var selecteddisciplinary = dgrid_disciplinary.SelectedRows[0].DataBoundItem as Disciplinarytype;
            if (selecteddisciplinary != null)
            {
                var dp = new frm_disciplinary();
                dp.putdata(this, selecteddisciplinary);
                dp.ShowDialog(this);
                disciplinarytype_Presenter.LoadDisciplinary();
            }
        }
    }
}
