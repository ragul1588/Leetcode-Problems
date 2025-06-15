public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int[] nse = findNse(heights);
        int[] pse = findPse(heights);
        int maxSize = Int32.MinValue;
        int n = heights.Length;
        for(int i=0; i<n; i++){
             maxSize = Math.Max(maxSize , (heights[i]*(nse[i] - pse[i] - 1)));
        }
        return maxSize;
    }
    public int[] findNse(int[] arr){
        int n = arr.Length;
        Stack<int> st = new Stack<int>();
        int[] res = new int[n];

        for(int i=n-1; i>=0; i--){
            while(st.Count>0 && arr[st.Peek()]>arr[i]){
                st.Pop();
            }
            res[i] = st.Count==0? n : st.Peek();
            st.Push(i);
        }
        return res;
    }
    public int[] findPse(int[] arr){
        int n = arr.Length;
        Stack<int> st = new Stack<int>();
        int[] res = new int[n];

        for(int i=0; i<n; i++){
            while(st.Count>0 && arr[st.Peek()]>=arr[i]){
                st.Pop();
            }
            res[i] = st.Count==0? -1 : st.Peek();
            st.Push(i);
       }
       return res;
    }
}