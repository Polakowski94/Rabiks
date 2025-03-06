using System.ComponentModel;
using System.Configuration;
using RemoteTimer.Database;

namespace RemoteTimer.Loaders
{
    public class SummaryGridLoader : GridLoader
    {
        private List<WorkDaySummaryView> WorkDaySummaryViews { get; set; }
        private int TollInSeconds { get; set; }

        public SummaryGridLoader(DataGridView grid) : base(grid)
        {
            WorkDaySummaryViews = new List<WorkDaySummaryView>();

            SortColumnIndex = Int32.Parse(ConfigurationManager.AppSettings.Get("SummaryGridSortColumn"));
            TollInSeconds = Int32.Parse(ConfigurationManager.AppSettings.Get("TollInSeconds"));
        }

        public override void Load()
        {
            Refresh();

            WorkDaySummaryViews = DBContext.WorkDaySummaryViews
                .Where(wds => wds.Username == ActiveUser.Username).ToList();

            foreach (var view in WorkDaySummaryViews)
            {
                Grid.Rows.Add(
                    view.Username, 
                    view.WorkDate == null ? DateOnly.FromDateTime(DateTime.MinValue) : view.WorkDate.Value, 
                    TimeSpan.FromSeconds(view.WorkSeconds == null ? 0.0D : (double)view.WorkSeconds), 
                    TimeSpan.FromSeconds(view.BreakSeconds == null ? 0.0D : (double)view.BreakSeconds), 
                    TimeSpan.FromSeconds(view.TotalSeconds == null ? 0.0D : (double)view.TotalSeconds), 
                    CalculateToll(view.TotalSeconds));
            }

            Grid.Sort(Grid.Columns[SortColumnIndex], ListSortDirection.Descending);
        }

        private TimeSpan CalculateToll(int? totalSeconds)
        {
            return totalSeconds == null ? TimeSpan.Zero : TimeSpan.FromSeconds((double)(totalSeconds - TollInSeconds));
        }
    }
}