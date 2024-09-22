using System;
using Xunit;
using CodilityProject.PermMissingElem;

namespace CodilityProject.PermMissingElem.Tests
{
    public class SolutionTest
    {
        private readonly Solution _solution;

        public SolutionTest()
        {
            _solution = new Solution();
        }

        [Fact]
        public void Test_EmptyArray()
        {
            int[] A = new int[] { };
            int result = _solution.solution(A);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test_SingleElementArray()
        {
            int[] A = new int[] { 2 };
            int result = _solution.solution(A);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test_MissingElementInMiddle()
        {
            int[] A = new int[] { 2, 3, 1, 5 };
            int result = _solution.solution(A);
            Assert.Equal(4, result);
        }

        [Fact]
        public void Test_MissingLastElement()
        {
            int[] A = new int[] { 1, 2, 3, 4 };
            int result = _solution.solution(A);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Test_MissingFirstElement()
        {
            int[] A = new int[] { 2, 3, 4, 5 };
            int result = _solution.solution(A);
            Assert.Equal(1, result);
        }
    }
}