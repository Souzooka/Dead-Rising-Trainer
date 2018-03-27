using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Trainer.Classes;
using Trainer.Classes.Padding;

namespace Trainer.Classes
{
    [StructLayout(LayoutKind.Sequential)]
    public struct InGameCameraController
    {
        private IntPtr a; // 0x0
        private bool b; // 0x8 (kind of makes camera finicky against walls when false)
        private Unknown1 c; // 0x9
        private Unknown2 d; // 0xA
        private int e; // 0xC (freezes camera if not 0)
        private int f; // 0x10 (copies value from 0xC)
        public bool CanMove; // 0x14 (locks camera behind Frank if false)
        private Unknown1 g; // 0x15
        private Unknown2 h; // 0x16
        private Unknown4 i; // 0x18
        private Unknown4 j; // 0x1C
        private float k; // 0x20 (act like near clip, causes zfighting at low values)
        private Unknown4 l; // 0x24
        private Unknown4 m; // 0x28
        private Unknown4 n; // 0x2C
        private Unknown4 o; // 0x30
        private Unknown4 p; // 0x34
        private Unknown8 q; // 0x38
        private Unknown16 r; // 0x40
        private Unknown16 s; // 0x50
        private Unknown16 t; // 0x60
        public float AngleY; // 0x70
        public float AngleX; // 0x74
        private Unknown8 u; // 0x78
        public Point3 FocalPosition; // 0x80
        private float v; // 0x8C
        public Point3 Position; // 0x90
        private float w; // 0x9C
        private Point3 x; // 0xA0
        private float y; // 0xAC
        private Unknown16 z; // 0xB0
        private Unknown16 aa; // 0xC0
        private Unknown16 ab; // 0xD0
        private Unknown16 ac; // 0xE0
        private Unknown4 ad; // 0xF0
        private Unknown1 ao; // 0xF4
        public bool DelayedUpdate; // 0xF5 (wait until Frank moves far away enough to update camera)
        private Unknown2 ap; // 0xF6
        private Unknown8 aq; // 0xF8
        private Unknown16 ae; // 0x100
        private Unknown16 af; // 0x110
        private Unknown16 ag; // 0x120
        private Unknown16 ah; // 0x130
        private Unknown16 ai; // 0x140
        private Unknown16 aj; // 0x150
        private Unknown16 ak; // 0x160
        private Unknown16 al; // 0x170
        private Unknown16 am; // 0x180
        private Unknown4 ar; // 0x190
        private float at; // 0x194
        private Unknown8 au; // 0x198
        private Unknown8 av; // 0x1A0
        public float Distance; // 0x1A8 (camera distance from Frank)
        public float HeightOffset; // 0x1AC
        private Unknown8 aw; // 0x1B0
        public float ShortDistance; // 0x1B8 (distance when camera is pushed against a wall)
        private int ax; // 0x1BC
        private float ay; // 0x1C0
        private float az; // 0x1CC
        private Unknown16 ba; // 0x1D0
        private Unknown16 bb; // 0x1E0
        private Unknown16 bc; // 0x1F0
        private Unknown16 bd; // 0x200
        private Unknown16 be; // 0x210
        private Unknown16 bf; // 0x220
        private Unknown16 bg; // 0x230
        private Unknown16 bh; // 0x240
        private Unknown16 bi; // 0x250
        private Unknown16 bj; // 0x260
        private Unknown16 bk; // 0x270
        public Ref<GameObject> ModelFocus; // 0x280
    }
}
