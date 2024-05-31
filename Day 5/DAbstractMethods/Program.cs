namespace DAbstractMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
                new Circle() { Radius = 10 },
                new Circle() { Radius = 8 },
                new Square() { Size = 12 },
                // new Shape(), //Cannot instantiate abstract classes
            };


        }
    }
}
