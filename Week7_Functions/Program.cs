
Console.WriteLine("Are you coming or leaving? (in/out)");
string userCoise = Console.ReadLine();

if (userCoise == "in")
{
    PrintHello();
}
else if (userCoise == "out")
{
    PrintGoodbye();
}
else 
{
    Console.WriteLine("You are wrong way!");
}




//PrintHello();
//PrintGoodbye();


static void PrintHello()     // funktsioon e.meetod
{ 
Console.WriteLine("Hello, world!");
}


static void PrintGoodbye()
{
    Console.WriteLine("See you later!");
}