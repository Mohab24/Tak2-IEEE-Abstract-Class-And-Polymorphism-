using Tak2_IEEE__Abstract_Class_And___Polymorphism_;

namespace Tak2_IEEE__Abstract_Class_And___Polymorphism_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Shape> shapes = new List<Shape>()
            {
                  new Circle(5),
                   new Rectangle(4, 6),
                     new Triangle(3, 4, 5),
                       new Circle(3),
                        new Rectangle(10, 5)
            };

            foreach (Shape shape in shapes)
            {
                shape.Display();
                Console.WriteLine();
            }

            Shape largestShape = shapes[0];
            double totalArea = 0;

            foreach (Shape shape in shapes)
            {
                totalArea += shape.CalculateArea();

                if (shape.CalculateArea() > largestShape.CalculateArea())
                {
                    largestShape = shape;
                }
            }

            Console.WriteLine($"Largest Shape: {largestShape.ShapeName()}");
            Console.WriteLine($"Largest Area: {largestShape.CalculateArea():F2}");

            Console.WriteLine($"Total Area: {totalArea:F2}");

            ColoredShape colored = new ColoredCircle("Red", 7);

            Console.WriteLine();
            colored.Display();



            Console.ReadKey();
        }
    }

}
