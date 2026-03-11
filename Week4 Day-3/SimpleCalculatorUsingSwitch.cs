using System;

namespace MyProjects
{
    internal class SimpleCalculatorUsingSwitch
    {
        static void Main()
        {
            Console.WriteLine("Enter First Number");
            var num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            var num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Operator");
            var op=Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine($"Addition of two numbers is: {num1 + num2}");
                    break;
                case '-':
                    Console.WriteLine($"Subtraction of two numbers is: {num1 - num2}");
                    break;
                case '*':
                    Console.WriteLine($"Multiplication of two numbers is: {num1 * num2}");
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Division of two numbers is: {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }


        }
    }
}
