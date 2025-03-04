using RemoteTimer.Models.DataLayer;

namespace RemoteTimer
{
    public partial class MainForm : Form
    {
        RemoteTimerDatabaseContext DatabaseContext = new RemoteTimerDatabaseContext();
        WorkDaySummary Summary;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnStartWorkButtonClick(object sender, EventArgs e)
        {

        }

        private void OnStopWorkButtonClick(object sender, EventArgs e)
        {

        }

        private void OnStartBreakButtonClick(object sender, EventArgs e)
        {

        }

        private void OnStopBreakButtonClick(object sender, EventArgs e)
        {

        }
    }
}