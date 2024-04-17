// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to MyCalculator App");
Console.WriteLine("Please provide any operation");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");

#region performOperation

int operation = int.Parse(Console.ReadLine());
int result;

Console.WriteLine("Provide first input:");
int first = int.Parse(Console.ReadLine());


Console.WriteLine("Provide Second input:");
int second = int.Parse(Console.ReadLine());

if (operation == 1)
{
    result = first + second;
    Console.WriteLine($"Sum : " + result);
}
else if (operation == 2)
{
    result = first - second;
    Console.WriteLine($"Difference : " + result);
}
else if (operation == 3)
{
    result = first * second;
    Console.WriteLine($"Product : " + result);
}
else if (operation == 4)
{
    result = first / second;
    Console.WriteLine($"division : " + result);
}
else
{
    Console.WriteLine("Invalid Selection");
}

#endregion
