using RemoteTimer.Models.DataLayer;

namespace RemoteTimer
{
    //---------------------------------------------------------------------------------------------------------
    //----- Ta klasa bylaby bardziej rozbudowana, gdyby w zadaniu bylo uwzglednione logowanie uzytkownika -----
    //---------------------------------------------------------------------------------------------------------
    public class UserProvider
    {
        public User ActiveUser { get; private set; }

        public UserProvider()
        {
            ActiveUser = DatabaseLoader.Instance.Context.Users.FirstOrDefault();
        }
    }
}