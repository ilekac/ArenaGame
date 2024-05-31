namespace BOverridingToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point()
            {
                X = 10,
                Y = 20
            };
            Point p2 = new Point()
            {
                X = 30,
                Y = 5
            };

            //...
            Console.WriteLine($"p1: {p1}");
            Console.WriteLine($"p2: {p2}");
            Console.ReadLine();
        }
    }
}
