using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RemoteTimer.Database;

[Keyless]
public partial class WorkDaySummaryView
{
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

    [Column(TypeName = "datetime")]
    public DateTime? StartDay { get; set; }

    public int? WorkTime { get; set; }

    public int? BreakTime { get; set; }

    public int? TotalTime { get; set; }
}
