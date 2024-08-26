public class Solution {
    public int MissingNumber(int[] nums) {
        int count =0;
        Array.Sort(nums);
        foreach(int val in nums){
            if(count==val){
                count++;
            }
            else{
                return count;
            }
        }
        return count;
    }
}