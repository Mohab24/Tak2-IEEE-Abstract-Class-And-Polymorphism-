namespace Tak2_IEEE__Abstract_Class_And___Polymorphism_
{
    abstract class Shape
    {
        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public virtual string ShapeName()
        {
            return GetType().Name;
        }

        public void Display()
        {
            Console.WriteLine($"\nShape: {ShapeName()}");
            Console.WriteLine($"Area: {CalculateArea():F2}");
            Console.WriteLine($"Perimeter: {CalculatePerimeter():F2}");
        }
    }

}
