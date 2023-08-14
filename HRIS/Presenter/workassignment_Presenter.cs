﻿using HRIS.Models;
using HRIS.Views.Forms.Employee.Work_Assignment;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class workassignment_Presenter
    {
        private readonly HrisContext _context;
        private readonly IWorkAssigmentView _view;
        
        public  workassignment_Presenter(IWorkAssigmentView view)
        {
            _view = view;
            _context = new HrisContext();
        }
        public void loadWorkAssignment(int employeeid,DataGridView dataGridView)
        {
            var query = from workass in _context.Workassignments
                        join department in _context.Departments on workass.FkDepartment equals department.PkDepartment
                        join position in _context.Positions on workass.FkPosition equals position.PkPosition
                        where workass.FkEmployee == employeeid
                        orderby workass.Startdate descending
                        select new
                        {
                            ID = workass.PkWorkassignment,
                            Department = department.Description,
                            Position = position.PositionName,
                            JobDescription = workass.Jobdescription,
                            Responsibilities  = workass.Responsibilities,
                            Jobscope = workass.Jobscope,
                            workass.IsManager,
                            Startdate = workass.Startdate,
                            Enddate = workass.Enddate,
                        };

            dataGridView.DataSource = query.ToList();
        }
        public void loadWorkAssignmentWithWhere(int workassignmentid)
        {
            var query = from workass in _context.Workassignments
                        where workass.PkWorkassignment == workassignmentid
                        select workass;
            var p = query.ToList();
            _view.DisplayWorkAssignment(p);

        }
        public void AddWorkAssignment(Workassignment workassignment)
        {
            _context.Workassignments.Add(workassignment);
            _context.SaveChanges();
        }
        public void UpdateWorkAssignment(Workassignment workassignment)
        {
            var existingWorkassignment = _context.Workassignments.Find(workassignment.PkWorkassignment);

            if (existingWorkassignment != null)
            {
                _context.Entry(existingWorkassignment).State = EntityState.Detached;
                _context.Entry(workassignment).State = EntityState.Modified;
                _context.SaveChanges();
                MessageBox.Show("Successfully updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Workassignment not found");
            }

        }
    }
}