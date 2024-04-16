using Calculator_App_Broadway;

userGreeting();
bool userConsent = true;
double firstInput;
double secondInput;



Addition addition = new Addition();
Subtraction subtract = new Subtraction();
Multiplication multiplication = new Multiplication();
Division division = new Division();
MultiplicationTable table = new MultiplicationTable();
Factorial fact = new Factorial();


while (userConsent)
{   
    operationCalculation();
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
    Console.WriteLine("Enter the first number:");
    while (!double.TryParse(Console.ReadLine(), out num1))
    {
        Console.WriteLine("Invalid first number. Please enter a valid number.");
    }
    return (double)num1;

}

double userSecondInput()
{
    double num2;
    Console.WriteLine("Enter the second number:");
    while (!double.TryParse(Console.ReadLine(), out num2))
    {
        Console.WriteLine("Invalid second number. Please enter a valid number.");
    }
    return (double)num2;
}

void operationCalculation()
{

    string operation;
    while (true)
    {
        Console.WriteLine("Enter the operation to be performed (+, -, *, /, %,!): ");
        operation = Console.ReadLine();

        switch (operation)
        {
            case "+":
                firstInput = userFirstInput();
                secondInput = userSecondInput();
                addition.Add(firstInput, secondInput);
                break;

            case "-":
                firstInput = userFirstInput();
                secondInput = userSecondInput();
                subtract.Subtract(firstInput, secondInput);
                break;

            case "*":
                firstInput = userFirstInput();
                secondInput = userSecondInput();
                multiplication.Multiply(firstInput, secondInput);
                break;

            case "/":
                firstInput = userFirstInput();
                secondInput = userSecondInput();
                division.Divide(firstInput, secondInput);
                break;

            case "%":
                table.multiplicationTable();
                break;

            case "!":
                fact.factorial();
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
    Console.WriteLine("Do you want to continue. Press y to continue");
    while (!char.TryParse(Console.ReadLine(), out option))
    {
        Console.WriteLine("Invalid character. Please enter a valid character.");
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




