using RemoteTimer.Database;
using RemoteTimer.GridHandlers;
using RemoteTimer.Clock;

namespace RemoteTimer
{
    public partial class MainForm : Form
    {
        private TodayGridHandler TodayHandler { get; set; }
        private SummaryGridHandler SummaryHandler { get; set; }

        private RemoteTimerClock WorkClock { get; set; }
        private RemoteTimerClock BreakClock { get; set; }

        public MainForm()
        {
            InitializeComponent();

            TodayHandler = new TodayGridHandler(TodayGrid);
            SummaryHandler = new SummaryGridHandler(SummaryGrid);

            WorkClock = new RemoteTimerClock(UpdateWorkTimer);
            BreakClock = new RemoteTimerClock(UpdateBreakTimer);
        }

        private void OnStartWorkButtonClick(object sender, EventArgs e)
        {
            WorkClock.Start();
            WorkRegistration registration = new WorkRegistration { Start = WorkClock.StartTime, Description = WorkDescriptionTextBox.Text };
            TodayHandler.RegisterWork(registration);

            WorkDescriptionTextBox.Enabled = false;
            StartWorkButton.Enabled = false;
            StopWorkButton.Enabled = true;
        }

        private void OnStopWorkButtonClick(object sender, EventArgs e)
        {
            WorkClock.Stop();
            WorkRegistration registration = new WorkRegistration { Start = WorkClock.StartTime, Stop = DateTime.Now };
            TodayHandler.RegisterWork(registration);
            SummaryHandler.RegisterWork(registration);

            WorkDescriptionTextBox.Enabled = true;
            StartWorkButton.Enabled = true;
            StopWorkButton.Enabled = false;
            UpdateWorkTimer(0);
        }

        private void OnStartBreakButtonClick(object sender, EventArgs e)
        {
            BreakClock.Start();
            BreakRegistration registration = new BreakRegistration { Start = BreakClock.StartTime, Description = BreakDescriptionTextBox.Text };
            TodayHandler.RegisterBreak(registration);

            BreakDescriptionTextBox.Enabled = false;
            StartBreakButton.Enabled = false;
            StopBreakButton.Enabled = true;
        }

        private void OnStopBreakButtonClick(object sender, EventArgs e)
        {
            BreakClock.Stop();
            BreakRegistration registration = new BreakRegistration { Start = BreakClock.StartTime, Stop = DateTime.Now };
            TodayHandler.RegisterBreak(registration);
            SummaryHandler.RegisterBreak(registration);

            BreakDescriptionTextBox.Enabled = true;
            StartBreakButton.Enabled = true;
            StopBreakButton.Enabled = false;
            UpdateBreakTimer(0);
        }

        private void UpdateWorkTimer(int seconds)
        {
            if (WorkTimerTextBox.InvokeRequired == true)
            {
                Action safeWrite = delegate { UpdateWorkTimer(seconds); };
                WorkTimerTextBox.Invoke(safeWrite);
            }
            else
            {
                WorkTimerTextBox.Text = TimeSpan.FromSeconds(seconds).ToString(@"hh\:mm\:ss");
            }
        }

        private void UpdateBreakTimer(int seconds)
        {
            if (BreakTimerTextBox.InvokeRequired == true)
            {
                Action safeWrite = delegate { UpdateBreakTimer(seconds); };
                BreakTimerTextBox.Invoke(safeWrite);
            }
            else
            {
                BreakTimerTextBox.Text = TimeSpan.FromSeconds(seconds).ToString(@"hh\:mm\:ss");
            }
        }
    }
}