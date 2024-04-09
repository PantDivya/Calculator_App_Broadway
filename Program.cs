
List<float> history_op1 = new List<float>();
List<float> history_op2 = new List<float>();
List<float> history_res = new List<float>();
List<char> history_operator = new List<char>();


void DisplayMessage()
{
    Console.WriteLine("\n\n\n\nWelcome to the Calculator \n ------------------ App V-0.1------------------");
    DateTime CurrentTime = DateTime.Now;
    if (CurrentTime.Hour > 1 && CurrentTime.Hour < 12)
    {
        Console.WriteLine("Good Morning\n\n\n");
    }
    else if (CurrentTime.Hour >= 12 && CurrentTime.Hour < 18)
    {
        Console.WriteLine("Good Afternoon\n\n\n");

    }
    else
    {
        Console.WriteLine("Good Evening\n\n\n");
    }
    Console.WriteLine("Select the Appropriate Option ");
    Console.WriteLine("Enter 1 for Addition ");
    Console.WriteLine("Enter 2 for Subraction ");
    Console.WriteLine("Enter 3 for Multliplication ");
    Console.WriteLine("Enter 4 for Division");
    Console.WriteLine("Enter 5 for Close the Application");
    Console.WriteLine("Enter 6 for Viewing History");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option) 
    { 

        case 1:
            Addition();   

        break;

        case 2:
            Subraction();
        break;
        case 3:
            Multiplication();
        break;

        case 4:
            Division();
        break;
        
        case 5:
            return;
        break;

        case 6:
            ViewHistory();
        break;
        
        default: Console.WriteLine("hii");
          break; 

    }
}
    
   


List<float> takeinput()
{
    List<float> operands= new List<float>();
    Console.WriteLine("Enter First operand");
    float n1 = Convert.ToSingle(Console.ReadLine());
    operands.Add(n1); 
    Console.WriteLine("Enter Second operand");
    float n2 = Convert.ToSingle(Console.ReadLine());
    operands.Add(n2);

    return operands;
}

void Addition()
{

    List<float> operands = takeinput();
    float sum = operands[0]+operands[1];


    Console.WriteLine($"Sum of {operands[0]} and {operands[1]} is {sum}");

    //Strore data in result for history
    history_op1.Add(operands[0]);
    history_op2.Add(operands[1]);
    history_res.Add(sum);
    history_operator.Add('+');

    //reseting the calculator
    DisplayMessage();

}

void Subraction()
{
    List<float> operands = takeinput();

    Console.WriteLine("select the operation /n for a-b press 1.\n for b-a press 2");
    int input = Convert.ToInt32(Console.ReadLine());
    if (input == 1)
    {

        float difference = operands[0] - operands[1];


        Console.WriteLine($"difference of {operands[0]} and {operands[1]} is {difference}");

        //Strore data in result for history
        history_op1.Add(operands[0]);
        history_op2.Add(operands[1]);
        history_res.Add(difference);
        history_operator.Add('-');
    }

    else if (input == 2)
    {
        float difference = operands[1] - operands[0];


        Console.WriteLine($"difference of {operands[1]} and {operands[0]} is {difference}");

        //Strore data in result for history
        history_op1.Add(operands[1]);
        history_op2.Add(operands[0]);
        history_res.Add(difference);
        history_operator.Add('-');
    }

    //reseting the calculator
    DisplayMessage();

}

void Multiplication()
{

    List<float> operands = takeinput();
    float mul = operands[0] * operands[1];


    Console.WriteLine($"Multiplication of {operands[0]} and {operands[1]} is {mul}");

    //Strore data in result for history
    history_op1.Add(operands[0]);
    history_op2.Add(operands[1]);
    history_res.Add(mul);
    history_operator.Add('*');

    //reseting the calculator
    DisplayMessage();



}

void Division()
{
    List<float> operands = takeinput();

    Console.WriteLine("select the operation /n for a/b press 1.\n for b/a press 2");
    int input = Convert.ToInt32(Console.ReadLine());
    if (input == 1)
    {

        float result = operands[0] / operands[1];


        Console.WriteLine($"division of {operands[0]} and {operands[1]} is {result}");

        //Strore data in result for history
        history_op1.Add(operands[0]);
        history_op2.Add(operands[1]);
        history_res.Add(result);
        history_operator.Add('/');
    }

    else if (input == 2)
    {
        float result = operands[1] / operands[0];


        Console.WriteLine($"division of {operands[1]} and {operands[0]} is {result}");

        //Strore data in result for history
        history_op1.Add(operands[1]);
        history_op2.Add(operands[0]);
        history_res.Add(result);
        history_operator.Add('/');
    }

    //reseting the calculator
    DisplayMessage();

}

void ViewHistory()
{
    if(history_op1.Count >0)
    {
        for (int i = 0; i < history_op1.Count; i++)
        {
            Console.WriteLine($"-----------------------------------------");
            Console.WriteLine($"\n{history_op1[i]} {history_operator[i]} {history_op2[i]}= {history_res[i]}");
            Console.WriteLine($"-----------------------------------------");
        }
        Console.WriteLine($"\n\n\n");

    }
    else
    {
        Console.WriteLine($"\n\n------------History is empty----------");
    }

    DisplayMessage();

}

//Main Program

DisplayMessage();