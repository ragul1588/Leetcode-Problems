public class Solution {
    public string KthDistinct(string[] arr, int k) {
        Dictionary<string,int> Dict = new Dictionary<string,int>();
        string[] temp = new string[arr.Length]; 
        int j=0;
        foreach(var a in arr){
            if (Dict.ContainsKey(a)){
                Dict[a]++;
            }
            else{
                Dict[a]=1;
            }
        }
        
        foreach(var val in Dict){
            if(val.Value==1){
                temp[j] = val.Key;
                j++;
            }
        }
        
        if(j>=k){
            return temp[k-1];
        }
        return "";
    }
}