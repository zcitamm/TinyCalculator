Console.WriteLine("== Tiny calculator ==");

Console.Write("Dividend: ");
int dividend = int.Parse(Console.ReadLine());

Console.Write("Divisor: ");
int divisor = int.Parse(Console.ReadLine());

if (divisor == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Divisor darf nicht 0 sein.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{dividend} / {divisor} = {dividend / divisor}");
    Console.ResetColor();
}