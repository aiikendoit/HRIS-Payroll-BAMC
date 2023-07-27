using HRIS.Class;
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
    public partial class frm_AddressMaintenance : Form, IProvinceView, IRegionView, ITownCityView, IBarangayView, IZipcodeView
    {
        private readonly province_Presenter province_Presenter;
        private readonly towncity_Presenter towncity_Presenter;
        private readonly barangay_Presenter barangay_Presenter;
        private readonly region_Presenter region_Presenter;
        private readonly zipcode_Presenter zipcode_Presenter;
        private bool save = false;
        public frm_AddressMaintenance()
        {
            InitializeComponent();

            province_Presenter = new province_Presenter(this);
            towncity_Presenter = new towncity_Presenter(this);
            barangay_Presenter = new barangay_Presenter(this);
            region_Presenter = new region_Presenter(this);
            zipcode_Presenter = new zipcode_Presenter(this);
            province_Presenter.loadProvince();
            //region_Presenter.loadRegion();
            //txt_province.SelectedIndex = -1;
            //txt_towncity.SelectedIndex = -1;
            //txt_barangay.SelectedIndex = -1;
            //txt_region.SelectedIndex = -1;


        }

        #region "store address value"
        public bool issave { get { return save; } }
        public string address1 { get { return txt_address1.Text; } }
        public string address2 { get { return txt_address2.Text; } }
        public string address3 { get { return txt_address3.Text; } }
        public string region { get { return txt_region.Text; } }
        public string province { get { return txt_province.Text; } }
        public string towncity { get { return txt_towncity.Text; } }
        public string barangay { get { return txt_barangay.Text; } }
        public string zipcode { get { return txt_zipcode.Text; } }
        public string completeaddress { get { return txt_completeaddress.Text; } }
        public int regionSelectedvalue { get { return Convert.ToInt32(txt_region.SelectedValue); } }
        public int provinceSelectedvalue { get { return Convert.ToInt32(txt_province.SelectedValue); } }
        public int towncitySelectedvalue { get { return Convert.ToInt32(txt_towncity.SelectedValue); } }
        public int barangaySelectedvalue { get { return Convert.ToInt32(txt_barangay.SelectedValue); } }
        public int zipcodeSelectedvalue { get { return Convert.ToInt32(txt_zipcode.SelectedValue); } }


        #endregion

        public void updatecompleteaddress()
        {

            txt_completeaddress.Text = txt_address1.Text + " " + txt_address2.Text + " " + txt_address3.Text
                                          + " " + txt_barangay.Text + " " + txt_towncity.Text + " " + txt_province.Text
                                          + " " + txt_region.Text + " " + txt_zipcode.Text;
        }
        void clearfield()
        {
            txt_address1.Clear();
            txt_address2.Clear();
            txt_address3.Clear();
            txt_region.SelectedIndex = -1;
            txt_province.SelectedIndex = -1;
            txt_towncity.SelectedIndex = -1;
            txt_barangay.SelectedIndex = -1;
            txt_zipcode.SelectedIndex = -1;
            txt_completeaddress.Clear();
        }
        public void ClearFields()
        {
        }
        private void frm_AddressMaintenance_Load(object sender, EventArgs e)
        {

        }
        public void putdata(string address1, string addres2, string address3, int provinceid, int towncityid, int barangayid, int zipcodeid)
        {
            province_Presenter.loadProvince();
            towncity_Presenter.loadTowncity(provinceid);
            barangay_Presenter.loadBarangays(towncityid);
            zipcode_Presenter.loadZipcode(towncityid);
            region_Presenter.loadRegionWhere(provinceid);
            txt_province.SelectedValue = provinceid;
            txt_barangay.SelectedValue = barangayid;
            txt_towncity.SelectedValue = towncityid;
            txt_zipcode.SelectedValue = zipcodeid;
            txt_address1.Text = address1;
            txt_address2.Text = address2;
            txt_address3.Text = address3;
            updatecompleteaddress();
<<<<<<< HEAD

=======
            btn_cancel.Select();
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
        }
        public void DisplayProvinces(List<Province> Provinces)
        {
            txt_province.DataSource = Provinces;
            txt_province.DisplayMember = "Description";
            txt_province.ValueMember = "PkProvince";
        }
        public void DisplayTownCity(List<Models.Towncity> Towncities)
        {

            txt_towncity.DataSource = Towncities;
            txt_towncity.DisplayMember = "Description";
            txt_towncity.ValueMember = "PkTownCity";
        }

        private void txt_barangay_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatecompleteaddress();
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
            //txt_region.SelectedIndex = 0;
        }

        private void txt_province_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selectedvalue = txt_province.SelectedItem as Models.Province;
            if (selectedvalue != null)
            {
                int id = selectedvalue.FkRegion.Value;
                region_Presenter.loadRegionWhere(id);
                txt_towncity.SelectedIndex = -1;
                towncity_Presenter.loadTowncity(selectedvalue.PkProvince);
            }
            updatecompleteaddress();
        }
        private void txt_towncity_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var selectedvalue = txt_towncity.SelectedItem as Models.Towncity;
            if (selectedvalue != null)
            {
                int id = selectedvalue.PkTowncity;
                barangay_Presenter.loadBarangays(id);
                txt_barangay.SelectedIndex = -1;
            }
            var selectedzipcode = txt_towncity.SelectedItem as Models.Towncity;
            if (selectedzipcode != null)
            {
                int id = selectedzipcode.PkTowncity;
                zipcode_Presenter.loadZipcode(id);

            }
            updatecompleteaddress();
        }
        public void DisplayZipcode(List<Zipcode> Zipcodes)
        {
            txt_zipcode.DataSource = Zipcodes;
            txt_zipcode.DisplayMember = "Zipcode1";
            txt_zipcode.ValueMember = "PkZipcode";
        }

        private void txt_address1_TextChanged(object sender, EventArgs e)
        {
            updatecompleteaddress();
        }



        private void btn_cancel_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Closing this form will clear all data. Proceed?", "Verify",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                clearfield();
                this.Close();
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            save = true;
            if (UniversalStatic.IsEmpty(txt_address1)) return;
            if (txt_region.SelectedIndex == -1) { MessageBox.Show("Region is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (txt_province.SelectedIndex == -1) { MessageBox.Show("Province is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (txt_towncity.SelectedIndex == -1) { MessageBox.Show("Town/City is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (txt_barangay.SelectedIndex == -1) { MessageBox.Show("Barangay is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (txt_zipcode.SelectedIndex == -1) { MessageBox.Show("Zipcode is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            this.Close();
        }
        private void txt_address1_TextChanged_2(object sender, EventArgs e)
        {
            updatecompleteaddress();
        }
<<<<<<< HEAD
=======

        private void frm_AddressMaintenance_Load_1(object sender, EventArgs e)
        {

        }

        public void DisplayProvince(List<Province> provinces)
        {
           // throw new NotImplementedException();
        }

        public void DisplayProvince(int provinces)
        {
            //throw new NotImplementedException();
        }
>>>>>>> 0ff9b6f7192f6e06fa8d028c4346226376e68bba
    }
}
