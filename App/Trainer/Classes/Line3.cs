using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trainer.Classes
{
    public class Line3
    {
        public Point3 Start;
        public Point3 End;
        public double Magnitude
        {
            get
            {
                Point3 direction = this.Direction;

                // http://members.tripod.com/~Paul_Kirby/vector/VLintro.html#magniofvectors
                return Math.Sqrt(Math.Pow(direction.X, 2) + Math.Pow(direction.Y, 2) + Math.Pow(direction.Z, 2));
            }
            set { }
        }
        // represents the direction (the difference between the start and end of the line)
        public Point3 Direction
        {
            get
            {
                return new Point3(End.X - Start.X, End.Y - Start.Y, End.Z - Start.Z);
            }
            set { }
        }

        public Line3(Point3 start, Point3 end)
        {
            this.Start = start;
            this.End = end;
        }
    }
}
