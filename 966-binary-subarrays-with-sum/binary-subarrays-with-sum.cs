public class Solution {
    public int NumSubarraysWithSum(int[] nums, int goal) {
       return numOfSubarrayLessThanGoal(nums,goal) - numOfSubarrayLessThanGoal(nums,goal-1);
    }
    public int numOfSubarrayLessThanGoal(int[] nums, int goal){
      
      int sum = 0, left = 0,count= 0;
      if(goal<0) return 0;
      
      for(int right=0; right<nums.Length; right++) {
         sum +=nums[right];

          while(left<=right && sum>goal){
             sum -=nums[left];
             left++;
          }
          count += (right-left+1);
       }
       return count;
    }
}