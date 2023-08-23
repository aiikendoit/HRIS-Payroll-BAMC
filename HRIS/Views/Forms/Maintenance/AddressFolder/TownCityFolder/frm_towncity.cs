using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRIS.Class;
using HRIS.Models;
using HRIS.Presenter;
using HRIS.Views.Forms.Maintenance.AddressFolder.ProvincesFolder;
using HRIS.Views.Forms.Maintenance.AddressFolder.RegionFolder;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HRIS.Views.Forms.Maintenance.AddressFolder.TownCityFolder
{
    public partial class frm_towncity : Form, IProvinceView, ITownCityView
    {
        private readonly towncity_Presenter towncity_Presenter;
        private readonly province_Presenter province_Presenter;
        private TownCityForm townCityForm;
        private Models.Province Selectedprovince;
        private Models.Towncity SelectedTowncities;
        public bool isupdate = false;
        public frm_towncity()
        {
            InitializeComponent();
            this.townCityForm = new TownCityForm();
            this.towncity_Presenter = new towncity_Presenter(this);
            this.province_Presenter = new province_Presenter(this);
            this.Selectedprovince = new Province();
            province_Presenter.loadProvince();
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

        private void save()
        {
            if (UniversalStatic.IsEmpty(txt_towncity)) return;
            string? createdby = Properties.Settings.Default.completename;
            int id = Properties.Settings.Default.usercode;
            var tc = new Models.Towncity
            {
                FkProvince = Convert.ToInt32(drpdwn_province.SelectedValue),
                Description = txt_towncity.Text,
                IsActive = checkBox_isactive.Checked,
                Createdby = createdby,
                //FkSysetmUser = id
            };
            towncity_Presenter.AddTownCity(tc);
            this.Close();
        }

        private void update()
        {
            var SelectedTowncity = SelectedTowncities as Models.Towncity;
            SelectedTowncity.FkProvince = Convert.ToInt32(drpdwn_province.SelectedValue);
            SelectedTowncity.Description = txt_towncity.Text;
            SelectedTowncity.IsActive = checkBox_isactive.Checked;
            towncity_Presenter.UpdateTownCity(SelectedTowncity);
            this.Close();
        }



        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DisplayProvinces(List<Models.Province> Provinces)
        {
            drpdwn_province.DataSource = Provinces;
            drpdwn_province.DisplayMember = "Description";
            drpdwn_province.ValueMember = "PKProvince";
        }

        public void ClearFields()
        {
            throw new NotImplementedException();
        }

        public void DisplayTownCity(List<Towncity> Towncities)
        {
            //            throw new NotImplementedException();
        }

        public void DisplayProvince(int provinces)
        {
            throw new NotImplementedException();
        }

        public void putdata(TownCityForm townCityForm, Models.Towncity towncities)
        {
            if (isupdate)
            {
                btn_cancel.Select();
                this.townCityForm = townCityForm;
                this.SelectedTowncities = towncities;
                txt_towncity.Text = SelectedTowncities.Description;
                checkBox_isactive.Checked = SelectedTowncities.IsActive ?? false;
                drpdwn_province.SelectedValue = SelectedTowncities.FkProvince;
            }
            else
            {
                btn_cancel.Select();
                this.townCityForm = townCityForm;
                this.SelectedTowncities = towncities;
                txt_towncity.Text = SelectedTowncities.Description;
                checkBox_isactive.Checked = SelectedTowncities.IsActive ?? false;
                drpdwn_province.SelectedValue = SelectedTowncities.FkProvince;
                //disable control
                drpdwn_province.Enabled = false;
                txt_towncity.Enabled = false;
                checkBox_isactive.Enabled = false;
                btn_save.Visible = false;
            }
        }
    }
}
