using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes.Moduls
{
    class Rectangle : BasicShape
    {
        public Rectangle(double width, double height) 
            : base(width, height)
        {
        }

        public override double CalculateArea() => this.Width*this.Height;

        public override double CalculatePerimeter() => 2*this.Height + 2*this.Width;

    }
}
