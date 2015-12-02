using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes.Moduls
{
    class Rhombus : BasicShape
    {
        public Rhombus(double width, double height) 
            : base(width, height)
        {
        }

        public override double CalculateArea() =>this.Width * this.Height / 2;

        public override double CalculatePerimeter()  => (this.Height + this.Width)*2;


    }
}
