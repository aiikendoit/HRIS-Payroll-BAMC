﻿using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.Bank;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Forms.Maintenance.Bank
{
    public partial class BankForm : Form, IBankView
    {
        private readonly bank_Presenter bank_Presenter;

        public BankForm()
        {
            InitializeComponent();
            UniversalStatic.customDatagrid(dgrid_bank);
            bank_Presenter = new bank_Presenter(this);

            bank_Presenter.LoadBank();
        }

        public void DisplayBank(List<Models.BankName> banks)
        {
            dgrid_bank.DataSource = banks;
            dgrid_bank.Columns[0].HeaderText = "ID";
            dgrid_bank.Columns[1].HeaderText = "Bank Name";
            dgrid_bank.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            if (dgrid_bank.ColumnCount == 8)
            {
                //Remove unnecessary column
                dgrid_bank.Columns.RemoveAt(7);
                dgrid_bank.Columns.RemoveAt(6);
                dgrid_bank.Columns.RemoveAt(5);
            }
            dgrid_bank.AutoGenerateColumns = false;
        }

        private void BankForm_Load(object sender, EventArgs e)
        {

        }
        private void search()
        {
            string searchQuery = txt_search.Text.Trim();
            if (string.IsNullOrEmpty(searchQuery))
            {
                bank_Presenter.LoadBank();
            }
            else
            {
                bank_Presenter.SearchData(searchQuery);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var b = new frm_bank_add();
            b.ShowDialog();
            bank_Presenter.LoadBank();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            var selectedbank = dgrid_bank.SelectedRows[0].DataBoundItem as Models.BankName;
            if (selectedbank != null)
            {
                var b = new frm_bank_add();
                b.isUpdate = true;
                b.putdata(this, selectedbank);
                b.ShowDialog(this);
                bank_Presenter.LoadBank();
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            var selectedbank = dgrid_bank.SelectedRows[0].DataBoundItem as Models.BankName;
            if (selectedbank != null)
            {
                var b = new frm_bank_add();
                b.putdata(this, selectedbank);
                b.ShowDialog(this);
                bank_Presenter.LoadBank();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            search();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            search();
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            bank_Presenter.LoadBank();
        }
    }
}
