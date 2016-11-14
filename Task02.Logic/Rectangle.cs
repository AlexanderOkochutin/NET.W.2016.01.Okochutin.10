using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Logic
{
    /// <summary>
    /// geometry shape rectangle
    /// </summary>
    public class Rectangle:Shape
    {
        /// <summary>
        /// side a
        /// </summary>
        public double A { get; protected set; }

        /// <summary>
        /// side b
        /// </summary>
        public double B { get; protected set; }

        /// <summary>
        /// constructor of instance of rectangle
        /// </summary>
        /// <param name="a"> side a</param>
        /// <param name="b"> side b</param>
        public Rectangle(double a,double b)
        {
            if (a < Epsilon || b < Epsilon) throw new ArgumentOutOfRangeException();
            A = a;
            B = b;
        }

        /// <summary>
        /// override abstract method of shape
        /// </summary>
        /// <returns> area of rectangle</returns>
        public override double Area() => A * B;

        /// <summary>
        /// override abstract method of shape 
        /// </summary>
        /// <returns>perimetr of rectangle</returns>
        public override double Perimetr() => (A + B) * 2;
    }
}
