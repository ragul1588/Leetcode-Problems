public class Solution {
    public string[] UncommonFromSentences(string s1, string s2) {

        Dictionary<string, int> Dict = new Dictionary<string,int>();

        foreach(var val in s1.Split(" ")){
            if(Dict.ContainsKey(val)){
                Dict[val]++;
            }
            else Dict[val] =1;
        }
        foreach(var val in s2.Split(" ")){
            if(Dict.ContainsKey(val)){
                Dict[val]++;
            }
            else Dict[val] =1;
        }
         
         List<string> list = new List<string>();
        foreach(var val in Dict){
            if(val.Value==1)
            {
              list.Add(val.Key); 
            } 
        }
        return list.ToArray();
    }
}