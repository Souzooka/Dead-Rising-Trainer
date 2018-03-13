using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Trainer.ComponentUtil;

namespace Trainer.Modules
{
    public static class DebugCamera
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

            // Camera position write opcode (ingame)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0xCDB0), new byte[] { 0x90, 0x90, 0x90, 0x90 });

            // Camera focal point write opcode (ingame)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0xCD8F), new byte[] { 0x90, 0x90, 0x90, 0x90 });

            // Camera position write opcode (cutscene) (1 of 2)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x6E53DB), new byte[] { 0x90, 0x90, 0x90, 0x90 });

            // Camera position write opcode (cutscene) (2 of 2)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0xC4CB), new byte[] { 0x90, 0x90, 0x90, 0x90 });

            // Camera focal point write opcode (cutscene) (1 of 3)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x6E53D7), new byte[] { 0x90, 0x90, 0x90, 0x90 });

            // Camera focal point write opcode (cutscene) (2 of 3)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x6E54D0), new byte[] { 0x90, 0x90, 0x90, 0x90 });

            // Camera focal point write opcode (cutscene) (3 of 3)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0xC4CF), new byte[] { 0x90, 0x90, 0x90, 0x90 });

            // Camera position write opcode (photo)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0xD38A), new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });

            // Camera focal point write opcode (photo)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0xD37E), new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });

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
            process.WriteBytes(IntPtr.Add(moduleAddr, 0xCDB0), new byte[] { 0x0F, 0x29, 0x4F, 0x40 });

            // Camera focal point write opcode (ingame)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0xCD8F), new byte[] { 0x0F, 0x29, 0x47, 0x60 });

            // Camera position write opcode (cutscene) (1 of 2)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x6E53DB), new byte[] { 0x0F, 0x29, 0x7D, 0x40 });

            // Camera position write opcode (cutscene) (2 of 2)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0xC4CB), new byte[] { 0x0F, 0x29, 0x75, 0x60 });

            // Camera focal point write opcode (cutscene) (1 of 3)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x6E53D7), new byte[] { 0x0F, 0x29, 0x75, 0x60 });

            // Camera focal point write opcode (cutscene) (2 of 3)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x6E54D0), new byte[] { 0x0F, 0x29, 0x45, 0x60 });

            // Camera focal point write opcode (cutscene) (3 of 3)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0xC4CF), new byte[] { 0x0F, 0x29, 0x56, 0x60 });

            // Camera position write opcode (photo)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0xD38A), new byte[] { 0x41, 0x0F, 0x29, 0x4E, 0x40 });

            // Camera focal point write opcode (photo)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0xD37E), new byte[] { 0x41, 0x0F, 0x29, 0x46, 0x60 });

            // Resume game execution
            process.ResumeProcess();
        }

        public static void Update()
        {

        }
    }	
}
