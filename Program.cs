userGreeting();
bool userConsent = true;
double result;

while (userConsent)
{
    double firstInput = userFirstInput();
    double secondInput = userSecondInput();
    operationCalculation(firstInput, secondInput);
    userConsent = IsUserConsent();
}

void userGreeting()
{
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
}

double userFirstInput()
{
    double num1;
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

    return (double)num1;
}

double userSecondInput()
{
    double num2;
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

    return (double)num2;
}

void operationCalculation(double firstInput, double secondInput)
{

    string operation;
    while (true)
    {
        Console.WriteLine("Enter the operation to be performed (+, -, *, /): ");
        operation = Console.ReadLine();

        switch (operation)
        {
            case "+":
                Addition(firstInput, secondInput);
                break;

            case "-":
                Subtraction(firstInput, secondInput);
                break;

            case "*":
                Multiplication(firstInput, secondInput);
                break;

            case "/":
                Division(firstInput, secondInput);
                break;

            default:
                Console.WriteLine("Invalid operation. Please enter a valid operation.");
                continue;
        }
        break;
    }
}

bool IsUserConsent()
{
    char option;
    while (true)
    {
        Console.WriteLine("Do you want to continue. Press y to continue");
        if (!char.TryParse(Console.ReadLine(), out option))
        {
            Console.WriteLine("Invalid character. Please enter a valid character.");
        }
        else
        {
            break;
        }
    }

    if (option == 'y' || option == 'Y')
    {
        return true;
    }
    else
    {
        return false;
    }

}

void Addition(double firstInput, double secondInput)
{
    result = firstInput + secondInput;
    Console.WriteLine("The addition is: " + result);
}

void Subtraction(double firstInput, double secondInput)
{
    result = firstInput - secondInput;
    Console.WriteLine("The subtraction is: " + result);
}

void Multiplication(double firstInput, double secondInput)
{
    result = firstInput * secondInput;
    Console.WriteLine("The multiplication is: " + result);
}

void Division(double firstInput, double secondInput)
{
    while (true)
    {
        if (secondInput == 0)
        {
            Console.WriteLine("Cannot divide by zero. Please enter a non-zero second number:");
            if (!double.TryParse(Console.ReadLine(), out secondInput) || secondInput == 0)
            {
                Console.WriteLine("Invalid second number. Please enter a valid non-zero number.");
                continue;
            }
        }
        result = firstInput / secondInput;
        Console.WriteLine("The division is: " + result);
        break;
    }
}





