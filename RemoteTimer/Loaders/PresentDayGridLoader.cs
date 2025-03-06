using System.ComponentModel;
using System.Configuration;
using RemoteTimer.Database;

namespace RemoteTimer.Loaders
{
    public class PresentDayGridLoader : GridLoader
    {
        private const string WORK_LABEL = "Work";
        private const string BREAK_LABEL = "Break";

        private List<WorkRegistration> WorkRegistrations { get; set; }
        private List<BreakRegistration> BreakRegistrations { get; set; }

        public PresentDayGridLoader(DataGridView grid) : base(grid)
        {
            WorkRegistrations = new List<WorkRegistration>();
            BreakRegistrations = new List<BreakRegistration>();

            SortColumnIndex = Int32.Parse(ConfigurationManager.AppSettings.Get("TodayGridSortColumn"));
        }

        public override void Load()
        {
            Refresh();

            WorkRegistrations = DBContext.WorkRegistrations
                .Where(wr => wr.UsernameNavigation == ActiveUser && wr.Start.DayOfYear == DateTime.Today.DayOfYear).ToList();
            LoadWorkRows();

            BreakRegistrations = DBContext.BreakRegistrations
                .Where(br => br.UsernameNavigation == ActiveUser && br.Start.DayOfYear == DateTime.Today.DayOfYear).ToList();
            LoadBreakRows();

            Grid.Sort(Grid.Columns[SortColumnIndex], ListSortDirection.Descending);
        }

        private void LoadWorkRows()
        {
            foreach (WorkRegistration registration in WorkRegistrations)
            {
                Grid.Rows.Add(registration.Username, WORK_LABEL, registration.Start, registration.Stop, registration.Description);
            }
        }

        private void LoadBreakRows()
        {
            foreach (BreakRegistration registration in BreakRegistrations)
            {
                Grid.Rows.Add(registration.Username, BREAK_LABEL, registration.Start, registration.Stop, registration.Description);
            }
        }
    }
}