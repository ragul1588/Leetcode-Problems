public class Solution {
    public string FrequencySort(string s) {
       var charFrequency =  new Dictionary<char, int>();

       foreach(char a in s){
        if(charFrequency.ContainsKey(a)){
            charFrequency[a]++;
        }
        else charFrequency[a] = 1;
       }
      
       string result = string.Concat(
            charFrequency
                .OrderByDescending(kvp => kvp.Value)
                .Select(kvp => new string(kvp.Key, kvp.Value)));
                return result;
                
    }
}