


Console.WriteLine("Enter a word:");
string UserInput = Console.ReadLine();

PrintAnyWord(UserInput);                        // UserInput - argument

static void PrintAnyWord(string anyString)      //anyString - parameter
{
    anyString = anyString.ToUpper();

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(anyString);
    }
}

