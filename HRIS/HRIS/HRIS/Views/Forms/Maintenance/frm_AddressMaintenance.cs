using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.AddressFolder;
using HRIS.Views.Forms.Maintenance.AddressFolder.Barangay;
using HRIS.Views.Forms.Maintenance.AddressFolder.ProvincesFolder;
using HRIS.Views.Forms.Maintenance.AddressFolder.RegionFolder;
using HRIS.Views.Forms.Maintenance.AddressFolder.TownCityFolder;
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
    public partial class frm_AddressMaintenance : Form, IRegionView, IProvinceView, ITownCityView, IBarangayView,IZipcodeView
    {
        private readonly province_Presenter province_Presenter;
        private readonly towncity_Presenter towncity_Presenter;
        private readonly barangay_Presenter barangay_Presenter;
        private readonly region_Presenter region_Presenter;
        private readonly zipcode_Presenter zipcode_Presenter;
        public frm_AddressMaintenance()
        {
            InitializeComponent();
            province_Presenter = new province_Presenter(this);
            towncity_Presenter = new towncity_Presenter(this);
            barangay_Presenter = new barangay_Presenter(this);
            region_Presenter = new region_Presenter(this);
            zipcode_Presenter = new zipcode_Presenter(this);
            region_Presenter.loadRegion();
            //txt_province.SelectedIndex = -1;
            //txt_towncity.SelectedIndex = -1;
            //txt_barangay.SelectedIndex = -1;
            txt_region.SelectedIndex = -1;

        }

        public void ClearFields()
        {
        }

        public void DisplayProvinces(List<Province> Provinces)
        {
            txt_province.DataSource = Provinces;
            txt_province.DisplayMember = "Description";
            txt_province.ValueMember = "PkProvince";
        }
        private void frm_AddressMaintenance_Load(object sender, EventArgs e)
        {

        }

        private void txt_towncity_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedvalue = txt_towncity.SelectedItem as Models.Towncity;
            if (selectedvalue != null)
            {
                int id = selectedvalue.PkTowncity;
                barangay_Presenter.loadBarangays(id);
                txt_barangay.SelectedIndex = -1;
            }
            var selectedzipcode = txt_towncity.SelectedItem as Models.Towncity;
            if (selectedvalue != null)
            {
                int id = selectedvalue.PkTowncity;
                zipcode_Presenter.loadZipcode(id);
                txt_zipcode.SelectedIndex = -1;
            }

        }

        private void txt_province_SelectedIndexChanged(object sender, EventArgs e)
        {

            var selectedvalue = txt_province.SelectedItem as Models.Province;
            if (selectedvalue != null)
            {
                int id = selectedvalue.PkProvince;
                towncity_Presenter.loadTowncity(id);
                txt_towncity.SelectedIndex = -1;
            }
        }

        public void DisplayTownCity(List<Models.Towncity> Towncities)
        {

            txt_towncity.DataSource = Towncities;
            txt_towncity.DisplayMember = "Description";
            txt_towncity.ValueMember = "PkTownCity";

        }

        private void txt_barangay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void DisplayBarangay(List<Models.Barangay> barangay)
        {
            txt_barangay.DataSource = barangay;
            txt_barangay.DisplayMember = "Description";
            txt_barangay.ValueMember = "PkBarangay";
        }

        public void clearfields()
        {

        }

        public void DisplayRegion(List<Models.Region> Regions)
        {
            txt_region.DataSource = Regions;
            txt_region.DisplayMember = "Description";
            txt_region.ValueMember = "PkRegion";
        }

        private void txt_region_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedvalue = txt_region.SelectedItem as Models.Region;
            if (selectedvalue != null)
            {
                int id = selectedvalue.PkRegion;
                province_Presenter.loadProvince(id);
                txt_province.SelectedIndex = -1;
            }
        }

        public void DisplayZipcode(List<Zipcode> Zipcodes)
        {
            txt_zipcode.DataSource = Zipcodes;
            txt_zipcode.DisplayMember = "Zipcode1";
            txt_zipcode.ValueMember = "PkZipcode";
        }
    }
}
