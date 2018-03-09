using System;
using System.Diagnostics;
using System.Timers;

namespace TrainerSpace
{
    public static class Trainer
    {
        public static Process Process;
        private static double timerInterval = 1000.0d / 60.0d;
        private static Timer timer = new Timer(timerInterval);

        static Trainer()
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