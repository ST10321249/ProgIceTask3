namespace Shape_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle("Rectangle", 10, 12);
            rec.Display();
            rec.CalculateArea();

            Console.WriteLine();

            Circle circ = new Circle("Circle", 12);
            circ.Display();
            circ.CalculateArea();

            Console.ReadKey();
        }
    }
}
