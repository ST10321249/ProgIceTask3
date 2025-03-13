using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Calculator
{
    class Circle : Shape, ICalculateArea
    {
        public double Radius { get; set; }

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public void CalculateArea()
        {
            double areaCircle = double.Pi * Radius * Radius;
            Console.WriteLine($"Area: {areaCircle:F2}");
        }
    }
}
