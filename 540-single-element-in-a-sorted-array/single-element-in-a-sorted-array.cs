public class Solution {
    public int SingleNonDuplicate(int[] nums) {
       Dictionary<int,int> dict = new Dictionary<int,int>();

       foreach(var dt in nums){
         if(dict.ContainsKey(dt)){
            dict[dt]++;
         }
         else{
            dict[dt]=1;
         }
       }
       foreach(int dt in nums){
         if(dict[dt]==1) return dt;
       }
       return -1;
    }
}