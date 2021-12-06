// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*-Parameters (Value, Reference, Output, Parameter Array)
Parameters can pass information to methods and they act like variables inside the method.
They are specified in parentheses '()' after the method name. There is no limit to the 
paramters needed, just seerate each with a comma ','.
    
Example: <accessMod> <returnType> <MethodName> <(parameters[takes a string called blue])>*/
static void WhyMethods(string firstName)//<still a parameter until called
{
    Console.WriteLine(firstName + "Rocks!");//<Output. Use System.Cnsole.WriteLine() prints string & moves to \n || System.Write() only prints string provided
}
//static void Main(string[] args)
{
    WhyMethods("Everyone "); //When a parameter is passed to the method, it is called an argument.
    WhyMethods("Everyone loves ");
    WhyMethods("I love ");

//Arrays store multiple values in a single variable. 
/* #3 string[] alphabet = {"Alpha", "Bravo", "Charlie", "Delta"}; //Declaring an array, define variable type w/square brackets; Declaring values that holds an array of a certain data type, use curly braces '{}' place values inside seperated by commas
    Console.WriteLine(alphabet[3]); //Arrays are zero indexed

int[] numbers = {10, 20, 40, 70};
    Console.WriteLine(numbers[1]); end #3*/
} 
//Parameter Values #2
/* #2 static void WhyMethods(string firstName = "Jordan") //Jordan is a default paramter value assigned by the equals sign '='. If a method is called w/o, it'll us the dafault value "Jordan"
{
    Console.WriteLine(firstName);//<firstName is an optional parameter while "Jordan" is the default value. w/o any parameters, an error will occur when ran
}
//static void Main(string[] args)
{
    WhyMethods();
    WhyMethods("Isa");
    WhyMethods("King");
} end #2 */ 

//-Interfaces, and their relationship to classes 12.3.21 topics 
//-Type Parameters, and generic class type.
//-Heap and stack memory for garbage collection