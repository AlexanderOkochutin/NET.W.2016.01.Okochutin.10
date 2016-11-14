using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02.Logic
{
    /// <summary>
    /// geometry shape square
    /// </summary>
    public class Square:Rectangle
    {
        /// <summary>
        /// constructor of instance of square
        /// </summary>
        /// <param name="side">side of square</param>
        public Square(double side):base(side,side)
        {
        }
    }
}
