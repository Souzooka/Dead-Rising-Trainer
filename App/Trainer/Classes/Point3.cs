﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Trainer.Classes
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Point3
    {
        public float X;
        public float Y;
        public float Z;

        public Point3(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}