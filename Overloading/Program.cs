using System;

namespace OverrideOverload
{

    class Program
    {
        public static void Main()
        {
            Base MyBase = new Base();
            Derived MyDerived = new Derived();

            /*Console.WriteLine(MyBase.baseString);
            Console.WriteLine(MyDerived.derivedString);

            Console.WriteLine(MyDerived.baseString);*/

           // MyBase.speak();
           // MyBase.speak("I'm different");

           Base thing;

           thing = new Base();
           thing.newMethod();

           thing = new Derived();
           thing.newMethod();

           MyDerived.newMethod();
        }
    }
}