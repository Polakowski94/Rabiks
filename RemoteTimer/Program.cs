using Microsoft.EntityFrameworkCore.Diagnostics;
using RemoteTimer.Forms;

namespace RemoteTimer
{
    internal static class Program
    {
        public static DatabaseLoader DBLoader = new DatabaseLoader();

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}