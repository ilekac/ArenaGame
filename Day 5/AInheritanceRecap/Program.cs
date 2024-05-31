namespace AInheritanceRecap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass objBase = new BaseClass();
            DerivedClass objDerived = new DerivedClass();
            BaseClass obj3 = new DerivedClass();
            //DerivedClass obj4 = new BaseClass(); //Doesn't compile. Base classes are not of the same type as their children

            Console.WriteLine("Non-virtual methods:");
            objBase.M1();
            objDerived.M1();
            obj3.M1();
            Console.WriteLine();

            Console.WriteLine("Virtual methods:");
            objBase.MVirt();
            objDerived.MVirt();
            obj3.MVirt();


        }
    }
}
