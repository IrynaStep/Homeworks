class Program
{
static void Main()
{
        // 1. Get the first number
Console.WriteLine("Enter 1st number: ");
var first = Console.ReadLine();
decimal.TryParse(first, out var firstArg);

        // 2. Enter operator
Console.Write("Enter operator (+, -, *, /): ");
var oper = Console.ReadLine();


        // 3. Get the second number
Console.WriteLine("Enter 2nd number: ");
var second = Console.ReadLine();
decimal.TryParse(second, out var secondArg);

        // 4. Display the result
 decimal result = 0;
 

        switch (oper)
        {
            case "1":
                result = firstArg + secondArg;
                break;

            case "2":
                result = firstArg - secondArg;
                break;

            case "3":
                result = firstArg * secondArg;
                break;

            case "4":
                result = firstArg / secondArg;
                break;

            default:
                Console.WriteLine("There is no operator like this");
                break;

        }
        Console.WriteLine("Result: " + result);

        // Exit the app
        Console.WriteLine("Press any key to exit");
 Console.ReadKey();

    }
}

