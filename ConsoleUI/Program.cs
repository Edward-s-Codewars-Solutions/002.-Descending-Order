using System;

Console.WriteLine("KATA 002: Descending Order\n");

Console.Write("Give me some positive integer: ");
string inputAsString = Console.ReadLine();
int input;
bool parsingResult = int.TryParse(inputAsString, out input);

int output;

if (parsingResult == false)
{
    Console.WriteLine("Sorry, this does not look similar to positive integer.");
}
else
{
    try
    {
        output = Kata.DescendingOrder(input);
        Console.WriteLine($"Your number with digits sorted in descending order: { output }");
    }
    catch (Exception e)
    {
        Console.WriteLine($"Sorry, exception occured: { e.Message }");
    }
}

Console.Write("\nPress any key...");
Console.ReadKey();