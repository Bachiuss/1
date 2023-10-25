using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTry
{
    public class Circle : Shape
    {
        private double _radius;


        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateArea()
        {
            area = Math.PI * (_radius * _radius);
            return area;
        }
    }
}
