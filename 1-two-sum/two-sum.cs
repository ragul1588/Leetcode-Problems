public class Solution
{
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int,int> Dict = new Dictionary<int,int>();
        int i=0;
        foreach(var val in nums){
            int a = target-val;
            if(Dict.ContainsKey(a)){
                return new int[] {i, Dict[a]};
            }
            else{
                Dict[val] = i;
            }
            i++;
        }
        return new int[] {-1,-1};
    }
}