using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Logic
{
    /// <summary>
    /// geometry shape triangle
    /// </summary>
    public class Triangle:Shape
    {
        /// <summary>
        /// sides of triangle
        /// </summary>
        public double A { get; }
        public double B { get; }
        public double C { get; }

        /// <summary>
        /// constructor of instance of triangle
        /// </summary>
        /// <param name="a">side a</param>
        /// <param name="b">side b</param>
        /// <param name="c">side c</param>
        public Triangle(double a, double b, double c)
        {
            if (a < Epsilon || b < Epsilon || c < Epsilon)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (a + b > c && a + c > b && b + c > a)
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                throw new ArgumentException("a + b > c && a + c > b && b + c > a");
            }
        }

        /// <summary>
        /// override abstract method of shape
        /// </summary>
        /// <returns>perimetr of triangle</returns>
        public override double Perimetr() => A + B + C;
        
        /// <summary>
        /// override method of shape
        /// </summary>
        /// <returns>area of triangle</returns>
        public override double Area()
        {
            double p = Perimetr()/2;
            return Math.Sqrt(p*(p - A)*(p - B)*(p - C));
        }
    }
}
