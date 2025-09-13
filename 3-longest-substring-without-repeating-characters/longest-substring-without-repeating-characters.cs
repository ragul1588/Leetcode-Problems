public class Solution {
    public int LengthOfLongestSubstring(string s) {

        //Optimal Solution
        if(s == null || s.Length == 0) return 0;
        
        int left=0,maxLen=0,n=s.Length;
        var map = new Dictionary<char,int>();
         
        for(int right=0; right<n; right++){
          
          if(map.ContainsKey(s[right]) && left<=map[s[right]]){
             left = map[s[right]]+1;
          }
          map[s[right]] = right;
          maxLen = Math.Max(maxLen,(right-left+1));
        }
        return maxLen;
    }  
}