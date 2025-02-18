public class Solution {
    public string SmallestNumber(string pattern) {
        if(pattern.Length == 0 || pattern == null) return null;

        var stack = new Stack<int>();
        var result = new List<int>();
         int n = pattern.Length;
        for(int i=0; i<=n; i++) {
            stack.Push(i+1);

            if(i == n || pattern[i] == 'I'){
                while(stack.Count>0){
                  result.Add(stack.Pop());
                }
            }
        }
        return string.Join("", result);
    }
}