﻿using System.Xml.Linq;

Console.WriteLine("== Tiny calculator ==");


int firstNumber = 0;
int secondNumber = 0;
int result = 0;

char op = ChooseOperator();

switch (op)
{
    case '+':
        firstNumber = ReadNumber("Summand");
        secondNumber = ReadNumber("Summand");
        result = firstNumber + secondNumber;
        break;
    case '-':
        firstNumber = ReadNumber("Minuend");
        secondNumber = ReadNumber("Subtrahend");
        result = firstNumber - secondNumber;
        break;
    case '/':
        firstNumber = ReadNumber("Multiplikator");
        secondNumber = ReadNumber("Multiplikand");
        result = firstNumber * secondNumber;
        break;
    case '*':
        firstNumber = ReadNumber("Dividend");
        secondNumber = ReadNumber("Divisor");
        result = firstNumber / secondNumber;
        break;
}

if (secondNumber == 0 && op == '/')
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Divisor darf nicht 0 sein.");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{firstNumber} {op} {secondNumber} = {result}");
    Console.ResetColor();
}

static char ChooseOperator()
{
    while (true)
    {
        Console.Write($"Choose an operator[+, -, *, /]: ");
        string operand = Console.ReadLine();
        if (operand == "+" || operand == "-" || operand == "*" || operand == "/")
        {
            return char.Parse(operand);
        }
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{operand} is not a operator [+, -, *, /].");
        Console.ResetColor();
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






