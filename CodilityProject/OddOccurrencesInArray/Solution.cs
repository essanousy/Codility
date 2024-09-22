
namespace CodilityProject.OddOccurrencesInArray;

public class Solution {
    public int solution(int[] A) {
        int result = 0;
        for (int i = 0; i < A.Length; i++) {
            result ^= A[i];
        }
        return result;
    }
}