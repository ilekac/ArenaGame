namespace CEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point() { X = 10, Y = 20 };
            Point p2 = new Point() { X = 10, Y = 20 };
            Point p3 = p1;

            Console.WriteLine("Comparing points: ");
            Console.WriteLine($"p1 == p2: {p1 == p2}");
            Console.WriteLine($"p1 == p3: {p1 == p3}");
            Console.WriteLine($"p1 equals p2: {p1.Equals(p2)}");


            Console.ReadLine();
        }
    }
}
