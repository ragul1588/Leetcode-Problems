public class Solution {
    public int NumberOfSubarrays(int[] nums, int k) {
       return NumberOfSubarrayCount_LessThanK(nums,k) - NumberOfSubarrayCount_LessThanK(nums,k-1);
    }

    public int NumberOfSubarrayCount_LessThanK(int[] nums, int k) {
       if(k<0) return 0;

       int n = nums.Length, maxLen = 0,left = 0,sum = 0;
       for(int right=0; right<n; right++) {
            sum +=nums[right]%2;
           
           while(right>=left && sum>k){
               sum -=nums[left]%2;
               left++;
           }
           maxLen += (right-left+1);
        }
        return maxLen;
    }
}