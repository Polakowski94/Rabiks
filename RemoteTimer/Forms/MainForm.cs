using RemoteTimer.Database;
using RemoteTimer.Registers;
using RemoteTimer.Clock;

namespace RemoteTimer
{
    public partial class MainForm : Form
    {
        private PresentDayTimeRegister PresentDayRegister { get; set; }
        private WorkDaySummaryRegister SummaryRegister { get; set; }

        private RemoteTimerClock WorkClock { get; set; }
        private RemoteTimerClock BreakClock { get; set; }

        public MainForm()
        {
            InitializeComponent();

            PresentDayRegister = new PresentDayTimeRegister(PresentDayGrid);
            SummaryRegister = new WorkDaySummaryRegister(SummaryGrid);

            WorkClock = new RemoteTimerClock(WorkTimerTextBox, UpdateTimer);
            BreakClock = new RemoteTimerClock(BreakTimerTextBox, UpdateTimer);
        }

        private void OnStartWorkButtonClick(object sender, EventArgs e)
        {
            WorkClock.Start();
            WorkRegistration registration = new WorkRegistration { Start = WorkClock.StartTime, Description = WorkDescriptionTextBox.Text };
            PresentDayRegister.RegisterWork(registration);

            HandleControlsOnTimerStart(WorkDescriptionTextBox, StartWorkButton, StopWorkButton);
        }

        private void OnStopWorkButtonClick(object sender, EventArgs e)
        {
            WorkClock.Stop();
            WorkRegistration registration = new WorkRegistration { Start = WorkClock.StartTime, Stop = DateTime.Now };
            PresentDayRegister.RegisterWork(registration);
            SummaryRegister.RegisterWork(registration);

            HandleControlsOnTimerStop(WorkDescriptionTextBox, StartWorkButton, StopWorkButton, WorkTimerTextBox);
        }

        private void OnStartBreakButtonClick(object sender, EventArgs e)
        {
            BreakClock.Start();
            BreakRegistration registration = new BreakRegistration { Start = BreakClock.StartTime, Description = BreakDescriptionTextBox.Text };
            PresentDayRegister.RegisterBreak(registration);

            HandleControlsOnTimerStart(BreakDescriptionTextBox, StartBreakButton, StopBreakButton);
        }

        private void OnStopBreakButtonClick(object sender, EventArgs e)
        {
            BreakClock.Stop();
            BreakRegistration registration = new BreakRegistration { Start = BreakClock.StartTime, Stop = DateTime.Now };
            PresentDayRegister.RegisterBreak(registration);
            SummaryRegister.RegisterBreak(registration);

            HandleControlsOnTimerStop(BreakDescriptionTextBox, StartBreakButton, StopBreakButton, BreakTimerTextBox);
        }

        private void HandleControlsOnTimerStart(TextBox descriptionTextBox, Button startButton, Button stopButton)
        {
            descriptionTextBox.Enabled = false;
            startButton.Enabled = false;
            stopButton.Enabled = true;
        }

        private void HandleControlsOnTimerStop(TextBox descriptionTextBox, Button startButton, Button stopButton, TextBox timerTextBox)
        {
            descriptionTextBox.Text = string.Empty;
            descriptionTextBox.Enabled = true;
            startButton.Enabled = true;
            stopButton.Enabled = false;
            UpdateTimer(timerTextBox, 0);
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
    }
}