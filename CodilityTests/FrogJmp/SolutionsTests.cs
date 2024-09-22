using Xunit;
using CodilityProject.FrogJmp;
 
namespace CodilityTests.FrogJmp.Tests
{
    public class SolutionsTest
    {
        private readonly Solution _solution;

        public SolutionsTest()
        {
            _solution = new Solution();
        }

        [Fact]
        public void Test_SamePosition()
        {
            int result = _solution.solution(10, 10, 30);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test_SingleJump()
        {
            int result = _solution.solution(10, 40, 30);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test_MultipleJumps()
        {
            int result = _solution.solution(10, 85, 30);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Test_ExactJump()
        {
            int result = _solution.solution(10, 70, 30);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test_OneJumpNeeded()
        {
            int result = _solution.solution(10, 20, 5);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test_LargeDistance()
        {
            int result = _solution.solution(1, 1000000000, 1);
            Assert.Equal(999999999, result);
        }

        [Fact]
        public void Test_LargeJump()
        {
            int result = _solution.solution(1, 1000000000, 1000000000);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test_ZeroDistance()
        {
            int result = _solution.solution(0, 0, 1);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test_ZeroJumpDistance()
        {
            int result = _solution.solution(0, 1, 1);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test_NegativeStart()
        {
            int result = _solution.solution(-10, 10, 5);
            Assert.Equal(4, result);
        }
    }
}