using System;
using System.Collections.Generic;

namespace NguyenHoaiNam_2310900073.Models;

public partial class NhnEmployee
{
    public int NhnEmpId { get; set; }

    public string? NhnEmpName { get; set; }

    public string? NhnEmpLevel { get; set; }

    public DateOnly? NhnEmpStartDate { get; set; }

    public bool? NhnEmpStatus { get; set; }
}
