using HRIS.Class;
using HRIS.Forms.Maintenance.Degreetype;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.AddressFolder.RegionFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRIS.Views.Forms.Maintenance.AddressFolder.ProvincesFolder
{
    public partial class frm_province : Form, IProvinceView, IRegionView
    {
        private readonly region_Presenter region_Presenter;
        private readonly province_Presenter province_Presenter;
        private ProvinceForm provinceForm;
        private Models.Province Selectedprovince;
        public bool isupdate = false;
        public frm_province()
        {
            InitializeComponent();
            this.provinceForm = new ProvinceForm();
            this.province_Presenter = new province_Presenter(this);
            this.region_Presenter = new region_Presenter(this);
            this.Selectedprovince = new Province();
            region_Presenter.loadRegion();
        }
        public void putdata(ProvinceForm provinceForm, Models.Province province)
        {
            if (isupdate)
            {
                btn_cancel.Select();
                this.provinceForm = provinceForm;
                this.Selectedprovince = province;
                txt_province.Text = Selectedprovince.Description;
                checkBox_isactive.Checked = Selectedprovince.IsActive;
                txt_region.SelectedValue = Selectedprovince.FkRegion;
            }
            else
            {
                btn_cancel.Select();
                this.provinceForm = provinceForm;
                this.Selectedprovince = province;
                txt_province.Text = Selectedprovince.Description;
                checkBox_isactive.Checked = Selectedprovince.IsActive;
                txt_region.SelectedValue = Selectedprovince.FkRegion;
                //disable control
                txt_province.Enabled = false;
                txt_region.Enabled = false;
                checkBox_isactive.Enabled = false;
                btn_save.Visible = false;
            }
        }
        private void save()
        {
            if (UniversalStatic.IsEmpty(txt_province)) return;
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var cv = new Models.Province
            {
                FkRegion = Convert.ToInt32(txt_region.SelectedValue),
                Description = txt_province.Text,
                IsActive = checkBox_isactive.Checked,
                Createdby = createdby,
                FkSysetmUser = id
            };
            province_Presenter.AddProvinces(cv);
            this.Close();
        }
        private void update()
        {

            var selectedprovince = Selectedprovince as Models.Province;
            selectedprovince.FkRegion = Convert.ToInt32(txt_region.SelectedValue);
            selectedprovince.Description = txt_province.Text;
            selectedprovince.IsActive = checkBox_isactive.Checked;
            province_Presenter.UpdateProvince(selectedprovince);
            this.Close();
        }
        public void ClearFields()
        {

        }

        public void DisplayProvinces(List<Province> Provinces)
        {

        }

        public void DisplayRegion(List<Models.Region> Regions)
        {
            txt_region.DataSource = Regions;
            txt_region.DisplayMember = "Description";
            txt_region.ValueMember = "PKRegion";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
