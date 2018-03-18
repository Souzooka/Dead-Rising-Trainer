using Trainer.Classes;
using Trainer.Classes.Padding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

#pragma warning disable CS0169
// represents the game camera
namespace Trainer.Classes
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Camera
    {
        private IntPtr a; // 0x0
        private Unknown8 b; // 0x8
        private Unknown8 c; // 0x10
        private Unknown8 d; // 0x18
        private float e; // 0x20
        private Unknown4 f; // 0x24
        public float FarClip; // 0x28 (distance to render)
        private float NearClip; // 0x2C (distance to start rendering)
        private float i; // 0x30
        public float Fov; // 0x34
        private Unknown8 k; // 0x38
        public Point3 Position; // 0x40
        private float m; // 0x4C
        public float TiltX; // 0x50
        public float TiltY; // 0x54
        public float TiltZ; // 0x58
        private float n; // 0x5C
        public Point3 FocalPosition; // 0x60
        private Unknown4 o; // 0x6C
        private Unknown16 p; // 0x70
        private Unknown16 q; // 0x80
        private Unknown16 r; // 0x90
        private Unknown16 s; // 0xA0
        private Unknown16 t; // 0xB0
        private Unknown16 u; // 0xC0
        private Unknown16 w; // 0xD0
        public Point3 Normalized; // 0xE0
        private Unknown4 x; //0xEC
        private Unknown4 y; //0xF0
        private float z; // 0xF4
        private Unknown4 aa; // 0xF8
        private Unknown4 ab; // 0xFC
        private Unknown4 ac; // 0x100
        private float ad; // 0x104
        private Unknown4 ae; // 0x108
        private Unknown4 af; // 0x10C
        private Unknown8 ag; // 0x110
        private float ah; // 0x118
        private Unknown4 ai; // 0x11C
        private IntPtr /* ?? */ aj; // 0x120
        private float /* ?? */ ak; // 0x128
        private float /* ?? */ al; // 0x12C
        private Unknown8 am; // 0x130
        public float Magnitude; // 0x138
        private Unknown4 ao; // 0x13C
        private IntPtr /* ?? */ ap; // 0x140
        private Unknown8 aq; // 0x148
        private Unknown8 ar; // 0x150
        private float at; // 0x158
        private Unknown4 au; // 0x15C
        private Unknown16 aw; // 0x160
        private Unknown16 ax; // 0x170
        private Unknown16 ay; // 0x180
        private Unknown4 az; // 0x190
    }
}

#pragma warning restore CS0169 
