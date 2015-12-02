using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes.Moduls
{
    using Interface;
    class Circle : IShape
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; set; }

        public double CalculateArea() => Math.Pow(Math.PI*this.Radius, 2);
        public double CalculatePerimeter() => 2*Math.PI*this.Radius;

    }
}
