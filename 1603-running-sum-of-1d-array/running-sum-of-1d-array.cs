public class Solution {
    public int[] RunningSum(int[] nums) {
        
        int[] val = new int[nums.Length];
        val[0] = nums[0];
        for(int i=1; i<nums.Length; i++){
            val[i]=val[i-1]+nums[i];
        }
        return val;
    }
}