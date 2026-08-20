using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace LongestIncreasingSubsequence.Services;

public class LongestIncreasingSubsequenceSolver
{

    public int[] Find(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return [];
        }

        int[] numbers = input
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        return FindLongestIncreasingSubsequence(numbers);
    }
    private int[] FindLongestIncreasingSubsequence(int[] numbers)
    {
        if (numbers.Length == 0)
        {
            return [];
        }

        int bestStart = 0;
        int bestLength = 1;

        int currentStart = 0;
        int currentLength = 1;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > numbers[i - 1])
            {
                currentLength++;

                if (currentLength > bestLength)
                {
                    bestStart = currentStart;
                    bestLength = currentLength;
                }
            }
            else
            {
                currentStart = i;
                currentLength = 1;
            }
        }

        return numbers
            .Skip(bestStart)
            .Take(bestLength)
            .ToArray();
    }
}

