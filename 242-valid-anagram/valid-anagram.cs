public class Solution {
    public bool IsAnagram(string s, string t) {
        int sLen = s.Length, tLen = t.Length;
        if(sLen != tLen) return false;

        int[] valid =  new int[26];

        for(int i=0; i<sLen; i++){
            valid[s[i]-'a']++;
            valid[t[i]-'a']--;
        }
        for(int i=0; i<26; i++){
            if(valid[i] !=0) return false;
        }
        return true;
    }
}