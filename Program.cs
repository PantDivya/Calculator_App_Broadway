DateTime date = DateTime.Now.Date;

var operations = new Dictionary<string, Func<double, double, double>>
{
    ["+"] = (a, b) => a + b,
    ["-"] = (a, b) => a - b,
    ["*"] = (a, b) => a * b,
    ["/"] = (a, b) => a / b,
    ["^"] = (a, b) => Math.Pow(a, b),
    ["%"] = (a, b) => a % b
};

Console.WriteLine($"Welcone to the Calculator App.Today is {date}");

while (true)
{
    Console.WriteLine($"\nEnter the operator ({string.Join(",", operations.Keys)}) or 'e' to exit:");
    string op = Console.ReadLine();

    if (op == "e" || op == "E")
    {
        Console.WriteLine("Exiting the calculator.");
        break;
    }

    if (!operations.ContainsKey(op))
    {
        Console.WriteLine("Invalid operator.");
        continue;
    }

    Console.WriteLine("Enter the first number:");
    if (!double.TryParse(Console.ReadLine(), out double num1))
    {
        Console.WriteLine("Invalid input. Please enter a numeric value.");
        continue;
    }

    Console.WriteLine("Enter the second number:");
    if (!double.TryParse(Console.ReadLine(), out double num2))
    {
        Console.WriteLine("Invalid input. Please enter a numeric value.");
        continue;
    }

    // Retrieve and invoke the operation
    var operation = operations[op];
    double result = operation(num1, num2);

    // Handle division by zero gracefully
    if (double.IsNaN(result))
    {
        Console.WriteLine("Cannot divide by zero.");
    }
    else
    {
        Console.WriteLine($"Result: {result}");
    }

    Console.WriteLine("Press any key to continue or 'e' to exit.");
    var key = Console.ReadKey().KeyChar;
    if (key == 'e' || key == 'E')
    {
        Console.WriteLine("\nExiting the calculator.");
        break;
    }
}



Console.ReadKey();

