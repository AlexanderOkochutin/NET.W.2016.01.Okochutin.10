using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Globalization;

namespace Task02.Logic
{
    /// <summary>
    /// abstract class of two dimension shape
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// accuracy wich set in config file
        /// </summary>
        public static double Epsilon { get; }
      
        static Shape()
        {
            try
            {
                Epsilon = double.Parse(ConfigurationManager.AppSettings["epsilon"], CultureInfo.InvariantCulture);
            }
            catch
            {
                Epsilon = 1e-5;
            }
        }

        /// <summary>
        /// abstract method to find area of two dimension shape
        /// </summary>
        /// <returns>area of shape</returns>
        public abstract double Area();

        /// <summary>
        /// abstract method to find perimetr of two dimension shape
        /// </summary>
        /// <returns>perimetr of two dimension shape</returns>
        public abstract double Perimetr();
    }
}
