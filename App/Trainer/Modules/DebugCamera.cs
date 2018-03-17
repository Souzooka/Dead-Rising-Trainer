using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Trainer.ComponentUtil;
using Trainer.Classes;

namespace Trainer.Modules
{
    public static class DebugCamera
    {
        private const float transformModifier = 50.0f;
        private const float rotationModifier = 3.0f;
        private const float fovModifier = 0.5f;

        // variables for key modifiers
        private static float transformMod;
        private static float rotationMod;
        private static float fovMod;

        public static bool Enabled = false;
        private static Process process;
        private static DeepPointer cameraPtr = new DeepPointer("DeadRising.exe", 0x01CF3648, 0x58, 0x0);
        

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

            // Camera FOV write opcode (ingame)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0xCDB9), new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });

            // Camera FOV write opcode (photo) (1 of 3)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0xD245), new byte[] { 0x90, 0x90, 0x90, 0x90 });

            // Camera FOV write opcode (photo) (2 of 3)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x1283E5), new byte[] { 0x90, 0x90, 0x90, 0x90 });

            // Camera FOV write opcode (photo) (3 of 3)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0xCEC8), new byte[] { 0x90, 0x90, 0x90, 0x90 });

            // Camera FOV write opcode (cutscene)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x6E53CB), new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 });

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

            // Camera FOV write opcode (ingame)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0xCDB9), new byte[] { 0xC7, 0x47, 0x34, 0x00, 0x00, 0x5C, 0x42 });

            // Camera FOV write opcode (photo) (1 of 3)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0xD245), new byte[] { 0x41, 0x89, 0x46, 0x34 });

            // Camera FOV write opcode (photo) (2 of 3)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x1283E5), new byte[] { 0x41, 0x89, 0x50, 0x34 });

            // Camera FOV write opcode (photo) (3 of 3)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0xCEC8), new byte[] { 0x41, 0x89, 0x46, 0x34 });

            // Camera FOV write opcode (cutscene)
            process.WriteBytes(IntPtr.Add(moduleAddr, 0x6E53CB), new byte[] { 0xF3, 0x44, 0x0F, 0x11, 0x55, 0x34 });

            // Resume game execution
            process.ResumeProcess();
        }

        public static void Update()
        {
            transformMod = transformModifier;
            rotationMod = rotationModifier;
            fovMod = fovModifier;

            updateTransform();
            updateRotation();
            updateFov();
        }

        private static void updateFov()
        {
            IntPtr camera;
            cameraPtr.DerefOffsets(process, out camera);
            float fov = process.ReadValue<float>(IntPtr.Add(camera, 0x34));

            // Change FOV
            if (VirtualKey.VK_KEY_Q.IsDown()) { fov = Math.Max(fovModifier, fov - fovMod); }
            if (VirtualKey.VK_KEY_E.IsDown()) { fov = Math.Min(180 - fovModifier, fov + fovMod); }

            process.WriteValue<float>(IntPtr.Add(camera, 0x34), fov);
        }

        private static void updateRotation()
        {
            IntPtr camera;
            cameraPtr.DerefOffsets(process, out camera);

            Point3 cameraPos = process.ReadValue<Point3>(IntPtr.Add(camera, 0x40));
            Point3 cameraFocalPos = process.ReadValue<Point3>(IntPtr.Add(camera, 0x60));
            Point3 delta = cameraPos - cameraFocalPos;
            Line3 cameraVector = new Line3(cameraPos, cameraFocalPos);
            Point3 normalized = cameraVector.Direction.Normalize();
            double angleHorizontal = normalized.AngleHorizontal;
            double angleVertical = normalized.AngleVertical;

            // Horizontal rotations
            if (VirtualKey.VK_NUMPAD4.IsDown()) { normalized.AngleHorizontal += rotationModifier; }
            if (VirtualKey.VK_NUMPAD6.IsDown()) { normalized.AngleHorizontal -= rotationModifier; }
            normalized.AngleVertical = angleVertical;
            angleHorizontal = normalized.AngleHorizontal;

            // Vertical rotations
            if (VirtualKey.VK_NUMPAD5.IsDown()) { normalized.AngleVertical += rotationModifier; }
            if (VirtualKey.VK_NUMPAD8.IsDown()) { normalized.AngleVertical -= rotationModifier; }
            normalized.AngleHorizontal = angleHorizontal;

            // Restore camera magnitude and write to memory
            normalized *= (float)cameraVector.Magnitude;
            process.WriteValue<Point3>(IntPtr.Add(camera, 0x60), (cameraPos + normalized));
        }

        private static void updateTransform()
        {
            IntPtr camera;
            cameraPtr.DerefOffsets(process, out camera);

            Point3 cameraPos = process.ReadValue<Point3>(IntPtr.Add(camera, 0x40));
            Point3 cameraFocalPos = process.ReadValue<Point3>(IntPtr.Add(camera, 0x60));
            Line3 cameraVector = new Line3(cameraPos, cameraFocalPos);
            Point3 normalized = cameraVector.Direction.Normalize();

            if (VirtualKey.VK_KEY_W.IsDown())
            {
                cameraPos += (normalized * transformModifier);
                cameraFocalPos += (normalized * transformModifier);
            }

            if (VirtualKey.VK_KEY_S.IsDown())
            {
                cameraPos -= (normalized * transformModifier);
                cameraFocalPos -= (normalized * transformModifier);
            }

            if (VirtualKey.VK_KEY_A.IsDown())
            {
                Point3 normalizedCopy = normalized.Clone();

                normalizedCopy.X = normalized.Z;
                normalizedCopy.Y = 0;
                normalizedCopy.Z = -normalized.X;

                cameraPos += (normalizedCopy * transformModifier);
                cameraFocalPos += (normalizedCopy * transformModifier);
            }

            if (VirtualKey.VK_KEY_D.IsDown())
            {
                Point3 normalizedCopy = normalized.Clone();

                normalizedCopy.X = -normalized.Z;
                normalizedCopy.Y = 0;
                normalizedCopy.Z = normalized.X;

                cameraPos += (normalizedCopy * transformModifier);
                cameraFocalPos += (normalizedCopy * transformModifier);
            }

            process.WriteValue<Point3>(IntPtr.Add(camera, 0x40), cameraPos);
            process.WriteValue<Point3>(IntPtr.Add(camera, 0x60), cameraFocalPos);
        }
    }	
}
