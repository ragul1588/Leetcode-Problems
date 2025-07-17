public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        var li = new List<int>();
        var result = new List<IList<int>>();
        int sum = 0;
        int index = 0;
        combinationSolution(candidates, target, li, result, sum, index);
        return result;
    }

    public void combinationSolution(int[] arr, int target, List<int> li, List<IList<int>> result, int sum, int index) {
        if(sum == target){
            result.Add(new List<int>(li));
            return;
        }
        if(sum>target){
            return;
        }

        for(int i=index; i<arr.Length; i++){
            li.Add(arr[i]);
            combinationSolution(arr, target, li, result, sum+arr[i], i);
            li.RemoveAt(li.Count-1);
        }
    }
}