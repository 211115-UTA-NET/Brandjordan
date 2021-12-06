namespace OverrideOverload
{

    public class Base
    {
        public string baseString;

        //Constructor w/no parameters
        public Base()
        {
            this.baseString = "Base";
        }
        public Base(string baseString)
        {
            this.baseString = baseString;
        }
            // Overloading is creating multiple versions of a method or constructor that accepts different parameters and accomplish same task

        public void speak()
        {
            Console.WriteLine("Hello, I am a Base class object.");
        }
        public void speak (string type)
        {
            Console.WriteLine($"Hello, I am a {type} object."); //^^Speak method has ben overloaded
        }
        /* public void speak (string type, int nmber, int otherNumber)
        {
            Console.WriteLine($"Hello, I am a {type} object.{number} "); 
        }*/

        //Ex - public void speak(string type, int number)

        /*Use descriptive names for the methods, but the methods to be overloaded MUST have the same name.
        Use descriptive names for the parameters. Use the same name for the same parameter for each instance
        or avoid using a different name. We need to send parameters in a consistent method. It's okay to skip parameters 
        but not swap them around. Don't have overloads w/parameters at the same position ans similiar type, yet with different semantics*/

        //<Access Modifier> <Modifier> <ReturnType> <MethodName(Parameters)>
        public virtual void newMethod() //the "virtual" keyword is used o ID a method to allow it to be overriden later
        {
            Console.WriteLine("Running newMethod() from Derived class.");
        }
    }
}