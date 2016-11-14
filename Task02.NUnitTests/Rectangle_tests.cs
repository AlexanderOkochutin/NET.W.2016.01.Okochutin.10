using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task02.Logic;
using NUnit.Framework;

namespace Task02.NUnitTests
{
    [TestFixture]
    class Rectangle_tests
    {
        [TestCase(4, 4, (4 + 4)*2)]
        [TestCase(5.2, 3.9, (5.2 + 3.9)*2)]
        public void Rectangle_Perimetr(double a, double b, double expectedPerimetr)
        {
            Rectangle test = new Rectangle(a, b);
            Assert.LessOrEqual(Math.Abs(test.Perimetr() - expectedPerimetr),Shape.Epsilon);
        }

        [TestCase(2.62,2,2.62*2)]
        [TestCase(5.1, 3.4, 5.1*3.4)]
        public void Rectangle_Area(double a, double b, double expectedArea)
        {
            Rectangle test = new Rectangle(a, b);
            Assert.LessOrEqual(Math.Abs(test.Area() - expectedArea),Shape.Epsilon);
        }

        [TestCase(-5,1)]
        public void Rectangle_Exception(double a,double b)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Rectangle(a, b));
        }

    }
}
