public class Solution {
    public int LongestOnes(int[] nums, int k) {
         int left = 0, maxLen = 0,n=nums.Length,zeros=0;
        
        //Optimal Solution
        
        for(int right=0; right<n; right++){
          if(nums[right]==0){
            zeros++;
          }
          if(zeros>k){
            if(nums[left]==0) zeros--;
            left++;
          }
           if(zeros<=k) maxLen = Math.Max(maxLen, right-left+1);
        }
        return maxLen;
    }
}