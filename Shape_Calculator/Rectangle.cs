using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Calculator
{
    class Rectangle : Shape, ICalculateArea
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(string name, double length, double width): base(name)
        {
            Length = length;
            Width = width;
        }

        public void CalculateArea()
        {
            double areaRectangle = Length * Width;
            Console.WriteLine($"Area: {areaRectangle}");
        }


    }
}
