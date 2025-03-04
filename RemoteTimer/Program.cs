using Microsoft.EntityFrameworkCore.Diagnostics;
using RemoteTimer.Forms;

namespace RemoteTimer
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new DatabaseConnectionForm());
        }
    }
}