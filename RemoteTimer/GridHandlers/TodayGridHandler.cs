using Microsoft.EntityFrameworkCore;

using RemoteTimer.Models.DataLayer;

namespace RemoteTimer.GridHandlers
{
    public class TodayGridHandler : GridHandler
    {
        private List<WorkRegistration> WorkRegistrations;
        private List<BreakRegistration> BreakRegistrations;

        public TodayGridHandler(DataGridView grid) : base(grid)
        {
            WorkRegistrations = new List<WorkRegistration>();
            BreakRegistrations = new List<BreakRegistration>();

            Load();
        }

        public void Load()
        {
            WorkRegistrations = DatabaseLoader.Instance.Context.WorkRegistrations
                .Where(wr => wr.UsernameNavigation == DatabaseLoader.Instance.UserProvider.ActiveUser)
                .Where(wr => wr.Start.DayOfYear == DateTime.Today.DayOfYear).ToList();
            LoadWorkRegistrations();

            BreakRegistrations = DatabaseLoader.Instance.Context.BreakRegistrations
                .Where(wr => wr.UsernameNavigation == DatabaseLoader.Instance.UserProvider.ActiveUser)
                .Where(br => br.Start.DayOfYear == DateTime.Today.DayOfYear).ToList();
            LoadBreakRegistrations();
        }

        private void LoadWorkRegistrations()
        {
            foreach (WorkRegistration registration in WorkRegistrations)
            {
                SaveWorkRow(registration.Username, registration.Start, registration.Stop, registration.Description);
            }
        }

        private void LoadBreakRegistrations()
        {
            foreach (BreakRegistration registration in BreakRegistrations)
            {
                SaveBreakRow(registration.Username, registration.Start, registration.Stop, registration.Description);
            }
        }

        public void SaveWorkRegistration(WorkRegistration registration)
        {
            Context.Add(registration);
            Context.SaveChanges();
        }

        public void SaveBreakRegistration(BreakRegistration registration)
        {
            Context.Add(registration);
            Context.SaveChanges();
        }

        private bool DoWorkRegistrationRowExists(WorkRegistration registration)
        {
            DatabaseLoader.Instance.Context.WorkRegistrations
                .Where(wr => wr.UsernameNavigation == registration.UsernameNavigation)
                .Where
        }

        private bool DoBreakRegistrationRowExists(BreakRegistration registration)
        {

        }

        private void SaveWorkRow(string username, DateTime start, DateTime? stop, string description)
        {
            Grid.Rows.Add(username, "Work", start, stop, description);
        }

        private void SaveBreakRow(string username, DateTime start, DateTime? stop, string description)
        {
            Grid.Rows.Add(username, "Break", start, stop, description);
        }
    }
}