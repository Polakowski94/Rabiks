using RemoteTimer.Database;

namespace RemoteTimer.Loaders
{
    public abstract class GridLoader : DatabaseProvider
    {
        protected DataGridView Grid { get; private set; }
        protected int SortColumnIndex { get; set; }

        public GridLoader(DataGridView grid) : base()
        {
            Grid = grid;
        }

        public abstract void Load();

        protected void Refresh()
        {
            Grid.Rows.Clear();
            Grid.Refresh();
        }
    }
}