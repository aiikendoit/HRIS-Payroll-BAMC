using HRIS.Models;
using HRIS.Views.Forms.Employee.Education;
using HRIS.Views.Forms.Maintenance.Degreetype;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HRIS.Presenter
{
    public class educationalattainment_emp_Presenter
    {
        private readonly I_emp_EducationalAttainmentView _view;
        private readonly HrisContext _context;
        private List<Educationalattainment> educationalattainmentsData;
        private List<object> attainmentList;
        public educationalattainment_emp_Presenter(I_emp_EducationalAttainmentView view)
        {
            _view = view;
            _context = new HrisContext();
            educationalattainmentsData = new List<Educationalattainment>(); 
            attainmentList = new List<object>();
        }
        public void LoadEducAttainment(int pkeducID)
        {
            var p = _context.Educationalattainments
                .Where(e => e.PkEducationalattainment == pkeducID)
                .ToList();
            educationalattainmentsData = p;
            _view.DisplayEmployeeEducAttainment(p);
        }
        public void LoadAttainment(int PKEmployeeID)
        {
            var query = from educ in _context.Educationalattainments
                        join educlevel in _context.Educationallevels on educ.FkEducationallevel equals educlevel.PkEducationallevel
                        join degreetype in _context.Degreetypes on educ.FkDegreetype equals degreetype.PkDegreetype
                        where educ.FkEmployee == PKEmployeeID
                        orderby educ.Yeargraduated descending
                        select new
                        {
                            ID = educ.PkEducationalattainment,
                            EducationalAttainment = educlevel.Description,
                            SchoolAttended = educ.Schoolattended,
                            YearGraduated = educ.Yeargraduated.Year,
                            EducationalDegree = educ.Educationaldegree,
                            Degreetype = degreetype.Description,
                        };

            _view.DisplayAttainmentCustom(query.ToList<object>());
            attainmentList = query.ToList<object>();
        }


        public void AddEducAttainment(Educationalattainment educationalattainment)
        {
            try
            {

            
            _context.Educationalattainments.Add(educationalattainment);
            _context.SaveChanges();
            MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        public void UpdateEducAttainment(Educationalattainment educationalattainment)
        {
            var existingEduc = _context.Educationalattainments.Find(educationalattainment.PkEducationalattainment);

            if (existingEduc != null)
            {
                _context.Entry(existingEduc).State = EntityState.Detached;
                _context.Entry(educationalattainment).State = EntityState.Modified;
                _context.SaveChanges();
                MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void SearchData(string searchQuery)
        {
            var searchResults = attainmentList
            .Where(item =>
            (item.GetType().GetProperty("EducationalAttainment")?.GetValue(item)?.ToString()?.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0) ||
            (item.GetType().GetProperty("SchoolAttended")?.GetValue(item)?.ToString()?.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0) ||
            (item.GetType().GetProperty("YearGraduated")?.GetValue(item)?.ToString()?.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0)
            )
            .ToList();
            _view.DisplayAttainmentCustom(searchResults.ToList());
        }
    }
}
