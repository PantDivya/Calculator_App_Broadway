using Calculator_App_Broadway;
using System;

userGreeting();
bool userConsent = true;


Addition addition = new Addition();
Subtraction subtract = new Subtraction();
Multiplication multiplication = new Multiplication();
Division division = new Division();
MultiplicationTable table = new MultiplicationTable();
Factorial fact = new Factorial();
Mean mean = new Mean();


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

int[] GetUserInput()
{
    double num;
    Console.WriteLine("Enter the number of inputs:");

    while (!double.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }

    int[] userInput = new int[(int)num]; 
    for (int i = 0; i < num; i++) 
    {
        Console.WriteLine("Enter the " + (i + 1) + " element:");
        int input;

        while (!int.TryParse(Console.ReadLine(), out input)) 
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }

        userInput[i] = input;
    }

    return userInput;
}

void operationCalculation()
{

    string operation;
    while (true)
    {
        Console.WriteLine("Enter the operation to be performed 1. Addition: ");
        Console.WriteLine("Enter the operation to be performed 2. Subtraction: ");
        Console.WriteLine("Enter the operation to be performed 3. Multiplication: ");
        Console.WriteLine("Enter the operation to be performed 4. Division: ");
        Console.WriteLine("Enter the operation to be performed 5. MultiplicationTable: ");
        Console.WriteLine("Enter the operation to be performed 6. Factorial: ");
        Console.WriteLine("Enter the operation to be performed 7. ArithmeticMean: ");

        operation = Console.ReadLine();

        switch (operation)
        {
            case "1":
                int[] addInputs = GetUserInput();
                addition.Add(addInputs);
                break;

            case "2":
                int[] subtractInputs = GetUserInput();
                subtract.Subtract(subtractInputs);
                break;

            case "3":
                int[] multiplyInputs = GetUserInput();
                multiplication.Multiply(multiplyInputs);
                break;

            case "4":
                int[] divideInputs = GetUserInput();
                division.Divide(divideInputs);
                break;

            case "5":
                table.multiplicationTable();
                break;

            case "6":
                fact.factorial();
                break;

            case "7":
                int[] meanInputs = GetUserInput();
                mean.arithmeticMean(meanInputs);
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




