class Program
{
static void Main()
{
        // 1. Get the first number
Console.WriteLine("Enter 1st number: ");
var first = Console.ReadLine();

        // 2. Enter operator
Console.Write("Enter operator (+, -, *, /): ");
var oper = Console.ReadLine();


        // 3. Get the second number
Console.WriteLine("Enter 2nd number: ");
var second = Console.ReadLine();


        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine(first + second);
                break;

            case "2":
                Console.WriteLine(first - second);
                break;

            case "3":
                Console.WriteLine(first * second);
                break;

            case "4":
                Console.WriteLine(first / second);
                break;

            default:
                Console.WriteLine("There is no operator like this");
                break;

        }

        // 4. Display the result
 double result = 0;
 Console.WriteLine("Result: " + result);

        // Exit the app
 Console.WriteLine("Press any key to exit");
 Console.ReadKey();

    }
}
    
