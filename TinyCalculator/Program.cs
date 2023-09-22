Console.WriteLine("== Tiny calculator ==");

Console.Write("Dividend: ");
if (!int.TryParse(Console.ReadLine(), out int dividend))
{
    Console.WriteLine("Not a number. Bye.");
    return;
}

Console.Write("Divisor: ");
if (!int.TryParse(Console.ReadLine(), out int divisor))
{
    Console.WriteLine("Not a number. Bye.");
    return;
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{dividend} / {divisor} = {dividend / divisor}");
Console.ResetColor();
