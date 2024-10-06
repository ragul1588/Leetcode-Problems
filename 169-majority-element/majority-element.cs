public class Solution {
    public int MajorityElement(int[] nums) {
        int times = nums.Length/2, val = -1;
        if(nums.Length==1) return nums[0];
        if(nums.Length==0 || nums ==null) return -1;

         Dictionary<int,int> Dict = new Dictionary<int,int>();
        foreach(var a in nums){
          if(Dict.ContainsKey(a)){
            if(Dict[a]>times-1){
                val = a;
                return val;
            }
            Dict[a]++;
          }
          else{
            Dict[a] =1;
          }
        }
        return -1;
    }
}