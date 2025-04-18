public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        List<int> li = new List<int>();
        List<List<int>> res = new List<List<int>>();
        subsetResult(0, nums, li, res);
        return res.Cast<IList<int>>().ToList(); 
    }

    public void subsetResult(int ind, int[] nums, List<int> li, List<List<int>> res) {

        if(ind == nums.Length){
            res.Add(new List<int>(li));
            return;
        }
        li.Add(nums[ind]);
        subsetResult(ind+1, nums, li, res);
        li.RemoveAt(li.Count-1);
        subsetResult(ind+1, nums, li, res);
    }
}