using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
internal class Calculator
{
    static void Main(string[] args)
  
    {
        double num1, num2, result=0; string op;

        Console.WriteLine("Simple Calculator in C#");
        ConsoleKey key;
        do
        {
            Console.WriteLine("-----------------------");

            Console.Write("Enter first number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+,-,*,/) :");
            op = Convert.ToString(Console.ReadLine());

            Console.Write("Enter second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)

                        result = num1 / num2;
                    else

                        Console.WriteLine("Error: Division by zero!");
                    break;
                default:
                    Console.WriteLine("Invalid operator!");
                    break;
            }

            Console.WriteLine($"Result: {result}");
            Console.WriteLine("Press any key to continue; Q to quit");
            key = Console.ReadKey(true).Key;
        } while (key != ConsoleKey.Q);
    }  
}