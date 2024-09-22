namespace CodilityProject.CyclicRotation;
public class Solution
{
    public int[] solution(int[] A, int K)
    {
        // Step 1: Initialize variables
        int[] result = new int[A.Length];
        int N = A.Length;

        // Step 2: Iterate through the array
        for (int i = 0; i < N; i++)
        {
            // Calculate the new index after rotation
            int newIndex = (i + K) % N;
            result[newIndex] = A[i];
        }

        // Step 3: Return the result
        return result;
    }
}

