// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Welcome to Broadway Calculator");

//Console.WriteLine("Please provide the first input");
//int firstInput=int.Parse(Console.ReadLine());


//Console.WriteLine("Please provide the second  input");

//int secondInput=int.Parse(Console.ReadLine());

//int sum=firstInput+secondInput;
//string Interpolation
//Console.WriteLine($"The result is : {sum}");


double num1, num2, result;
string operation;

DateTime currentTime = DateTime.Now;

int currentHour = currentTime.Hour;

if (currentHour >= 0 && currentHour < 7)
{
    Console.WriteLine("Good morning");
}

else if (currentHour >= 7 && currentHour < 19)
{
    Console.WriteLine("Good afternoon");
}

else if (currentHour >= 19 && currentHour <= 23)
{
    Console.WriteLine("Good evening");
}

while (true)
{
    Console.WriteLine("Enter the first number:");
    if (!double.TryParse(Console.ReadLine(), out num1))
    {
        Console.WriteLine("Invalid first number. Please enter a valid number.");
    }
    else
    {
        break;
    }
}

while (true)
{
    Console.WriteLine("Enter the second number:");
    if (!double.TryParse(Console.ReadLine(), out num2))
    {
        Console.WriteLine("Invalid second number. Please enter a valid number.");
    }
    else
    {
        break;
    }
}

while (true)
{
    Console.WriteLine("Enter the operation to be performed (+, -, *, /): ");
    operation = Console.ReadLine();

    switch (operation)
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine("The addition is: " + result);
            break;

        case "-":
            result = num1 - num2;
            Console.WriteLine("The subtraction is: " + result);
            break;

        case "*":
            result = num1 * num2;
            Console.WriteLine("The multiplication is: " + result);
            break;

        case "/":
            while (true)
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero. Please enter a non-zero second number:");
                    if (!double.TryParse(Console.ReadLine(), out num2) || num2 == 0)
                    {
                        Console.WriteLine("Invalid second number. Please enter a valid non-zero number.");
                        continue;
                    }
                }
                result = num1 / num2;
                Console.WriteLine("The division is: " + result);
                break;
            }
            break;

        default:
            Console.WriteLine("Invalid operation. Please enter a valid operation.");
            continue;
    }

    break;
}


