﻿using HRIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Views.Forms.Maintenance.Positions
{
    public interface IPositionView
    {
        void DisplayPosition(List<Models.Position> positions);
    }
}