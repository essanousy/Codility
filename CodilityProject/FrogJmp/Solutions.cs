namespace CodilityProject.FrogJmp
{
    public class Solution
    {
        public int solution(int X, int Y, int D)
        {
            if (X == Y)
            {
                return 0;
            }
            int distance = Y - X;
            int jumps = distance / D;
            if (distance % D != 0)
            {
                jumps++;
            }
            return jumps;
        }
    }
}