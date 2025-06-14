public class Solution {
    public int Trap(int[] height) {
        int[] leftArray = leftSide(height);
        int[] rightArray = rightSide(height);
         int n = height.Length;
         int total = 0;

        for(int i=0; i<n; i++){
           int left = leftArray[i];
           int right = rightArray[i];

           if(left>height[i] && right>height[i]){
              total += Math.Min(left,right) - height[i];
           }
        }
        return total;
    }

    public int[] leftSide(int[] arr){
      int n = arr.Length;
      int[] left = new int[n];
      left[0] = arr[0];
      for(int i=1; i<n; i++){
         left[i] = Math.Max(arr[i],left[i-1]);
      }
        return left;
    }
    public int[] rightSide(int[] arr){
       int n = arr.Length;
      int[] right = new int[n];
      right[n-1] = arr[n-1];
      for(int i=n-2; i>=0; i--){
         right[i] = Math.Max(arr[i],right[i+1]);
      }
        return right;
    }
}