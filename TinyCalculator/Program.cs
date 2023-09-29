Console.WriteLine("== Tiny calculator ==");

int dividend;
while (true)
{
    Console.Write("Dividend: ");
    string input = Console.ReadLine();
    if (int.TryParse(input, out dividend))
    {
        break;
    }
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{input} is not a number.");
    Console.ResetColor();
}

int divisor;
while (true)
{
    Console.Write("Divisor: ");
    string input = Console.ReadLine();
    if (int.TryParse(input, out divisor))
    {
        break;
    }
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{input} is not a number.");
    Console.ResetColor();
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{dividend} / {divisor} = {dividend / divisor}");
Console.ResetColor();
