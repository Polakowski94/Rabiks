using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RemoteTimer.Models.DataLayer;

[Table("WorkDaySummary")]
public partial class WorkDaySummary
{
    [Key]
    public int Id { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    public DateOnly? Day { get; set; }

    public TimeOnly? WorkTime { get; set; }

    public TimeOnly? BreakTime { get; set; }

    public TimeOnly? TotalTime { get; set; }

    public TimeOnly? Toll { get; set; }

    [ForeignKey("Username")]
    [InverseProperty("WorkDaySummaries")]
    public virtual User UsernameNavigation { get; set; } = null!;
}
