// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static void Main()
{
    int newInt = 8;

    int[] intArray = new int[{3,4,5}];
    int[] secondIntArray = new int[5]

    int[] arrayone = new int[]{3,4,5}
    int[] arraytwo = {1,2,3}


    Console.WriteLine("newInt = " + newInt );
    Console.WriteLine("intArray = " + intArray[] ); //specify which element of index to return

    //Console.WriteLine("arrayone = " + arrayone[1]);
    //Console.WriteLine("arraytwo = " + arraytwo[1]);

    Console.WriteLine("printing arrayone");
    Console.WriteLine("printing arraytwo");

    PrintArray(arrayone);
    PrintArray(arraytwo);

}
static void PrintArray( int[] Array)
{
    for(int i = 0; i < Array.Length; i++)
    {
        Console.WriteLine(Array[i]);
    }
}