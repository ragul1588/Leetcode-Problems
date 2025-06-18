public class Solution {
    public int FirstUniqChar(string s) {
        int[] value = new int[26];
        foreach(char c in s) {
            value[c - 'a']++;
        }
        for (int i = 0; i < s.Length; i++) {
            if (value[s[i] - 'a'] == 1) return i;
        }
        return -1;
    }
}