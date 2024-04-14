//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Welcome to Broadway Calculator");

//Console.WriteLine("Please provide the first input");
//int firstInput=int.Parse(Console.ReadLine());

////statement
//Console.WriteLine("Please provide the second  input");

//int secondInput=int.Parse(Console.ReadLine());

//int sum=firstInput+secondInput;
////string Interpolation
//Console.WriteLine($"The result is : {sum}");


using Calculator_App_Broadway;

Calculator calc = new Calculator();
calc.DisplayResult();
Console.WriteLine();
calc.MultiplicationTable();

