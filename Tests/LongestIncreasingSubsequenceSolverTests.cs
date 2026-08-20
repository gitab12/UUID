using LongestIncreasingSubsequence.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSubsequence.Tests;

public class LongestIncreasingSubsequenceSolverTests
{
    [Test]
    public void Find_ShouldReturnLongestIncreasingSequence()
    {
        // Arrange
        var solver = new LongestIncreasingSubsequenceSolver();
        string input = "6 1 5 9 2";

        // Act
        int[] result = solver.Find(input);

        // Assert
        Assert.That(result, Is.EqualTo(new[] { 1, 5, 9 }));
    }

    [Test]
    public void Find_ShouldReturnEarliestSequence_WhenMultipleSequencesHaveSameLength()
    {
        // Arrange
        var solver = new LongestIncreasingSubsequenceSolver();
        string input = "6 2 4 6 1 5 9 2";

        // Act
        int[] result = solver.Find(input);

        // Assert
        Assert.That(result, Is.EqualTo(new[] { 2, 4, 6 }));
    }

    [Test]
    public void Find_ShouldReturnCorrectResult_ForAssignmentTestCase11()
    {
        // Arrange
        var solver = new LongestIncreasingSubsequenceSolver();
        string input = "6 2 4 3 1 5 9";

        // Act
        int[] result = solver.Find(input);

        // Assert
        Assert.That(result, Is.EqualTo(new[] { 1, 5, 9 }));
    }

    [Test]
    public void Find_ShouldReturnEmptyArray_WhenInputIsEmpty()
    {
        // Arrange
        var solver = new LongestIncreasingSubsequenceSolver();

        // Act
        int[] result = solver.Find("");

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Find_ShouldReturnEmptyArray_WhenInputContainsOnlyWhitespace()
    {
        // Arrange
        var solver = new LongestIncreasingSubsequenceSolver();

        // Act
        int[] result = solver.Find("   ");

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Find_ShouldBreakSequence_WhenDuplicateNumbersAreFound()
    {
        // Arrange
        var solver = new LongestIncreasingSubsequenceSolver();
        string input = "1 2 2 3";

        // Act
        int[] result = solver.Find(input);

        // Assert
        Assert.That(result, Is.EqualTo(new[] { 1, 2 }));
    }

    [Test]
    public void Find_ShouldHandleNegativeNumbers()
    {
        // Arrange
        var solver = new LongestIncreasingSubsequenceSolver();
        string input = "-5 -3 -1 -2 0";

        // Act
        int[] result = solver.Find(input);

        // Assert
        Assert.That(result, Is.EqualTo(new[] { -5, -3, -1 }));
    }

    [Test]
    public void Find_ShouldReturnSingleNumber_WhenSequenceIsCompletelyDecreasing()
    {
        // Arrange
        var solver = new LongestIncreasingSubsequenceSolver();
        string input = "9 7 5 3 1";

        // Act
        int[] result = solver.Find(input);

        // Assert
        Assert.That(result, Is.EqualTo(new[] { 9 }));
    }
}