using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RemoteTimer.Database;

public partial class RemoteTimerDatabaseContext : DbContext
{
    public RemoteTimerDatabaseContext()
    {
    }

    public RemoteTimerDatabaseContext(DbContextOptions<RemoteTimerDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BreakRegistration> BreakRegistrations { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<WorkDaySummary> WorkDaySummaries { get; set; }

    public virtual DbSet<WorkDaySummaryView> WorkDaySummaryViews { get; set; }

    public virtual DbSet<WorkRegistration> WorkRegistrations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB; AttachDBFilename=D:\\Repos\\Database\\RemoteTimerDatabase.mdf;Integrated security=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BreakRegistration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07D1497243");

            entity.HasOne(d => d.UsernameNavigation).WithMany(p => p.BreakRegistrations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BreakRegistration_User");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Username).HasName("PK__User__536C85E5BE725685");

            entity.Property(e => e.Username).HasDefaultValue("user");
            entity.Property(e => e.Password).HasDefaultValue("password");
        });

        modelBuilder.Entity<WorkDaySummary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__WorkDayS__3214EC07C90E53CF");

            entity.HasOne(d => d.UsernameNavigation).WithMany(p => p.WorkDaySummaries)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkDaySummary_User");
        });

        modelBuilder.Entity<WorkDaySummaryView>(entity =>
        {
            entity.ToView("WorkDaySummaryView");
        });

        modelBuilder.Entity<WorkRegistration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07CB943811");

            entity.HasOne(d => d.UsernameNavigation).WithMany(p => p.WorkRegistrations)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WorkRegistration_User");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
