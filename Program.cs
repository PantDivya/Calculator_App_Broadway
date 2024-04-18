// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to MyCalculator App");

#region performOperation
int result;

bool userOperation = true;
while (userOperation) 
{
    DisplayMessage();
    //method call for user input for selecting operation 
    int userOption = ReadUserInputOperation();
    //condition for exit
    if (userOption == 6)
    {
        break;
    }

    //method call for arry input value
    int[] UserInput = ReadUserInput();
    //print n number of input
    for(int i = 0; i < UserInput.Length; i++)
    {
        Console.WriteLine(UserInput[i]);
    }

    //Two level of input 
    /*Console.WriteLine("Provide first input:");
    int first = int.Parse(Console.ReadLine());


    Console.WriteLine("Provide Second input:");
    int second = int.Parse(Console.ReadLine());*/

    //method call for calculation 
    /* CalculateOperation(userOption, first, second);*/

}

#endregion



#region Methods
void CalculateOperation(int userOption, int first, int second)
{
    if (userOption == 1)
    {
        result = first + second;
        Console.WriteLine($"Sum : {result} ");
    }
    else if (userOption == 2)
    {
        result = first - second;
        Console.WriteLine($"Difference : {result} ");
    }
    else if (userOption == 3)
    {
        result = first * second;
        Console.WriteLine($"Product : {result} ");
    }
    else if (userOption == 4)
    {
        result = first / second;
        Console.WriteLine($"division : {result} ");
    }
    else if (userOption == 5)
    {
        for(int  i = 1; i <= second; i++)
        {
            Console.WriteLine($" {first} * {i} = {first*i} ");
        }
        
    }
    else
    {
        Console.WriteLine("Invalid Selection");
    }
}

void DisplayMessage()
{
    Console.WriteLine("Please provide any operation");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Product table");
    Console.WriteLine("6. Exit");
}

int ReadUserInputOperation()
{
    int operation = int.Parse(Console.ReadLine());
    return operation;
}
int[] ReadUserInput()
{
    //Read n number of input
    Console.WriteLine("how many input do you want?");
    int n = int.Parse( Console.ReadLine() );

    int[] inputs = new int[n];
    for(int i = 0; i < n; i++)
    {
        inputs[i] = int.Parse(Console.ReadLine());
    }
    var inp = String.Join(",", inputs);
    return inputs ;
}

#endregion