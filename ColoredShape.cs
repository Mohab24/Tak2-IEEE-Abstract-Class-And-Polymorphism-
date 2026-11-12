namespace Tak2_IEEE__Abstract_Class_And___Polymorphism_
{
    abstract class ColoredShape : Shape
    {
        public string Color { get; set; }

        public ColoredShape(string color)
        {
            Color = color;
        }
    }

}
