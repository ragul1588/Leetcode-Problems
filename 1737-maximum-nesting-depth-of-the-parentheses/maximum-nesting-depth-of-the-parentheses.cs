public class Solution {
    public int MaxDepth(string s) {
        
        int maxDepth = 0, count =0;
        foreach(char a in s){
            if(a == '('){
              maxDepth = Math.Max(maxDepth, ++count);
            }
            else if(a == ')'){
                count--;
            }
        }
        return maxDepth;
    }
}