using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteTimer.Models.DataLayer;

namespace RemoteTimer
{
    public class DatabaseLoader : Singleton<DatabaseLoader>
    {
        public RemoteTimerDatabaseContext Context { get; private set; }
        public UserProvider UserProvider { get; private set; }

        public DatabaseLoader()
        {
            Context = new RemoteTimerDatabaseContext();
            UserProvider = new UserProvider();
        }
    }
}