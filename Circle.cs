using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCircle
{
    public class Circle
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public double GetArea()
        {
            return Radius * Radius * Math.PI;
        }
        public double GetPerimeter()
        {
            return 2 * Radius * Math.PI;
        }
        public double GetVolume()
        {
            return (4.0/3.0) * Math.PI * Math.Pow(Radius, 3);
        }



    }
}
