public class Solution {
    public int CharacterReplacement(string s, int k) {
        
        //Better Solution
        int maxLen = 0, n = s.Length, l=0, r=0, maxFreq = 0;
        int[] hash = new int[26];
        while(r<n){
            hash[s[r]-'A']++;
          maxFreq = Math.Max(hash[s[r]-'A'], maxFreq);

          while((r-l+1)-maxFreq>k){
            hash[s[l]-'A']--;
            maxFreq = 0;
            for(int i=0; i<25; i++){
                maxFreq = Math.Max(maxFreq,hash[i]);
            }
            l++;
          }
          if((r-l+1)-maxFreq<=k){
            maxLen = Math.Max(r-l+1,maxLen);
          }
          r++;
        }
        return maxLen;
    }
}