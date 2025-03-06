using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RemoteTimer.Database;

[Keyless]
public partial class WorkDaySummaryView
{
    [StringLength(16)]
    [Unicode(false)]
    public string? Username { get; set; }

    public DateOnly? WorkDate { get; set; }

    public int? WorkSeconds { get; set; }

    public int? BreakSeconds { get; set; }

    public int? TotalSeconds { get; set; }
}
