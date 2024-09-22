namespace CodilityProject.PermMissingElem
{
    public class Solution
    {
        public int solution(int[] A)
        {
            int n = A.Length + 1;
            /// <summary>
            /// Calculates the total sum of the first 'n' natural numbers using the formula n * (n + 1) / 2.
            /// This formula is derived from the arithmetic series sum formula.
            /// Source: https://en.wikipedia.org/wiki/Arithmetic_progression#Sum
            /// </summary>
            long totalSum = (long)n * (n + 1) / 2;
            long arraySum = A.Sum(number => (long)number);

            return (int)(totalSum - arraySum);
        }
    }
}