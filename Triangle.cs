using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCircle
{
    public class Triangle
    {
        public double BaseT { get; set; }
        public double Height { get; set; }
        public double ASide { get; set; }
        public double CSide { get; set; }

        public Triangle(double baseT, double height)
        {
            BaseT = baseT;
            Height = height;
        }
        public Triangle(double baseT, double aside, double cside)
        {
            BaseT = baseT;
           ASide = aside;
            CSide = cside;
        }

        public double GetPerimeter()
        {
            return BaseT + ASide + CSide;
        }
        public double GetArea()
        {
            return (1.00/2.00) * BaseT * Height;
        }
    }
}
