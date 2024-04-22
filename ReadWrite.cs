namespace Calculator_App_Broadway;

internal class ReadWrite
{
    string filepath = "E:\\dotNetTraining\\Calculator_App_Broadway\\logFile\\log.txt";

    public void WriteFile(int userOption, string operationType, string inputLevel, int[] userInput, int Ans)
    {

        using (StreamWriter sw = new StreamWriter(filepath))
        {
            sw.WriteLine("Please choose any below operation:");
            sw.WriteLine("1. Addition");
            sw.WriteLine("2. Subtraction");
            sw.WriteLine("3. Multiplication");
            sw.WriteLine("4. Division");
            sw.WriteLine("6. Exit");

            sw.WriteLine(userOption);

            sw.WriteLine($"1.1 {operationType} with two level of input");
            sw.WriteLine($"1.2 {operationType} with three level of input");
            sw.WriteLine($"1.3 {operationType} with N level of input");

            sw.WriteLine(inputLevel);

            sw.WriteLine($"Enter your inputs:");
            sw.WriteLine($"{string.Join(",", userInput)}");

            sw.WriteLine($"The calculation for given {userInput.Length} number of inputs: {Ans}");
        }

    }
    public void ReadFile()
    {
        using (StreamReader sr = new StreamReader(filepath))
        {
            sr.ReadToEnd();
        }
    }
}
