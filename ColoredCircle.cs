namespace Tak2_IEEE__Abstract_Class_And___Polymorphism_
{
    class ColoredCircle : ColoredShape
    {
        public double Radius { get; set; }

        public ColoredCircle(string color, double radius)
            : base(color)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ShapeName()
        {
            return $"{Color} Circle";
        }
    }

}
