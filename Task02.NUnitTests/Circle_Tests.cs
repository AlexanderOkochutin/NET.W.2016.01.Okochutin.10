using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task02.Logic;

namespace Task02.NUnitTests
{   
    [TestFixture]
    public class Circle_Tests
    {
        [TestCase(5.0,2*Math.PI*5)]
        [TestCase(10.3, 2 * Math.PI * 10.3)]
        [TestCase(19.1, 2 * Math.PI * 19.1)]
        public void Circle_Perimetr(double radius, double expectedPerimetr)
        {
            Circle test = new Circle(radius);
            Assert.LessOrEqual(Math.Abs(test.Perimetr()-expectedPerimetr), Shape.Epsilon);
        }

        [TestCase(5, Math.PI * 5 * 5)]
        [TestCase(3.2, Math.PI * 3.2 * 3.2)]
        public void Circle_Area(double radius, double expectedArea)
        {
            Circle test = new Circle(radius);
            Assert.LessOrEqual(Math.Abs(test.Area() - expectedArea), Shape.Epsilon);
        }

        [TestCase(-1)]
        public void Circle_Exception(double radius)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
        }
    }
}
