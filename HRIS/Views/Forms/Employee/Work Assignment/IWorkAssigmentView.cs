﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Employee.Work_Assignment
{
    public interface IWorkAssigmentView
    {
        void DisplayWorkAssignment(List<Models.Workassignment> workassignments);
       
    }
}
