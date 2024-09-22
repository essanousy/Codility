
namespace CodilityProject.OddOccurrencesInArray;

public class Solution {
    public int solution(int[] A) {
        int result = 0;
        for (int i = 0; i < A.Length; i++) {
            result ^= A[i];
        }
        return result;
    } 

    public int solutionWithDictionary(int[] A) {
        var counts = new Dictionary<int, int>();
        foreach (var number in A) {
            if (counts.ContainsKey(number)) {
                counts[number]++;
            } else {
                counts[number] = 1;
            }
        }
        foreach (var kvp in counts) {
            if (kvp.Value % 2 != 0) {
                return kvp.Key;
            }
        }
        throw new InvalidOperationException("No unpaired element found");
    }
}