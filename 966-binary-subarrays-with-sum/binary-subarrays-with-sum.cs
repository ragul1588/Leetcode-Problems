public class Solution {
    public int NumSubarraysWithSum(int[] nums, int goal) {
        int n = nums.Length, sum = 0, count=0;

        for (int i = 0; i < n; i++) {
            sum = 0;
            for (int j = i; j < n; j++) {
                if ((sum += nums[j]) == goal) count++;
            }
        }
        return count;
    }
}