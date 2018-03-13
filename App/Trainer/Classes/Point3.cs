using System;
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
        public double AngleHorizontal
        {
            get
            {
                return Math.Atan2(this.X, this.Z) * 180 / Math.PI;
            }
        }
        public double AngleVertical
        {
            get
            {
                return Math.Acos(Y / Math.Sqrt(X * X + Y * Y + Z * Z)) * 180 / Math.PI;
            }
        }
        public double Magnitude
        {
            get
            {
                // returns length as if this was a line which starts at 0, 0, 0
                return new Line3(Point3.Zero, this).Magnitude;
            }
            set { }
        }
        public static Point3 Zero = new Point3(0, 0, 0);

        public Point3(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public Point3 Normalize()
        {
            float length = (float)this.Magnitude;

            return new Point3(X / length, Y / length, Z / length);
        }

        // transformation methods
        public static Point3 operator+ (Point3 a, Point3 b)
        {
            return new Point3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static Point3 operator- (Point3 a, Point3 b)
        {
            return new Point3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        public static Point3 operator* (Point3 a, float b)
        {
            return new Point3(a.X * b, a.Y * b, a.Z * b);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            Point3 point = (Point3)obj;

            return this.X == point.X && this.Y == point.Y && this.Z == point.Z;
        }

        public Point3 Clone()
        {
            return (Point3)this.MemberwiseClone();
        }
    }
}
