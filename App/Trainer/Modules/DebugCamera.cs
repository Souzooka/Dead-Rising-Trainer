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

            // Camera focal point write opcode (ingame)
            gameMemory.WriteMem(gameMemory.DllImageAddress("DeadRising.exe") + 0xCDB0, new byte[] { 0x90, 0x90, 0x90, 0x90 });
        }

        public static void Stop()
        {
            Enabled = false;
        }

        public static void Update()
        {

        }
    }	
}
