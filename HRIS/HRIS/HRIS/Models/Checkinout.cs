using System;
using System.Collections.Generic;

namespace HRIS.Models;

public partial class Checkinout
{
    public int? Userid { get; set; }

    public DateTime? Checktime { get; set; }

    public int? Checktype { get; set; }

    public int? Verifycode { get; set; }

    public int? Sensorid { get; set; }

    public string? Serialno { get; set; }

    public int? Acno { get; set; }
}
