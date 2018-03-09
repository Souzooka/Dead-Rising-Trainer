using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using ReadWriteMemory;

namespace Trainer.Modules
{
    public static class DebugCamera
    {
        public static bool Enabled = false;
        private static ProcessMemory gameMemory;

        public static void Start(Process process)
        {
            Enabled = true;
            gameMemory = new ProcessMemory(process);
            gameMemory.StartProcess();

			// Freeze game to avoid race conditions
            gameMemory.SuspendProcess();

			// Overwrite executable code

            // Camera position write opcode (ingame)
            gameMemory.WriteMem(gameMemory.DllImageAddress("DeadRising.exe") + 0xCDB0, new byte[] { 0x90, 0x90, 0x90, 0x90 });

            // Camera focal point write opcode (ingame)
            gameMemory.WriteMem(gameMemory.DllImageAddress("DeadRising.exe") + 0xCD8F, new byte[] { 0x90, 0x90, 0x90, 0x90 });

            // Camera position write opcode (cutscene) (1 of 2)
            gameMemory.WriteMem(gameMemory.DllImageAddress("DeadRising.exe") + 0x6E53DB, new byte[] { 0x90, 0x90, 0x90, 0x90 });

            // Camera position write opcode (cutscene) (2 of 2)
            gameMemory.WriteMem(gameMemory.DllImageAddress("DeadRising.exe") + 0xC4CB, new byte[] { 0x90, 0x90, 0x90, 0x90 });

            // Camera focal point write opcode (cutscene) (1 of 3)
            gameMemory.WriteMem(gameMemory.DllImageAddress("DeadRising.exe") + 0x6E53D7, new byte[] { 0x90, 0x90, 0x90, 0x90 });

            // Camera focal point write opcode (cutscene) (2 of 3)
            gameMemory.WriteMem(gameMemory.DllImageAddress("DeadRising.exe") + 0x6E54D0, new byte[] { 0x90, 0x90, 0x90, 0x90 });

            // Camera focal point write opcode (cutscene) (3 of 3)
            gameMemory.WriteMem(gameMemory.DllImageAddress("DeadRising.exe") + 0xC4CF, new byte[] { 0x90, 0x90, 0x90, 0x90 });

            // Camera position write opcode (photo)
            gameMemory.WriteMem(gameMemory.DllImageAddress("DeadRising.exe") + 0xD38A, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });

            // Camera focal point write opcode (photo)
            gameMemory.WriteMem(gameMemory.DllImageAddress("DeadRising.exe") + 0xD37E, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });

            // Resume game execution
            gameMemory.ResumeProcess();
        }

        public static void Stop()
        {
            Enabled = false;

            // Freeze game to avoid race conditions
            gameMemory.SuspendProcess();

            // Restore executable code

            // Camera position write opcode (ingame)
            gameMemory.WriteMem(gameMemory.DllImageAddress("DeadRising.exe") + 0xCDB0, new byte[] { 0x0F, 0x29, 0x4F, 0x40 });

            // Camera focal point write opcode (ingame)
            gameMemory.WriteMem(gameMemory.DllImageAddress("DeadRising.exe") + 0xCD8F, new byte[] { 0x0F, 0x29, 0x47, 0x60 });

            // Camera position write opcode (cutscene) (1 of 2)
            gameMemory.WriteMem(gameMemory.DllImageAddress("DeadRising.exe") + 0x6E53DB, new byte[] { 0x0F, 0x29, 0x7D, 0x40 });

            // Camera position write opcode (cutscene) (2 of 2)
            gameMemory.WriteMem(gameMemory.DllImageAddress("DeadRising.exe") + 0xC4CB, new byte[] { 0x0F, 0x29, 0x75, 0x60 });

            // Camera focal point write opcode (cutscene) (1 of 3)
            gameMemory.WriteMem(gameMemory.DllImageAddress("DeadRising.exe") + 0x6E53D7, new byte[] { 0x0F, 0x29, 0x75, 0x60 });

            // Camera focal point write opcode (cutscene) (2 of 3)
            gameMemory.WriteMem(gameMemory.DllImageAddress("DeadRising.exe") + 0x6E54D0, new byte[] { 0x0F, 0x29, 0x45, 0x60 });

            // Camera focal point write opcode (cutscene) (3 of 3)
            gameMemory.WriteMem(gameMemory.DllImageAddress("DeadRising.exe") + 0xC4CF, new byte[] { 0x0F, 0x29, 0x56, 0x60 });

            // Camera position write opcode (photo)
            gameMemory.WriteMem(gameMemory.DllImageAddress("DeadRising.exe") + 0xD38A, new byte[] { 0x41, 0x0F, 0x29, 0x4E, 0x40 });

            // Camera focal point write opcode (photo)
            gameMemory.WriteMem(gameMemory.DllImageAddress("DeadRising.exe") + 0xD37E, new byte[] { 0x41, 0x0F, 0x29, 0x46, 0x60 });

            // Resume game execution
            gameMemory.ResumeProcess();
        }

        public static void Update()
        {

        }
    }	
}
