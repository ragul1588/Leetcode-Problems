public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        //Brute Force Solution
        if(s == null || s.Length == 0) return 0;
        if(s == " ") return 1;
        var li = new List<char>();
        int n = s.Length,maxLen =0;
        for(int i=0; i<n; i++){
            li.Clear();
             string result="";
            for(int j=i; j<n; j++){
              if(li.Contains(s[j])){
                break;
              }
              else{
                li.Add(s[j]);
                result +=s[j];
                maxLen = Math.Max(maxLen, result.Length);
              }
            }
        }
        return maxLen;
    }
}