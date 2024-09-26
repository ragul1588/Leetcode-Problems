public class Solution {
   int[] RotateRight(int[] nums,int start, int end){
      while(start<end){
        int temp = nums[start];
        nums[start] = nums[end];
        nums[end]=temp;
        start++;
        end--;
      }
      return nums;
   }

    public void Rotate(int[] nums, int k) {
        int N=nums.Length;
        if(k>N) k=k%N;
        
            nums=RotateRight(nums,0,N-1);
            nums=RotateRight(nums,0,k-1);
            nums=RotateRight(nums,k,N-1);
    }
}