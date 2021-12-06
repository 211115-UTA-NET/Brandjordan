
//Namespace
namespace SampleNamespace //Everything below namespace is in curly braces; Associate multiple classes into one project
{
    public class Emploees : Person
    {
        private int HoursWorked; //public in class example vv
        private double PayRate; //public before ^^

        /*Constructor with defaults
        public Emploee()
        {
            HoursWorked = 20;
            PayRate = 10.00;
        } */

        //Constructor(s) Start here vv declared and used parameters from 'Employee' class; Now use parameters from 'Person' class (string firstName and string lastName)
        public Emploees(int HoursWorked, double PayRate, string firstName, string lastName) : base(firstName, lastName)
        {
            this.HoursWorked = 20; //'Empoyee' class deals with parameters for Employess; 'Person' class deals w/first&lastName
            this.PayRate = 18.50; //'this' keyword refers to the class it's in if there are variables w/same name; w/o it error will occur because compiler wouldn't know which to pull from HoursWorked = HoursWorked
        } 

        //Constructor
        /*public Emploees(int HoursWorked, double PayRate, string firstName, string lastName) : base(firstName, lastName)
        {
            this.HoursWorked = HoursWorked;//By using 'this' we are referring to the field that we're in
            this.PayRate = PayRate;
        } */
        
        public void doWork()//name of method
        {           
            Console.WriteLine($"I've worked {HoursWorked} hours.");
        }     

        public void earnWork()
        {
            Console.WriteLine($"I've earned ${PayRate * HoursWorked} per week before taxes.");
        }

        public int getHoursWorked()
        {
            return HoursWorked;
        }

        public double getPayRate()
        {
            return PayRate;
        }

        public void setHoursWorked(int HoursWorked)
        {
            this.HoursWorked = HoursWorked;
        }

        public void setPayRate(double PayRate)
        {
            this.PayRate = PayRate;
        }

        public changeName(string first, string last)
        {
            // Call the function from base class (Person class)
            setFirstName(first);
            setLastName(last);
        } //End function
    } //End Emploees : Person
}