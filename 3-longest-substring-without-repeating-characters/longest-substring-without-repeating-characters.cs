public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        //Brute Force Solution
        if(s == null || s.Length == 0) return 0;
        if(s == " ") return 1;
        int[] set = new int[256];
        int n = s.Length,maxLen =0;
        for(int i=0; i<n; i++){
            set = new int[256];
            for(int j=i; j<n; j++){
              if(set[s[j]]==1){
                break;
              }
              else{
                set[s[j]]=1;
                int Len = j-i+1;
                maxLen = Math.Max(maxLen, Len);
              }
            }
        }
        return maxLen;
    }
}