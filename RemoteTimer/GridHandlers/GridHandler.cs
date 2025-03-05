using RemoteTimer.Database;

namespace RemoteTimer.GridHandlers
{
    public abstract class GridHandler
    {
        protected DataGridView Grid { get; private set; }
        protected RemoteTimerDatabaseContext DBContext { get; private set; }
        protected User? ActiveUser { get; private set; }

        public GridHandler(DataGridView grid)
        {
            Grid = grid;
            DBContext = new RemoteTimerDatabaseContext();
            ActiveUser = DBContext.Users.FirstOrDefault();

            LoadGrid();
        }

        public abstract void LoadGrid();

        protected void RefreshGrid()
        {
            Grid.Rows.Clear();
            Grid.Refresh();
        }
    }
}