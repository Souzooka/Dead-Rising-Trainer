using System;
using System.Diagnostics;
using System.Timers;
using ReadWriteMemory;

namespace Trainer
{
    public static class MainTrainer
    {
        public static Process Process
        {
            get
            {
                return process;
            }
            set
            {
                process = value;
                GameMemory = new ProcessMemory(process);
            }
        }
        private static Process process;
        private static ProcessMemory GameMemory;
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

            if (DebugCameraEnabled)
            {
                if (!Modules.DebugCamera.Enabled) { Modules.DebugCamera.Start(process); }
                Modules.DebugCamera.Update();
            }
            else
            {
                if (Modules.DebugCamera.Enabled) { Modules.DebugCamera.Stop(); }
            }
        }
    }
}