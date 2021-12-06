namespace SampleNamespace //Everything below namespace is in curly braces
{

    public class Trainee : Emploees
    {
        bool inTraining = true;
        
        public Trainee()
        {
            this.inTraining = true;
        }

        public bool getInTraining()
        {
            return this.inTraining;
        }

    }
}