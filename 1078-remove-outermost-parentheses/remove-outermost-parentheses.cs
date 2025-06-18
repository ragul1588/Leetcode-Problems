public class Solution {
    public string RemoveOuterParentheses(string s) {
        int count = 0;
        int n = s.Length;
        string result = "";
        foreach(char a in s) {
        if (a == ')') {
            count--;
        }
        if (count != 0) result += a;
        if((a == '(')){
            count++;
        }
    }
    return result;
    }
}