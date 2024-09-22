public class SolutionTests
{
    [Theory]
    [InlineData(9, 2)]    // Binary: 1001, Longest binary gap: 2
    [InlineData(529, 4)]  // Binary: 1000010001, Longest binary gap: 4
    [InlineData(20, 1)]   // Binary: 10100, Longest binary gap: 1
    [InlineData(15, 0)]   // Binary: 1111, Longest binary gap: 0
    [InlineData(32, 0)]   // Binary: 100000, Longest binary gap: 0
    public void TestSolution(int input, int expected)
    {
        // Arrange
        var solution = new Solution();

        // Act
        var result = solution.solution(input);

        // Assert
        Assert.Equal(expected, result);
    }
}