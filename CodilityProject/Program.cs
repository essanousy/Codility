using CodilityProject.BinaryGap;

internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution = new();
        int exampleNumber = 3215; // Example number
        int result = solution.solution(exampleNumber);
        Console.WriteLine($"result : {result}");
    }
}