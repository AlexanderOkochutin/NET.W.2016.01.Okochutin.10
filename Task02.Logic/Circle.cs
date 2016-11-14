using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Logic
{
    /// <summary>
    /// Geometry shape circle
    /// </summary>
    public class Circle:Shape
    {
        /// <summary>
        /// radius of circle
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// constructor of instance of circle
        /// </summary>
        /// <param name="radius"> radius of circle</param>
        public Circle(double radius)
        {
            if (radius < Epsilon) throw new ArgumentOutOfRangeException(nameof(radius));
            Radius = radius;
        }

        /// <summary>
        /// override abstract method of shape
        /// </summary>
        /// <returns>area of circle</returns>
        public override double Area() => Math.PI*Math.Pow(Radius, 2);

        /// <summary>
        /// override abstract method of shape
        /// </summary>
        /// <returns> perimetr of circle</returns>
        public override double Perimetr() => 2*Math.PI*Radius;
    }
}
