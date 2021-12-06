using System;

namespace _3_DataTypeAndVariablesChallenge
{
    public class Program
    {
      public static void Main(string[] args)
      {

          byte myByte = 25; //declaration and initialization
          sbyte mySbyte = -50; //declaration and initialization
          int myInt = 2500; //declaration and initialization
          uint myUint = -2500; //declaration and initialization
          short myShort = -5000; //declaration and initialization
          ushort myUshort = 5000; //declaration and initialization
          float myFloat = 3.25; //declaration and initialization
          double myDouble = -1.50; //declaration and initialization
          char myChar = 'a'; //declaration and initialization
          bool myBool = true; //declaration and initialization
          string myString = "I control text"; //declaration and initialization
          string myStringNum = "8891"; //declaration and initialization
          decimal numDecimal = 5.25; //declaration and initialization

	Console.WriteLN(myByte); //displays information


      }

      public static int myString(string myString, out int result);
      
      {
        throw new NotImplementedException();
      }
    }
}
var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

fibonacciNumbers.Add(previous + previous2);

foreach(var item in fibonacciNumbers)
    Console.WriteLine(item);