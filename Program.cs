// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Broadway Calculator");

// Get the current time
DateTime currentTime = DateTime.Now;

// Display a greeting message based on the time of the day
if (currentTime.Hour >= 5 && currentTime.Hour < 12)
{
    Console.WriteLine("Good Morning!");
}
else if (currentTime.Hour >= 12 && currentTime.Hour < 18)
{
    Console.WriteLine("Good Afternoon!");
}
else
{
    Console.WriteLine("Good Evening!");
}

bool varCon = true;
double firstNumber, SecondNumber, result;
int option;
while (varCon)
{
    Console.WriteLine("Chose any of the operation:");
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Multiply");
    Console.WriteLine("4. Divide");
    Console.WriteLine("5. Exit");
    option = int.Parse(Console.ReadLine());
    if (option == 5)
        break;

    Console.WriteLine("Enter First Number");
    firstNumber = double.Parse(Console.ReadLine());

    Console.WriteLine("Enter Second Number");
    SecondNumber = double.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
                result = firstNumber + SecondNumber;
            Console.WriteLine("Sum : "+result);
            break;
         case 2:
            result = firstNumber - SecondNumber;
            Console.WriteLine("Subtract : " + result);
            break;
        case 3:
            result = firstNumber * SecondNumber;
            Console.WriteLine("Multiply : " + result);
            break;
        case 4:
            result = firstNumber / SecondNumber;
            Console.WriteLine("Divide : " + result);
            break;
        default:
            Console.WriteLine("Invalid selection:");
            break;

    }


}

