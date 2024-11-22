public class Solution {
    public void SortColors(int[] nums) {
        
     int low = 0, mid = 0, high = nums.Length - 1;

        while (mid <= high)
        {
            if (nums[mid] == 0)
            {
                // Swap nums[low] and nums[mid], move both pointers
                Swap(nums, low, mid);
                low++;
                mid++;
            }
            else if (nums[mid] == 1)
            {
                // If it's 1, just move the mid pointer
                mid++;
            }
            else
            {
                // Swap nums[mid] and nums[high], move high pointer
                Swap(nums, mid, high);
                high--;
            }
        }
    }

    // Helper method to swap elements in the array
    private void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}