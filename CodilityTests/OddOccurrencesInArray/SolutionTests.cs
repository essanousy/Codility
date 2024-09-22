using System;
using CodilityProject.OddOccurrencesInArray;
using Xunit;

namespace CodilityTests.OddOccurrencesInArray.Tests
{
    public class SolutionTests
    {
        private readonly Solution _solution;

        public SolutionTests()
        {
            _solution = new Solution();
        }

        [Fact]
        public void TestSingleElementArray()
        {
            int[] A = new int[] { 1 };
            int expected = 1;
            int result = _solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestArrayWithOddOccurrences()
        {
            int[] A = new int[] { 9, 3, 9, 3, 9, 7, 9 };
            int expected = 7;
            int result = _solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestArrayWithNegativeNumbers()
        {
            int[] A = new int[] { -1, -1, -2 };
            int expected = -2;
            int result = _solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestArrayWithLargeNumbers()
        {
            int[] A = new int[] { int.MaxValue, int.MaxValue, int.MinValue };
            int expected = int.MinValue;
            int result = _solution.solution(A);
            Assert.Equal(expected, result);
        }
    }
}