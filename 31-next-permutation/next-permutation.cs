public class Solution {
    public void NextPermutation(int[] nums) {
        int n= nums.Length, i = n-2, j=n-1;

        while(i>=0 && nums[i]>=nums[i+1]){
            i--;
        }
        if(i>=0){
            while(nums[i]>=nums[j]){
                j--;
            }
            nums = swap(nums,i, j);
        }
        nums = reverse(nums, i+1, n-1); 
    }

    static int[] swap(int[] nums, int i, int j){
       int temp = nums[i];
       nums[i] = nums[j];
       nums[j] = temp;

       return nums;
    }
    static int[] reverse(int[] nums, int start, int end){
        while(start<end){
           nums = swap(nums,start,end);
           start++;
           end--;
        }
        return nums;
    }
}