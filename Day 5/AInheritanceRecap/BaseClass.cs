using System.Runtime.InteropServices.Marshalling;

namespace AInheritanceRecap
{
    class BaseClass  
    {
        public void M1() { Console.WriteLine("BaseClass.M1"); }
        public virtual void MVirt() { Console.WriteLine("BaseClass.MVirt"); }
    }

    class DerivedClass : BaseClass
    {
        public void M1() { Console.WriteLine("DerivedClass.M1"); }
        public void M2() { Console.WriteLine("Derived.M2"); }
        public override void MVirt() { Console.WriteLine("DerivedClass.MVirt"); }
    }
}
