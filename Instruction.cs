namespace Calculator_App_Broadway;

internal class Instruction
{
    public void GetCoreInstruction()
    {
        Console.WriteLine("Please any below operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("6. Exit");

    }
    public void GetSubCoreInstruction(string operationType)
    {
        Console.WriteLine($"1.1 {operationType} with two level of input");
        Console.WriteLine($"1.2 {operationType} with three level of input");
        Console.WriteLine($"1.3 {operationType} with N level of input");
    }
}
