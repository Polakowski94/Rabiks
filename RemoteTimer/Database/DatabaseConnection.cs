using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RemoteTimer.DatabaseClasses;

namespace RemoteTimer.Database
{
    public class DatabaseConnection
    {
        public DbContextOptionsBuilder<RemoteTimerContext> OptionsBuilder { get; private set; }

        public DatabaseConnection()
        {
            OptionsBuilder = new DbContextOptionsBuilder<RemoteTimerContext>();
        }
    }
}
