using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RemoteTimer.Models.DataLayer;

[Table("User")]
public partial class User
{
    [Key]
    [StringLength(16)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [InverseProperty("UsernameNavigation")]
    public virtual ICollection<BreakRegistration> BreakRegistrations { get; set; } = new List<BreakRegistration>();

    [InverseProperty("UsernameNavigation")]
    public virtual ICollection<WorkDaySummary> WorkDaySummaries { get; set; } = new List<WorkDaySummary>();

    [InverseProperty("UsernameNavigation")]
    public virtual ICollection<WorkRegistration> WorkRegistrations { get; set; } = new List<WorkRegistration>();
}
