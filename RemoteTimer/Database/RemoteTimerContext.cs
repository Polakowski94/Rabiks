using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RemoteTimer.DatabaseClasses
{
    public class RemoteTimerContext : DbContext
    {
        public RemoteTimerContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<WorkRegistration> WorkRegistrations { get; set; }
        public DbSet<BreakRegistration> BreakRegistrations { get; set; }
        public DbSet<WorkdaySummary> WorkdaySummaries { get; set; }
    }
}