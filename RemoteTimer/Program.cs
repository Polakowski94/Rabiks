using RemoteTimer.Database;

namespace RemoteTimer
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());

            DatabaseConnection Connection = new DatabaseConnection();
        }
    }
}