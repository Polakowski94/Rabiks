using System.Configuration;
using RemoteTimer.Database;

namespace RemoteTimer.Registers
{
    public class WorkDaySummaryRegister : DatabaseRegister
    {
        private List<WorkDaySummaryView> WorkDaySummaryViews { get; set; }
        private int TollInSeconds { get; set; }

        public WorkDaySummaryRegister(DataGridView grid) : base(grid)
        {
            WorkDaySummaryViews = new List<WorkDaySummaryView>();

            SortColumnIndex = Int32.Parse(ConfigurationManager.AppSettings.Get("SummaryGridSortColumn"));
            TollInSeconds = Int32.Parse(ConfigurationManager.AppSettings.Get("TollInSeconds"));
        }

        public override void RegisterBreak(BreakRegistration registration)
        {
            WorkDaySummary? summary = GetSummary(registration.Start.DayOfYear);

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
                summary.StartBreak = summary.StartBreak <= registration.Start ? summary.StartBreak : registration.Start;
                summary.StopBreak = registration.Stop;
            }

            DBContext.SaveChanges();
            LoadGrid();
        }

        public override void RegisterWork(WorkRegistration registration)
        {
            WorkDaySummary? summary = GetSummary(registration.Start.DayOfYear);

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
                summary.StartWork = summary.StartWork <= registration.Start ? summary.StartWork : registration.Start;
                summary.StopWork = registration.Stop;
            }

            DBContext.SaveChanges();
            LoadGrid();
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

        private WorkDaySummary? GetSummary(int dayOfYear)
        {
            WorkDaySummary? summary = DBContext.WorkDaySummaries
                .SingleOrDefault(wds => (wds.StartWork.Value.DayOfYear == dayOfYear ||
                                         wds.StartBreak.Value.DayOfYear == dayOfYear)
                                         && wds.UsernameNavigation == ActiveUser);

            return summary;
        }

        private TimeSpan CalculateToll(int? totalSeconds)
        {
            return totalSeconds == null ? TimeSpan.Zero : TimeSpan.FromSeconds((double)(TollInSeconds - totalSeconds));
        }
    }
}