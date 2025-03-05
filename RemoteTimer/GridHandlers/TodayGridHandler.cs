using RemoteTimer.Database;

namespace RemoteTimer.GridHandlers
{
    public class TodayGridHandler : GridHandler
    {
        private List<WorkRegistration> WorkRegistrations { get; set; }
        private List<BreakRegistration> BreakRegistrations { get; set; }

        public TodayGridHandler(DataGridView grid) : base(grid)
        {
            WorkRegistrations = new List<WorkRegistration>();
            BreakRegistrations = new List<BreakRegistration>();
        }

        public void RegisterWork(WorkRegistration registration)
        {
            registration.UsernameNavigation = ActiveUser;

            if (registration.Stop == null)
            {
                DBContext.Add(registration);
            }
            else
            {
                WorkRegistration? result = DBContext.WorkRegistrations
                        .SingleOrDefault(wr => wr.Start == registration.Start && wr.UsernameNavigation == ActiveUser);

                if (result != null)
                {
                    result.Stop = registration.Stop;
                }
            }

            DBContext.SaveChanges();
            LoadGrid();
        }

        public void RegisterBreak(BreakRegistration registration)
        {
            registration.UsernameNavigation = ActiveUser;

            if (registration.Stop == null)
            {
                DBContext.Add(registration);
            }
            else
            {
                BreakRegistration? result = DBContext.BreakRegistrations
                        .SingleOrDefault(br => br.Start == registration.Start && br.UsernameNavigation == ActiveUser);

                if (result != null)
                {
                    result.Stop = registration.Stop;
                }
            }

            DBContext.SaveChanges();
            LoadGrid();
        }

        public override void LoadGrid()
        {
            RefreshGrid();

            WorkRegistrations = DBContext.WorkRegistrations
                .Where(wr => wr.UsernameNavigation == ActiveUser && wr.Start.DayOfYear == DateTime.Today.DayOfYear).ToList();
            LoadWorkRows();

            BreakRegistrations = DBContext.BreakRegistrations
                .Where(br => br.UsernameNavigation == ActiveUser && br.Start.DayOfYear == DateTime.Today.DayOfYear).ToList();
            LoadBreakRows();

            Grid.Sort(Grid.Columns[2], System.ComponentModel.ListSortDirection.Descending);
        }

        private void LoadWorkRows()
        {
            foreach (WorkRegistration registration in WorkRegistrations)
            {
                Grid.Rows.Add(registration.Username, "Work", registration.Start, registration.Stop, registration.Description);
            }
        }

        private void LoadBreakRows()
        {
            foreach (BreakRegistration registration in BreakRegistrations)
            {
                Grid.Rows.Add(registration.Username, "Break", registration.Start, registration.Stop, registration.Description);
            }
        }
    }
}