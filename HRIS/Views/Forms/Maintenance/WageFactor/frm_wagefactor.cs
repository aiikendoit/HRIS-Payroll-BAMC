using HRIS.Class;
using HRIS.Forms.Maintenance.Degreetype;
using HRIS.Models;
using HRIS.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Views.Forms.Maintenance.WageFactor
{
    public partial class frm_wagefactor : Form, IWageFactorView
    {
        private readonly wagefactor_Presenter wagefactor_Presenter;
        private WageFactorForm WageFactorForm;
        private Models.Wagefactor Selectedwagefactor;
        public bool isupdate = false;
        public frm_wagefactor()
        {
            InitializeComponent();
            wagefactor_Presenter = new wagefactor_Presenter(this);
            WageFactorForm = new WageFactorForm();
            Selectedwagefactor = new Models.Wagefactor();
        }

        public void DisplayWageFactor(List<Wagefactor> wageFactorList)
        {
        }
        public void putdata(WageFactorForm wageFactorForm, Models.Wagefactor wagefactor)
        {
            if (isupdate)
            {
                btn_cancel.Select();
                this.WageFactorForm = wageFactorForm;
                this.Selectedwagefactor = wagefactor;
                txt_amount.Text = Selectedwagefactor.Amount.ToString();
                txt_description.Text = Selectedwagefactor.Description;
                checkBox_isactive.Checked = Selectedwagefactor.IsActive;
            }
            else
            {
                btn_cancel.Select();
                this.WageFactorForm = wageFactorForm;
                this.Selectedwagefactor = wagefactor;
                txt_amount.Text = Selectedwagefactor.Amount.ToString();
                txt_description.Text = Selectedwagefactor.Description;
                checkBox_isactive.Checked = Selectedwagefactor.IsActive;
                //disable control
                txt_amount.Enabled = false;
                txt_description.Enabled = false;
                checkBox_isactive.Enabled = false;
                btn_save.Visible = false;
            }
        }
        private void save()
        {
            if (UniversalStatic.IsEmpty(txt_amount)) return;
            if (UniversalStatic.IsEmpty(txt_description)) return;
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Models.Wagefactor
            {
                Amount = Convert.ToDecimal(txt_amount.Text),
                Description = txt_description.Text,
                IsActive = checkBox_isactive.Checked,
                Createdby = createdby,
                FkSystemUser = id
            };
            wagefactor_Presenter.AddWageFactor(cv);
            this.Close();
        }
        private void update()
        {

            var selectedwage = Selectedwagefactor as Models.Wagefactor;
            selectedwage.Amount = Convert.ToDecimal(txt_amount.Text);
            selectedwage.Description = txt_description.Text;
            selectedwage.IsActive = checkBox_isactive.Checked;
            wagefactor_Presenter.UpdateWageFactor(selectedwage);
            this.Close();
        }

        private void frm_wagefactor_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isupdate)
            {
                update();
            }
            else
            {
                save();
            }
        }
        static string ConvertAndFormatToCurrency(string input)
        {
            if (Decimal.TryParse(input, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal amount))
            {
                // Format without the dollar sign
                return amount.ToString("N");
            }
            else
            {
                return "0";
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {
            string input = txt_amount.Text;
            string formattedAmount = ConvertAndFormatToCurrency(input);
            txt_amount.Text = formattedAmount;
        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txt_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Suppress pasting
                e.SuppressKeyPress = true;
            }
        }
    }
}
