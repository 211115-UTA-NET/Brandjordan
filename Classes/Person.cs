public class Person
    {
        string firstName;//private by default; make public to access
        string lastName;

        //Constructor
        public Person()
        {
            firstName = "John";
            lastName = "Doe";
        }
        public Person( string first, string last )//Named after class; No return type
        {
            firstName = first;
            lastName = last;
        }

        public void setFirstName(string name)
        {
            firstName = name;
        }

        public string getFirstName()
        {
            return firstName;
        }

        //accessModifier returnType methodName
        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {firstName} {lastName}");
        }

    }