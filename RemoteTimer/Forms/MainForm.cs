using RemoteTimer.GridHandlers;
using RemoteTimer.Models.DataLayer;

namespace RemoteTimer
{
    public partial class MainForm : Form
    {
        private User ActiveUser { get; set; }
        private TodayGridHandler TodayHandler { get; set; }
        private SummaryGridHandler SummaryHandler { get; set; }

        public MainForm()
        {
            InitializeComponent();

            ActiveUser = DatabaseLoader.Instance.UserProvider.ActiveUser;

            TodayHandler = new TodayGridHandler(TodayGrid);
            SummaryHandler = new SummaryGridHandler(SummaryGrid);
        }

        private void OnStartWorkButtonClick(object sender, EventArgs e)
        {
            WorkRegistration registration = new WorkRegistration
            {
                UsernameNavigation = ActiveUser,
                Start = DateTime.Now,
                Description = WorkDescriptionTextBox.Text
            };

            TodayHandler.SaveWorkRegistration(registration);
        }

        private void OnStopWorkButtonClick(object sender, EventArgs e)
        {
            WorkRegistration registration = new WorkRegistration
            {
                UsernameNavigation = ActiveUser,
                Stop = DateTime.Now
            };

            TodayHandler.SaveWorkRegistration(registration);
        }

        private void OnStartBreakButtonClick(object sender, EventArgs e)
        {
            BreakRegistration registration = new BreakRegistration
            {
                UsernameNavigation = ActiveUser,
                Start = DateTime.Now,
                Description = WorkDescriptionTextBox.Text
            };

            TodayHandler.SaveBreakRegistration(registration);
        }

        private void OnStopBreakButtonClick(object sender, EventArgs e)
        {
            BreakRegistration registration = new BreakRegistration
            {
                UsernameNavigation = ActiveUser,
                Stop = DateTime.Now
            };

            TodayHandler.SaveBreakRegistration(registration);
        }
    }
}