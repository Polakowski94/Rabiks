using RemoteTimer.Database;
using RemoteTimer.Clock;
using RemoteTimer.Loaders;
using Microsoft.Win32;

namespace RemoteTimer
{
    public partial class MainForm : Form
    {
        private WorkRegister Register { get; set; }
        private PresentDayGridLoader PresentDayLoader { get; set; }
        private SummaryGridLoader SummaryLoader { get; set; }

        private RemoteTimerClock WorkClock { get; set; }
        private RemoteTimerClock BreakClock { get; set; }

        public MainForm()
        {
            InitializeComponent();

            Register = new WorkRegister();
            PresentDayLoader = new PresentDayGridLoader(PresentDayGrid);
            PresentDayLoader.Load();
            SummaryLoader = new SummaryGridLoader(SummaryGrid);
            SummaryLoader.Load();

            WorkClock = new RemoteTimerClock(WorkTimerTextBox, UpdateTimer);
            BreakClock = new RemoteTimerClock(BreakTimerTextBox, UpdateTimer);
        }

        private void OnStartWorkButtonClick(object sender, EventArgs e)
        {
            WorkClock.Start();
            WorkRegistration registration = new WorkRegistration { Start = WorkClock.StartTime, Description = WorkDescriptionTextBox.Text };
            Register.RegisterWork(registration);

            HandleControlsOnTimerStart(WorkDescriptionTextBox, StartWorkButton, StopWorkButton);
        }

        private void OnStopWorkButtonClick(object sender, EventArgs e)
        {
            WorkClock.Stop();
            WorkRegistration registration = new WorkRegistration { Start = WorkClock.StartTime, Stop = DateTime.Now };
            Register.RegisterWork(registration);

            HandleControlsOnTimerStop(WorkDescriptionTextBox, StartWorkButton, StopWorkButton, WorkTimerTextBox);
        }

        private void OnStartBreakButtonClick(object sender, EventArgs e)
        {
            BreakClock.Start();
            BreakRegistration registration = new BreakRegistration { Start = BreakClock.StartTime, Description = BreakDescriptionTextBox.Text };
            Register.RegisterBreak(registration);

            HandleControlsOnTimerStart(BreakDescriptionTextBox, StartBreakButton, StopBreakButton);
        }

        private void OnStopBreakButtonClick(object sender, EventArgs e)
        {
            BreakClock.Stop();
            BreakRegistration registration = new BreakRegistration { Start = BreakClock.StartTime, Stop = DateTime.Now };
            Register.RegisterBreak(registration);

            HandleControlsOnTimerStop(BreakDescriptionTextBox, StartBreakButton, StopBreakButton, BreakTimerTextBox);
        }

        private void HandleControlsOnTimerStart(TextBox descriptionTextBox, Button startButton, Button stopButton)
        {
            descriptionTextBox.Enabled = false;
            startButton.Enabled = false;
            stopButton.Enabled = true;

            PresentDayLoader.Load();
        }

        private void HandleControlsOnTimerStop(TextBox descriptionTextBox, Button startButton, Button stopButton, TextBox timerTextBox)
        {
            descriptionTextBox.Text = string.Empty;
            descriptionTextBox.Enabled = true;
            startButton.Enabled = true;
            stopButton.Enabled = false;
            UpdateTimer(timerTextBox, 0);

            PresentDayLoader.Load();
            SummaryLoader.Load();
        }

        private void UpdateTimer(TextBox timerTextBox, int seconds)
        {
            if (timerTextBox.InvokeRequired == true)
            {
                Action safeWrite = delegate { UpdateTimer(timerTextBox, seconds); };
                timerTextBox.Invoke(safeWrite);
            }
            else
            {
                timerTextBox.Text = TimeSpan.FromSeconds(seconds).ToString(@"hh\:mm\:ss");
            }
        }

        private void OnRefreshButtonClick(object sender, EventArgs e)
        {
            PresentDayLoader.Load();
            SummaryLoader.Load();
        }
    }
}