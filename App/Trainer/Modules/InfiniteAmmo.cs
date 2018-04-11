using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Trainer.ComponentUtil;

namespace Trainer.Modules
{
    public static class InfiniteAmmo
    {
        public static bool Enabled = false;
        private static Process process;

        public static void Start(Process pProcess)
        {
            process = pProcess;
            Enabled = true;
            IntPtr moduleAddr = process.DllImageAddress("DeadRising.exe");

            // Freeze game to avoid race conditions
            process.SuspendProcess();

            // Overwrite executable code

            // Decrement ammo opcode
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x18CBEC), new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });

            // Resume game execution
            process.ResumeProcess();
        }

        public static void Stop()
        {
            Enabled = false;
            IntPtr moduleAddr = process.DllImageAddress("DeadRising.exe");

            // Freeze game to avoid race conditions
            process.SuspendProcess();

            // Restore executable code

            // Camera position write opcode (ingame)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x18CBEC), new byte[] { 0x66, 0xFF, 0x8B, 0x2C, 0x2E, 0x00, 0x00 });

            // Resume game execution
            process.ResumeProcess();
        }
    }
}
