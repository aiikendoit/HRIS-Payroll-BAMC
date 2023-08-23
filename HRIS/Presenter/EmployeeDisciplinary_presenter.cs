﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRIS.Models;
using HRIS.Views.Forms.Employee.Disciplinary_Action;
using Microsoft.EntityFrameworkCore;

namespace HRIS.Presenter
{
    public class EmployeeDisciplinary_presenter
    {
        private readonly IEmployeeDisciplinaryActionView empDA_view;
        private readonly HrisContext _dbcontext;

        private List<Employeedisciplinary> empDA_ListData;

        //option 1
        //public EmployeeDisciplinary_presenter(IEmployeeDisciplinaryActionView empDA_view, HrisContext dbcontext, List<Employeedisciplinary> empDA_ListData)
        //{
        //    this.empDA_view = empDA_view;
        //    _dbcontext = dbcontext;
        //    this.empDA_ListData = empDA_ListData;
        //}   

        //option 2
        public EmployeeDisciplinary_presenter(IEmployeeDisciplinaryActionView view)
        {
            empDA_view = view;
            _dbcontext = new HrisContext();
            empDA_ListData = new List<Employeedisciplinary>();
        }

        public void loadEmpDscActAll() //retrieve all data
        {
            var q = _dbcontext.Employeedisciplinaries
                .OrderBy(e => e.Description)
                .ToList();
            empDA_ListData = q.ToList();
            empDA_view.DisplayEmployeeDscAct(q);
        }

        public void loadEmpDiscAccWhere(int? empDA_id) // join query
        {
            //var query = from e2 in _dbcontext.Employeedisciplinaries
            //            join o in _dbcontext.Offensetypes on e2.OffenseTypeId equals o.Id
            //            join d in _dbcontext.Disciplinarytypes on e2.DisciplinaryTypeId equals d.Id
            //            join e in _dbcontext.Employees on e2.EmployeeId equals e.Id
            //            select new
            //            {
            //                e2.Id,
            //                e.LastName,
            //                e.FirstName,
            //                OffenseDescription = o.Description,
            //                DisciplinaryTypeName = d.DisciplinaryTypeName,
            //                DisciplinaryDescription = d.DisciplinaryDescription,
            //                e2.EmployeeId,
            //                e2.Description,
            //                e2.DateStart,
            //                e2.DateEnd,
            //                e2.File,
            //                e2.CreatedDate,
            //                e2.CreatedBy
            //            };
        }

        internal void SearchData(string searchQuery) //search text box
        {
            var searchResults = empDA_ListData
                 .Where(b => b.PkEmployeedisciplinary.ToString().Contains(searchQuery)
                 || (b.Description != null && b.Description.Contains(searchQuery,
                 StringComparison.OrdinalIgnoreCase)))
                 .ToList();

            empDA_view.DisplayEmployeeDscAct(searchResults);
        }

        public void AddEmplDiscAct(Employeedisciplinary employeedisciplinary) //add method
        {
            _dbcontext.Employeedisciplinaries.Add(employeedisciplinary);
            _dbcontext.SaveChanges();
            MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadEmpDscActAll();
        }

        public void UpdateEmpDiscAct(Employeedisciplinary employeedisciplinary) //update method
        {
            _dbcontext.Employeedisciplinaries.Update(employeedisciplinary);
            _dbcontext.SaveChanges();
            MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadEmpDscActAll();
        }
    }
}
