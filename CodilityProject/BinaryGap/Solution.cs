using System;
namespace CodilityProject.BinaryGap;
public class Solution {
    public int solution(int N) {
        // Step 1: Convert the integer to binary
        var binary = Convert.ToString(N, 2);
        
        // Step 2: Initialize variables
        int count = 0;
        int result = 0;
        bool counting = false;

        // Step 3: Iterate through the binary string
        for (int i = 0; i < binary.Length; i++) {
            if (binary[i] == '1') {
                // If we encounter '1' and counting is true, update result
                if (counting) {
                    if (result < count) {
                        result = count;
                    }
                    count = 0; // Reset count after updating result
                }
                counting = true; // Start counting zeros after the first '1'
            } else if (counting) {
                // If we are counting, increment count for each '0'
                count++;
            }
        }

        // Step 4: Return the result
        Console.Error.WriteLine(binary); // For debugging purposes
        return result;
    }
}
