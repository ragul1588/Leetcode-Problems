public class Solution {
    public int MaxSubArray(int[] nums) {
    int pre =0,suff =0,max=Int32.MinValue;
    if(nums.Length==null|| nums.Length==0) return 0;
    
     if(nums.Length==1) return nums[0];

     for(int i=0; i<nums.Length; i++){
         if(pre<0) pre = 0;
         if(suff<0) suff = 0;

        pre = pre + nums[i];
        suff = suff + nums[nums.Length-i-1];
        max = Math.Max(max, Math.Max(pre,suff));
     }
     
     return max;
}
}