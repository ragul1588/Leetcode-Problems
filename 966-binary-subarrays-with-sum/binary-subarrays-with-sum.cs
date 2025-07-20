public class Solution {
    public int NumSubarraysWithSum(int[] nums, int goal) {
      var prefixCount = new Dictionary<int, int>();
        prefixCount[0] = 1;  // to handle sum from index 0
        int sum = 0, result = 0;

        foreach (int num in nums) {
            sum += num;

            if (prefixCount.ContainsKey(sum - goal)) {
                result += prefixCount[sum - goal];
            }

            if (!prefixCount.ContainsKey(sum)) {
                prefixCount[sum] = 0;
            }

            prefixCount[sum]++;
        }

        return result;
    }
}