public class Solution {
    public int RomanToInt(string s) {
        var map = new Dictionary<char, int>();
        map['I']  = 1;
        map['V']  = 5;
        map['X']  = 10;
        map['L']  = 50;
        map['C']  = 100;
        map['D']  = 500;
        map['M']  = 1000;
         
        int result = 0;

        for (int i = 0; i < s.Length - 1; i++) {
            if (map[s[i]] < map[s[i + 1]]) {
                result -= map[s[i]];
            } else {
                result += map[s[i]];
            }
        }

        result += map[s[s.Length - 1]];
        return result;
    }
}