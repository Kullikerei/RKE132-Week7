
Console.WriteLine("Enter something:");
string userInput = Console.ReadLine();

PrintAnyWord(userInput); //userInput -- argument

static void PrintAnyWord(string anyString) //anyString -- parameter
{
    anyString = anyString.ToUpper();
    for(int i = 0; i <5; i++)
    {
        Console.WriteLine(anyString);
    }
}