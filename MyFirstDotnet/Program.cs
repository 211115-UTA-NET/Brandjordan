// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! I love you!");

//Casting - changes the variable type not the value
Console.WriteLine("###### Casting Example ######");

string start = "Begin"
object z = start;
string end = (string)z;

Console.WriteLine("starting string: " + start);
Console.WriteLine("ending string: " + end);



//Conversion - value may change the value stored
//Console.WriteLine("###### Conversion Example ######");
//int a =7;
//byte b = (byte)a; //change int a into a byte
//Console.WriteLine("The value of  is: " + a);


//Parsing - reads a string as a numerical value
//bool myBool;
//int paresedString;
//string newString = "578";
//myBool - int.TryParse(newString, out parsedString);
//Console.WriteLine("String could be parsed: " + myBool);

//if (myBool == true)
//{
//parsedString = int.Parse(newString);
//Console.WriteLine("The value of parsedString is: " + parsedString);
//}
//else
//{
//    Console.WriteLine("The value of newString could not be parsed");
//}
//fi

int test = 4;

//Console.WriteLine("[1] - condition 1");
//Console.WriteLine("[2] - condition 2");
//Console.WriteLine("[3] - condition 3");
//Console.WriteLine("[4] - condition 4");
Console.WriteLine("Please input a value");

test = int.Parse(Console.ReadLine()); //accept input from user

switch (test)
{
    case 1:
        Console.WriteLine("Condition 1");
    break;

    case 2:
        Console.WriteLine("Condition 2");
    break;

    case 3:
        Console.WriteLine("Condition 3");
    break;

    case 4:
        Console.WriteLine("Condition 4");
    break;

    default:
        Console.WriteLine("Not a valid condition");
    break;

}


Console.WriteLine("######### WHILE #########");

bool newTest = true; //?change to false

Console.WriteLine("this happens before the loop");

while (newTest == true)
{
  //  Console.WriteLine("your test was true") //what prints when executed. will run forever. needs a trigger to stop
  //  newTest = false; //^will stop now because it texted false the second time
}
Console.WriteLine("this happens after the loop");

Console.WriteLine("###### Do While Loop ######");

//int j = 0;

//do
//{
//    Console.WriteLine(j);
//    Console.WriteLine("your do while loop is running");
//    j++;
//}
//while(j<5);  do-while loops happens atleat once

int j = 0;

while(j<)
{
    Console.WriteLine(j);
    j++;
}
