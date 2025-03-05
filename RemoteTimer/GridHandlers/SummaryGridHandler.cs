using RemoteTimer.Database;

namespace RemoteTimer.GridHandlers
{
    public class SummaryGridHandler : GridHandler
    {
        private List<WorkDaySummaryView> WorkDaySummaryViews { get; set; }

        public SummaryGridHandler(DataGridView grid) : base(grid)
        {
            WorkDaySummaryViews = new List<WorkDaySummaryView>();
        }

        public override void LoadGrid()
        {
            RefreshGrid();

            WorkDaySummaryViews = DBContext.WorkDaySummaryViews
                .Where(wds => wds.Username == ActiveUser.Username).ToList();

            foreach (WorkDaySummaryView view in WorkDaySummaryViews)
            {
                Grid.Rows.Add(
                    view.Username, 
                    DateOnly.FromDateTime(view.StartDay == null ? DateTime.MinValue : view.StartDay.Value), 
                    TimeSpan.FromSeconds(view.WorkTime == null ? 0.0D : (double)view.WorkTime), 
                    TimeSpan.FromSeconds(view.BreakTime == null ? 0.0D : (double)view.BreakTime), 
                    TimeSpan.FromSeconds(view.TotalTime == null ? 0.0D : (double)view.TotalTime), 
                    CalculateToll(view.TotalTime));
            }

            Grid.Sort(Grid.Columns[1], System.ComponentModel.ListSortDirection.Descending);
        }

        public void RegisterWork(WorkRegistration registration)
        {
            WorkDaySummary? summary = DBContext.WorkDaySummaries
                .SingleOrDefault(wds => wds.StartWork.Value.DayOfYear == registration.Start.DayOfYear && wds.UsernameNavigation == ActiveUser);

            if (summary == null)
            {
                summary = new WorkDaySummary()
                {
                    UsernameNavigation = ActiveUser,
                    StartWork = registration.Start,
                    StopWork = registration.Stop
                };

                DBContext.Add(summary);
            }
            else
            {
                summary.StopWork = registration.Stop;
            }

            DBContext.SaveChanges();
            LoadGrid();
        }
        
        public void RegisterBreak(BreakRegistration registration)
        {
            WorkDaySummary? summary = DBContext.WorkDaySummaries
                .SingleOrDefault(wds => wds.StartBreak.Value.DayOfYear == registration.Start.DayOfYear && wds.UsernameNavigation == ActiveUser);

            if (summary == null)
            {
                summary = new WorkDaySummary()
                {
                    UsernameNavigation = ActiveUser,
                    StartBreak = registration.Start,
                    StopBreak = registration.Stop
                };

                DBContext.Add(summary);
            }
            else
            {
                summary.StopBreak = registration.Stop;
            }

            DBContext.SaveChanges();
            LoadGrid();
        }

        private TimeSpan CalculateToll(int? totalSeconds)
        {
            return totalSeconds == null ? TimeSpan.Zero : TimeSpan.FromSeconds((double)(28800 - totalSeconds));
        }
    }
}