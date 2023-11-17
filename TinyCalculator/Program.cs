
using System;

        Console.WriteLine("== Tiny calculator ==");


        while (true)
        {
            double firstNumber = ReadNumber("Erste Nummer");
            double secondNumber = ReadNumber("Zweite Nummer");

            if (secondNumber == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Divisor darf nicht 0 sein.");
                Console.ResetColor();
                secondNumber = ReadNumber("Divisor");
            }
            else
            {
                char op = ChooseOperator();

                switch (op)
                {
                    case '+':
                        //secondNumber = ReadNumber("Summand");
                        firstNumber = firstNumber + secondNumber;
                        break;
                    case '-':
                        //secondNumber = ReadNumber("Subtrahend");
                        firstNumber = firstNumber - secondNumber;
                        break;
                    case '*':
                        //secondNumber = ReadNumber("Multiplikand");
                        firstNumber = firstNumber * secondNumber;
                        break;
                    case '/':
                        //secondNumber = ReadNumber("Divisor");
                        if (secondNumber == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Divisor darf nicht 0 sein.");
                            Console.ResetColor();
                            continue; // Skip the current iteration and ask for input again
                        }
                        firstNumber = firstNumber / secondNumber;
                        break;
                    default:
                        Console.WriteLine("Invalid operator. Please choose again.");
                        continue; // Skip the current iteration and ask for input again
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Result: {firstNumber.ToString("F")}");
                Console.ResetColor();

                Console.Write("Do you want to continue? (y/n): ");
                string continueInput = Console.ReadLine();
                if (continueInput.ToLower() != "y")
                    break;
            }
        }

    static char ChooseOperator()
    {
        while (true)
        {
            Console.Write($"Choose an operator [+ - * /]: ");
            string operand = Console.ReadLine();
            if (operand.Length == 1 && "+-*/".Contains(operand))
            {
                return operand[0];
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{operand} is not a valid operator [+ - * /].");
            Console.ResetColor();
        }
    }

    static double ReadNumber(string name)
    {
        while (true)
        {
            Console.Write($"{name}: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double number))
            {
                return number;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{input} is not a number.");
            Console.ResetColor();
        }
    }
