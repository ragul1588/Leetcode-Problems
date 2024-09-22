public class Solution {
    public int SingleNonDuplicate(int[] nums) {
           
           int N = nums.Length;
           if(N==1) return nums[0];
           
            for (int i = 0; i < N; i++)
            {
                if (nums[0] != nums[1]) return nums[0];
                if (nums[N-1] != nums[N-2]) return nums[N-1];
                     
                else
                {
                    if(i==0) i++;
                    if(i==N-1) i--;
                    if (nums[i - 1] != nums[i] && nums[i] != nums[i + 1])
                    {
                        return nums[i];
                    }
                }
            }
            return -1;
    }
}