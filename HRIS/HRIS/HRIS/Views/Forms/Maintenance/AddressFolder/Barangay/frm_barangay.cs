using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.AddressFolder.ProvincesFolder;
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

namespace HRIS.Views.Forms.Maintenance.AddressFolder.Barangay
{
    public partial class frm_barangay : Form, ITownCityView, IProvinceView, IBarangayView
    {
        private readonly towncity_Presenter towncity_Presenter;
        public readonly province_Presenter province_Presenter;
        private readonly barangay_Presenter barangay_Presenter;
        public bool isupdate = false;
        public frm_barangay()
        {
            InitializeComponent();
            towncity_Presenter = new towncity_Presenter(this);
            province_Presenter = new province_Presenter(this);
            barangay_Presenter = new barangay_Presenter(this);
           
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

        public void DisplayTownCity(List<Towncity> Towncities)
        {
            txt_towncity.DataSource = Towncities;
            txt_towncity.DisplayMember = "Description";
            txt_towncity.ValueMember = "PkTownCity";

            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedvalue = txt_province.SelectedItem as Models.Province;
            if (selectedvalue != null)
            {
                int id = selectedvalue.PkProvince;
                towncity_Presenter.loadTowncity(id);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isupdate == true)
            {

            }
            else
            {
                addBarangay();
                this.Close();
            }
            
        }
        private void addBarangay()
        {
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var selectedvalue = txt_towncity.SelectedItem as Models.Towncity;
            var b = new Models.Barangay
            {
                Description = txt_barangayname.Text,
                IsActive = checkBox_isactive.Checked,
                FkTownCity = selectedvalue?.PkTowncity,
                Createdby = createdby,
            };
            barangay_Presenter.AddBarangay(b);

        }
        public void putdata(int brgyid,int towncityid)
        {
            
            towncity_Presenter.loadtowncityWhere(towncityid);
            barangay_Presenter.loadBarangaywhere(brgyid);
            btn_saveandnew.Visible = false;
            txt_towncity.SelectedValue = towncityid;
            

        }

        public void DisplayBarangay(List<Models.Barangay> Barangays)
        {
            try
            {
                if (Barangays != null)
                {
                    Models.Barangay brgy = Barangays[0];
                    txt_barangayname.Text = brgy.Description;
                    checkBox_isactive.Checked = brgy.IsActive ?? false;
                }
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"An error occurred while saving the entity changes. Inner exception: {ex.InnerException.Message}");
                }
                else
                {
                    MessageBox.Show($"An error occurred while saving the entity changes. Exception: {ex.Message}");
                }
            }
        }
        public void clearfields()
        {

        }

        private void btn_saveandnew_Click(object sender, EventArgs e)
        {
            addBarangay();
           txt_barangayname.Clear();
        }

        public void DisplayProvince(int provinces)
        {
            province_Presenter.loadProvince();
            txt_province.SelectedValue = provinces;
        }
    }
}
