public class Solution {
    public int LongestOnes(int[] nums, int k) {
         int left = 0, maxLen = 0,n=nums.Length,zeros=0;
      
        for(int i=0; i<n; i++){
          if(nums[i]==0){
            zeros++;
          }

          while(zeros>k){
            if(nums[left]==0){
                zeros--;
            }
            left++;
          }

          maxLen = Math.Max(maxLen, i-left+1);
        }
        return maxLen;
    }
}