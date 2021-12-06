namespace SampleNamespace //Everything below namespace is in curly braces
{
    public class Customer : Person
    {
        public double CashOnHand {get; set;} = 0;

        //Constructor
        public Customer( int CashOnHand, string firstName, string lastName) : base(firstName, lastName)
        {
            this.CashOnHand = CashOnHand;
        } 
    }
}