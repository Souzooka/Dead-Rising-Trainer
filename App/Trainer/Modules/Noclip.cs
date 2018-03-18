using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Trainer.Classes;
using Trainer.ComponentUtil;

namespace Trainer.Modules
{
    public static class Noclip
    {
        private static Camera camera;
        private static IntPtr cameraPtr;
        private static Point3 frankPosition;
        private static DeepPointer frankPositionDeepPtr = new DeepPointer("DeadRising.exe", 0x01CF2620, 0xC8, 0x40);
        private static IntPtr frankPositionPtr;
        private static float transformModifer = 50.0f;
        private static Process process;

        public static bool Enabled;

        public static void Start(Process pProcess)
        {
            process = pProcess;
            Enabled = true;
            IntPtr moduleAddr = process.DllImageAddress("DeadRising.exe");

            // Freeze game to avoid race conditions
            process.SuspendProcess();

            // Overwrite executable code

            process.WriteBytes(IntPtr.Add(moduleAddr, 0x33A00C), new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x133215), new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x1F2C55), new byte[] { 0x90, 0x90, 0x90, 0x90 });
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x339D50), new byte[] { 0x90, 0x90, 0x90 });
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x33A1C1), new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90 });
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x6BCA8A), new byte[] { 0x90, 0x90, 0x90, 0x90 });
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x339D76), new byte[] { 0x90, 0x90, 0x90 });
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x14EA96), new byte[] { 0x90, 0x90, 0x90, 0x90 });

            // Resume game execution
            process.ResumeProcess();
        }

        public static void Update()
        {
            DebugCamera.CameraDeepPtr.DerefOffsets(process, out cameraPtr);
            camera = process.ReadValue<Camera>(cameraPtr);

            frankPositionDeepPtr.DerefOffsets(process, out frankPositionPtr);
            frankPosition = process.ReadValue<Point3>(frankPositionPtr);

            updatePosition();

            process.WriteValue<Point3>(frankPositionPtr, frankPosition);
        }

        public static void updatePosition()
        {
            var unit = new Point3((float)Math.Sin(camera.HorizontalAngle), 0, (float)Math.Cos(camera.HorizontalAngle));

            // Forward movement
            if (VirtualKey.VK_KEY_W.IsDown()) { frankPosition -= (unit * transformModifer); }
            // Backwards movement
            if (VirtualKey.VK_KEY_S.IsDown()) { frankPosition += (unit * transformModifer); }
            // Sideways movements
            if (VirtualKey.VK_KEY_A.IsDown()) { frankPosition += (new Point3(-unit.Z, 0, unit.X) * transformModifer);  }
            if (VirtualKey.VK_KEY_D.IsDown()) { frankPosition += (new Point3(unit.Z, 0, -unit.X) * transformModifer);  }
            // Vertical movements
            if (VirtualKey.VK_KEY_R.IsDown()) { frankPosition += (new Point3(0, 1, 0) * transformModifer); }
            if (VirtualKey.VK_KEY_F.IsDown()) { frankPosition += (new Point3(0, -1, 0) * transformModifer); }
        }

        public static void Stop()
        {
            Enabled = false;
            IntPtr moduleAddr = process.DllImageAddress("DeadRising.exe");

            // Freeze game to avoid race conditions
            process.SuspendProcess();

            // Overwrite executable code

            process.WriteBytes(IntPtr.Add(moduleAddr, 0x33A00C), new byte[] { 0x41, 0x0F, 0x29, 0x04, 0x24 });
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x133215), new byte[] { 0xF3, 0x0F, 0x11, 0x43, 0x44 });
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x1F2C55), new byte[] { 0x0F, 0x29, 0x5B, 0x40 });
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x339D50), new byte[] { 0x0F, 0x29, 0x01 });
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x33A1C1), new byte[] { 0x41, 0x0F, 0x29, 0x04, 0x24 });
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x6BCA8A), new byte[] { 0x0F, 0x29, 0x47, 0x40 });
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x339D76), new byte[] { 0x0F, 0x29, 0x00 });
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x14EA96), new byte[] { 0x0F, 0x29, 0x41, 0x40 });

            // Resume game execution
            process.ResumeProcess();
        }
    }
}
