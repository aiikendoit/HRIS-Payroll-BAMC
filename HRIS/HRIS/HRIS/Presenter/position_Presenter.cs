﻿using HRIS.Models;
using HRIS.Views.Forms.Maintenance.CivilStatus;
using HRIS.Views.Forms.Maintenance.Positions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Presenter
{
    public class position_Presenter
    {
        private readonly HrisContext _context;
        private readonly IPositionView _view;
        public position_Presenter(IPositionView view)
        {
            _view = view;
            _context = new HrisContext();
        }
        public void LoadPosition()
        {
            var p = _context.Positions.ToList();
            _view.DisplayPosition(p);
        }
        public void LoadPositionwithWhere(int departmentid)
        {
            var p = _context.Positions.Where(c => c.FkDepartment == departmentid).ToList();
            _view.DisplayPosition(p);
        }
        public void AddPosition(Position position,int departmentid)
        {

         bool isPositionExists = _context.Positions.Any(p => p.Description == position.Description && p.FkDepartment == departmentid);
         if (isPositionExists)
         {
             MessageBox.Show("Position with Department ID " + departmentid +" already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             return;
         }
         _context.Positions.Add(position);
         _context.SaveChanges();
         MessageBox.Show("Successfully saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
         LoadPosition();

        }

        public void UpdatePosition(Position position)
        {
            _context.Positions.Update(position);
            _context.SaveChanges();
        }
        public void DeletePosition(Position position)
        {
            _context.Positions.Remove(position);
            _context.SaveChanges();
        }
    }
}
