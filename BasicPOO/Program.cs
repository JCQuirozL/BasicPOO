
using BasicPOO;

Console.WriteLine("**************");
Console.WriteLine("* POO Basics *");
Console.WriteLine("**************");

try
{
    Console.WriteLine(new Date(2022,2,29).ToString());
}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}



