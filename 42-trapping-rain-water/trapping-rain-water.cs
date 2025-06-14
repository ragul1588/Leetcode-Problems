public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        int left = 0, leftMax = height[0], right = n-1, rightMax =0;
        int total = 0;
        while(left<right) {
            if(height[left]<=height[right]){
                if(height[left]<leftMax){
                total += leftMax - height[left];
            }
            else{
                leftMax = height[left];
            }
             left++;
            }
            else{
                if(height[right]<rightMax){
                    total += rightMax - height[right];
                }
                else {
                    rightMax = height[right];
                }
                 right--;
            }
            
        }
        return total;
    }
}