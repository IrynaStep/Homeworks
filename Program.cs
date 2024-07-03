using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter first number
            Console.Write("Enter first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            // Enter operator
            Console.Write("Enter operator (+, -, *, /): ");
            char oper = Console.ReadLine()[0];

            // Enter second number
            Console.Write("Enter second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            // Result
            double result = 0;


            // Operation
            switch (oper)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                   result = number1 / number2;
                   break;
                default:
                    Console.WriteLine("Error: Wrong operator!");
                    break;
            }


            // Display the result
            Console.WriteLine("Result: " + result);


        }

    }
}
    
