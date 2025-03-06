using RemoteTimer.Database;

namespace RemoteTimer.Registers
{
    public abstract class DatabaseRegister
    {
        protected DataGridView Grid { get; private set; }
        protected RemoteTimerDatabaseContext DBContext { get; private set; }
        protected User? ActiveUser { get; private set; }
        protected int SortColumnIndex { get; set; }

        public DatabaseRegister(DataGridView grid)
        {
            Grid = grid;
            DBContext = new RemoteTimerDatabaseContext();
            ActiveUser = DBContext.Users.FirstOrDefault();

            LoadGrid();
        }

        public abstract void LoadGrid();

        public abstract void RegisterWork(WorkRegistration registration);

        public abstract void RegisterBreak(BreakRegistration registration);

        protected void RefreshGrid()
        {
            Grid.Rows.Clear();
            Grid.Refresh();
        }
    }
}