Console.WriteLine("== Tiny calculator ==");

Console.Write("Dividend: ");
int dividend = int.Parse(Console.ReadLine());

Console.Write("Divisor: ");
int divisor = int.Parse(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{dividend} / {divisor} = {dividend / divisor}");
Console.ResetColor();
