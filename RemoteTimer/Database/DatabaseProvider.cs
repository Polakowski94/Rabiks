namespace RemoteTimer.Database
{
    public abstract class DatabaseProvider
    {
        protected static RemoteTimerDatabaseContext DBContext = new RemoteTimerDatabaseContext();
        protected User? ActiveUser = DBContext.Users.FirstOrDefault();
    }
}