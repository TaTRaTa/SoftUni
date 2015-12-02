using System;
using System.Collections.Generic;
using _1.Shapes.Interface;
using _1.Shapes.Moduls;

namespace _1.Shapes
{
    class ShapesMain
    {
        static void Main()
        {
            var shapes = new List<IShape>()
            {
                new Rectangle(25.6, 46.3),
                new Circle(.33),
                new Rectangle(1, 2),
                new Circle(5.6),
                new Rhombus(16.6, 78),
                new Circle(25.6),
            };

            shapes.ForEach(shape =>
            Console.WriteLine($"{shape.GetType().Name,-10} [Area: {shape.CalculateArea():F2} | Perimiter: {shape.CalculatePerimeter():F2}]"));
           
        }
    }
}
