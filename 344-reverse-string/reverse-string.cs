public class Solution {
    public void ReverseString(char[] s) {
       Stack<char> st = new Stack<char>();
       foreach(char a in s) st.Push(a); 
       for(int i=0; i<s.Length; i++){
          s[i] = st.Pop();
       } 
    }
}