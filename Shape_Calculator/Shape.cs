using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Calculator
{
    class Shape
    {
        public string Name { get; set; }
        public Shape(string name)
        {
            Name = name;
        }

        public virtual void CalculateArea()
        {
            Console.WriteLine("This will be overriden");
        }

        public void Display()
        {
            Console.WriteLine($"Shape: {Name}");
        }
    }
}
