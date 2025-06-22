public class Solution {
    public string[] DivideString(string s, int k, char fill) {
        if (s == null || s.Length == 0) return null;

        int i = 0;
        string[] result = new string[(s.Length + k - 1) / k];

        for (i = 0; i * k < s.Length; i++) {
            int remaining = s.Length - i * k;
            if (remaining >= k) {
                result[i] = s.Substring(i * k, k);
            } else {
                string last = s.Substring(i * k);
                while (last.Length < k) {
                    last += fill;
                }
                result[i] = last;
            }
        }

        return result;
    }
}