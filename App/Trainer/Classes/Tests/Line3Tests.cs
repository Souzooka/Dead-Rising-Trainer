using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Trainer.Classes.Tests
{
    [TestFixture]
    public class Line3Tests
    {
        [Test]
        public void DirectionTests()
        {
            Point3 start = new Point3(0, 0, 0);
            Point3 end = new Point3(1, 2, 3);
            Line3 line = new Line3(start, end);
            Assert.That(line.Direction, Is.EqualTo(new Point3(1, 2, 3)));

            start = new Point3(-1, -2, -3);
            end = new Point3(1, 2, 3);
            line = new Line3(start, end);
            Assert.That(line.Direction, Is.EqualTo(new Point3(2, 4, 6)));
        }

        [Test]
        public void MagnitudeTests()
        {
            Point3 start = new Point3(0, 0, 0);
            Point3 end = new Point3(0, 0, 1);
            Line3 line = new Line3(start, end);
            Assert.That(line.Magnitude, Is.EqualTo(1d));

            start = new Point3(0, 0, 0);
            end = new Point3(0, 1, 0);
            line = new Line3(start, end);
            Assert.That(line.Magnitude, Is.EqualTo(1d));

            start = new Point3(0, 0, 0);
            end = new Point3(1, 0, 0);
            line = new Line3(start, end);
            Assert.That(line.Magnitude, Is.EqualTo(1d));

            start = new Point3(0, 0, 0);
            end = new Point3(5, 5, 5);
            line = new Line3(start, end);
            Assert.That(line.Magnitude, Is.EqualTo(Math.Sqrt(75)));
        }
    }
}
