// See https://aka.ms/new-console-template for more information
using System.IO; 
using System; //allows us to read and write to a file

string path = "./testFile.txt";

//write multiple lines at once
string[] text = {"hi", "hello", "How's it going" };

File.AppendAllLines(path, text); //AppendAllLines appends text to a file

/*StreamWriter writer = new StreamWriter(path); //whatever at this location, open
writer.WriteLine("This is a new line. ");
writer.Close(); //closes the file */

//StreamReader reader = new StreamReader(path); //create reader and open file

/*try
{
    do //|| replace "do" with "while"
    {
        Console.WriteLine(reader.ReadLine());
    }
    while(reader.Peek()) != -1;
}
catch
{
    Console.WriteLine("End of file reached");
}
finally
{
    reader.Close();
}*/

//Console.WriteLine(reader.ReadLine());//tell reader to read line
//reader.Close();

// ./-current directory
// ..-parent directory