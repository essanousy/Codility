using System;
using CodilityProject.CyclicRotation;
using Xunit;

namespace CodilityTests.CyclicRotation.Tests
{
    public class SolutionTests
    {
        private readonly Solution _solution;

        public SolutionTests()
        {
            _solution = new Solution();
        }

        [Fact]
        public void TestEmptyArray()
        {
            int[] A = new int[] { };
            int K = 3;
            int[] expected = new int[] { };
            int[] result = _solution.solution(A, K);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestSingleElementArray()
        {
            int[] A = new int[] { 1 };
            int K = 3;
            int[] expected = new int[] { 1 };
            int[] result = _solution.solution(A, K);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestRotationByZero()
        {
            int[] A = new int[] { 1, 2, 3, 4, 5 };
            int K = 0;
            int[] expected = new int[] { 1, 2, 3, 4, 5 };
            int[] result = _solution.solution(A, K);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestRotationByArrayLength()
        {
            int[] A = new int[] { 1, 2, 3, 4, 5 };
            int K = 5;
            int[] expected = new int[] { 1, 2, 3, 4, 5 };
            int[] result = _solution.solution(A, K);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestRotationByLessThanArrayLength()
        {
            int[] A = new int[] { 1, 2, 3, 4, 5 };
            int K = 2;
            int[] expected = new int[] { 4, 5, 1, 2, 3 };
            int[] result = _solution.solution(A, K);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestRotationByMoreThanArrayLength()
        {
            int[] A = new int[] { 1, 2, 3, 4, 5 };
            int K = 7;
            int[] expected = new int[] { 4, 5, 1, 2, 3 };
            int[] result = _solution.solution(A, K);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestRotationWithDuplicates()
        {
            int[] A = new int[] { 1, 2, 2, 3, 3 };
            int K = 3;
            int[] expected = new int[] { 2, 3, 3, 1, 2 };
            int[] result = _solution.solution(A, K);
            Assert.Equal(expected, result);
        }
    }
}