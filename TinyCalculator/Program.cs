﻿Console.WriteLine("== Tiny calculator ==");

int dividend = ReadNumber("Dividend");
int divisor = ReadNumber("Divisor");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{dividend} / {divisor} = {dividend / divisor}");
Console.ResetColor();

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