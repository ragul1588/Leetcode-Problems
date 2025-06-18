public class Solution {
    public string RemoveOuterParentheses(string s) {
        int count = 0;
        string result = "";
        foreach (char c in s) {
            if (c == '(') {
                if (count > 0) result +=c;
                count++;
            } else {
                count--;
                if (count > 0) result +=c;
            }
        }
    return result;
    }
}