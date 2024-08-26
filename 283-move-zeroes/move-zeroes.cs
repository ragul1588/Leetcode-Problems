public class Solution {
    public void MoveZeroes(int[] nums) {
        int temp=0, nonZeroVal =0;
        for(int i=0; i<nums.Length; i++){
            if(nums[i]!=0){
                temp = nums[i];
                nums[i] = nums[nonZeroVal];
                nums[nonZeroVal]=temp;
                nonZeroVal++;
            } 
        }
    }
}