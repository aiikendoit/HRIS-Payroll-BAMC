using HRIS.Forms.Maintenance.Bank;
using HRIS.Forms.Maintenance.CivilStatus;
using HRIS.Models;
using HRIS.Presenter;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Views.Forms.Maintenance.Bank
{
    public partial class frm_bank_add : Form, IBankView
    {
        private readonly bank_Presenter bank_Presenter;
        private BankForm bankForm;
        private Models.BankName selectedbank;
        public frm_bank_add()
        {
            InitializeComponent();
            bank_Presenter = new bank_Presenter(this);
            this.bankForm = new BankForm();
            this.selectedbank = new Models.BankName();
            bank_Presenter.LoadBank();

        }

        public void DisplayBank(List<Models.BankName> banks)
        {

        }
        private void save()
        {
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Models.BankName
            {
                Bankname1 = txt_bank.Text,
                Isactive = checkBox_isactive.Checked,
                Createdby = createdby,
                FkSystemUser = id
            };
            bank_Presenter.AddBank(cv);
            MessageBox.Show("Added Successfully!");

        }
        private void update()
        {
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var selectper = selectedbank as BankName;

            selectper.Bankname1 = txt_bank.Text;
            selectper.Isactive = checkBox_isactive.Checked;
            selectper.Createdby = createdby;
            selectper.FkSystemUser = id;

            bank_Presenter.UpdateBank(selectper);
            MessageBox.Show("Updated Successfully!");
            this.Close();
        }
        public void putdata(BankForm bankForm, Models.BankName bank, String buttonClick)
        {
            this.bankForm = bankForm;
            this.selectedbank = bank;
            txt_bank.Text = selectedbank.Bankname1;
            checkBox_isactive.Checked = selectedbank.Isactive;
            if (buttonClick == "Edit")
            {
                btn_save.Text = "Update";
                txt_bank.Enabled = true;
                checkBox_isactive.Enabled = true;
                btn_save.Select();
            }
            else
            {
                btn_save.Text = "Close";
                txt_bank.Enabled = false;
                checkBox_isactive.Enabled = false;
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (btn_save.Text == "Save")
            {
                save();
            }
            else if (btn_save.Text == "Update")
            {
                update();
            }
            else if (btn_save.Text == "Close")
            {
                this.Close();
            }
        }
    }
}
