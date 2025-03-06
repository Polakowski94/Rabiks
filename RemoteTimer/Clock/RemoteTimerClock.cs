using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteTimer.Clock
{
    public class RemoteTimerClock
    {
        public Action<TextBox, int> OnStopwatchSecondPassed;
      
        public DateTime StartTime { get; private set; }
        private TextBox TimerTextBox { get; set; }
        private Thread StopwatchThread { get; set; }

        public RemoteTimerClock(TextBox timerTextBox, Action<TextBox, int> updateTimerMethod)
        {
            TimerTextBox = timerTextBox;
            OnStopwatchSecondPassed += updateTimerMethod;
        }

        public void Start()
        {
            StartTime = DateTime.Now;
            StopwatchThread = new Thread(new ThreadStart(WorkStopwatchThread));
            StopwatchThread.Start();
        }

        public void Stop()
        {
            StopwatchThread.Interrupt();
        }

        private void WorkStopwatchThread()
        {
            var secondsPassed = 0;

            while (true)
            {
                try
                {
                    Thread.Sleep(1000);
                }
                catch
                {
                    break;
                }

                secondsPassed++;
                OnStopwatchSecondPassed.Invoke(TimerTextBox, secondsPassed);
            }
        }
    }
}