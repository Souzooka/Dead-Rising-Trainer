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
        public static bool DebugCameraEnabled = false;

        static MainTrainer()
        {
            timer.Elapsed += update;
            timer.Start();
        }

        private static void update(object sender, EventArgs e)
        {
            if (Process == null) { return; }
            if (Process.HasExited)
            {
                // TODO: Update UI to show connection state
                return;
            }

            if (DebugCameraEnabled)
            {
                if (!Modules.DebugCamera.Enabled) { Modules.DebugCamera.Start(Process); }
                Modules.DebugCamera.Update();
            }
            else
            {
                if (Modules.DebugCamera.Enabled) { Modules.DebugCamera.Stop(); }
            }
        }
    }
}