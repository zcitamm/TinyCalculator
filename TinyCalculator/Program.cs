using System.Xml.Linq;

Console.WriteLine("== Tiny calculator ==");

int dividend = ReadNumber("Dividend");
int divisor = ReadNumber("Divisor");

while (true)
{
    if (divisor == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Divisor darf nicht 0 sein.");
        Console.ResetColor();
        divisor = ReadNumber("Divisor");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{dividend} / {divisor} = {dividend / divisor}");
        Console.ResetColor();
        dividend = dividend / divisor;
        Console.WriteLine($"Dividend: {dividend}");
        divisor = ReadNumber("Divisor");
    }
}


static int ReadNumber(string name)
{
    while (true)
    {
        Console.Write($"{name}: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int dividend))
        {
            return dividend;
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{input} is not a number.");
        Console.ResetColor();
    }
}