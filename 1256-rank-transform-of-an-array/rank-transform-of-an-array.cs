public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        Dictionary<int,int> Dict = new Dictionary<int,int>();
        int[] nums = arr.ToArray();
        Array.Sort(arr);
        int[] nums2 = arr;
        int i =1;
        foreach(var a in nums2){
            if(!Dict.ContainsKey(a)){
              Dict[a] = i;
              i++;
            }
        }
        i =0;
        foreach(var a in nums){
            if(Dict.ContainsKey(a)){
                nums2[i] = Dict[a];
                i++;
            }
        }
        return nums2;
    }
}