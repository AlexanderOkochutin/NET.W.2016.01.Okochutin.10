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
    class Square_Tests
    {
        [TestCase(3.2,(3.2+3.2)*2)]
        [TestCase(5,(5+5)*2)]
        public void Square_Perimetr(double a,double expectedPerimetr)
        {
            Square test = new Square(a);
            Assert.LessOrEqual(Math.Abs(test.Perimetr()-expectedPerimetr), Shape.Epsilon);
        }

        [TestCase(3.2, 3.2*3.2)]
        [TestCase(5, 5*5)]
        public void Square_Area(double a, double expectedArea)
        {
            Square test = new Square(a);
            Assert.LessOrEqual(Math.Abs(test.Area() - expectedArea), Shape.Epsilon);
        }

        [TestCase(-1)]
        public void Square_Exception(double side)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Square(side));
        }
    }
}
