using HRIS.Models;
using HRIS.Views.Forms.Maintenance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class companyInformation_Presenter
    {
        private readonly HrisContext _context;
        private readonly ICompanyInformationView _view;
        public companyInformation_Presenter(ICompanyInformationView view)
        {
            _context = new HrisContext();
            _view = view;
        }
        public bool LoadCompanyInfo()
        {
            var p = _context.CompanyInfos.FirstOrDefault();
            _view.DisplayCompanyInfo(p);

            return p != null; // Return true if there is a value, false if it's null.
        }

        public void AddCompanyInformation(CompanyInfo companyInfo)
        {
            _context.CompanyInfos.Add(companyInfo);
            _context.SaveChanges();
            MessageBox.Show("Successfully saved","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public void UpdateWorkAssignment(CompanyInfo companyInfo)
        {
            var existingWorkassignment = _context.CompanyInfos.Find(companyInfo.PkCompanyInfo);

            if (existingWorkassignment != null)
            {
                _context.Entry(existingWorkassignment).State = EntityState.Detached;
                _context.Entry(companyInfo).State = EntityState.Modified;
                _context.CompanyInfos.Update(companyInfo);
                _context.SaveChanges();
                MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Company Information not found");
            }

        }
    }
}
