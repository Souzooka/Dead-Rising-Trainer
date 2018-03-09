using System;
using System.Diagnostics;
using System.Timers;

namespace Trainer
{
    public static class MainTrainer
    {
        public static Process Process;
        private const double timerInterval = 1000.0d / 60.0d;
        private static Timer timer = new Timer(timerInterval);

        static MainTrainer()
        {
            timer.Elapsed += update;
            timer.Start();
        }

        private static void update(object sender, EventArgs e)
        {
            throw new Exception();
        }
    }
}