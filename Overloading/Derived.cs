namespace OverrideOverload
{
    public class Derived : Base
    {

        public string derivedString;

        public Derived()
        {
            this.derivedString = "Derived";
        }

        // Method overriding is a technique that allows the invoking of functions from another class (base) in the derived class.
        // Creating a method in the derived class with the same name as the

        //<Access Modifier> <Modifier> <ReturnType> <MethodName(Parameters)>
        public override void newMethod() //"override" is required to extend or modify the virtual implementation of an inheritance method, property, indexer, or event.
        {
            Console.WriteLine("Running newMethod() from Derived class.");
        }
        /* All override members...
        - provide a new implementation of an inherited method
        - must have the same signature as the inherited method - public virtual void newMethod(); public override void newMethod()
        - Both methods must be 'virtual', 'abstract', or 'overide'
        - must not use the static or virtual modifiers to override a method */
    }
}