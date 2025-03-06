using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RemoteTimer.Database;

[Table("WorkRegistration")]
public partial class WorkRegistration
{
    [Key]
    public int Id { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string Username { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Start { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Stop { get; set; }

    [StringLength(1024)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [ForeignKey("Username")]
    [InverseProperty("WorkRegistrations")]
    public virtual User UsernameNavigation { get; set; } = null!;
}
