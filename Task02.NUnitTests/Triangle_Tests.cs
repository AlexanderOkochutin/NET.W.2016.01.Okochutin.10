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
    class Triangle_Tests
    {
        
        [TestCase(3,4,5,12)]
        [TestCase(1.3, 4.2, 5.4, 1.3 + 4.2 + 5.4)]
        public void Triangle_Perimetr(double a, double b, double c, double expectedPerimetr)
        {
            Triangle test = new Triangle(a,b,c);
            Assert.LessOrEqual(Math.Abs(test.Perimetr()-expectedPerimetr),Shape.Epsilon);
        }

        [TestCase(3, 4, 5, 6*(6-3)*(6-4)*(6-5))]
        [TestCase(1.0, 4.6, 5.4,5.5*(5.5-1)*(5.5-4.6)*(5.5-5.4))]
        public void Triangle_Area(double a, double b, double c, double expectedSquareArea)
        {
            Triangle test = new Triangle(a, b, c);
            Assert.LessOrEqual(Math.Abs(test.Area() - Math.Sqrt(expectedSquareArea)), Shape.Epsilon);
        }


        [TestCase(10,1,1,typeof(ArgumentException))]
        [TestCase(0, 1, 1, typeof(ArgumentOutOfRangeException))]
        public void Triangle_Exceptions(double a, double b, double c,Type exceptionType)
        {
            Assert.Throws(exceptionType,() => new Triangle(a, b, c));
        }
    }
}
