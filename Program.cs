using LongestIncreasingSubsequence.Services;

Console.Write("Enter numbers: ");

string? input = Console.ReadLine();

if (input is not null)
{
    var solver = new LongestIncreasingSubsequenceSolver();

    int[] result = solver.Find(input);

    Console.WriteLine("Longest increasing sequence:");
    Console.WriteLine(string.Join(" ", result));
}