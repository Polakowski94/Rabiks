using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RemoteTimer.Database;

[Table("WorkDaySummary")]
public partial class WorkDaySummary
{
    [Key]
    public int Id { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? StartWork { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StopWork { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartBreak { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StopBreak { get; set; }

    [ForeignKey("Username")]
    [InverseProperty("WorkDaySummaries")]
    public virtual User UsernameNavigation { get; set; } = null!;
}
