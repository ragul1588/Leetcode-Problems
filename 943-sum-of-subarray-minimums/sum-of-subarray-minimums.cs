public class Solution {
    public int SumSubarrayMins(int[] arr) {

     int[] nse = findNSE(arr);
     int[] pse = findPSE(arr);
     long sum = 0;
     int n = arr.Length;
     int mod = 1000000000+7;

     for(int i=0; i<n; i++){
        long left  = i - pse[i];
        long right = nse[i] - i;

        long freq = (left*right) % mod;
        //sum = sum +(freq*arr[i] % mod)%mod;
        sum = (sum + ((freq * arr[i]) % mod)) % mod;
     }
     
      return (int)sum;
    }

    public int[] findPSE(int[] arr){
        Stack<int> st = new Stack<int>();
        int n = arr.Length;
        int[] res = new int[n];
        
        for(int i=0; i<n; i++){
            while(st.Count>0 && arr[st.Peek()]>=arr[i]){
            st.Pop();
        }
        res[i] = st.Count == 0 ? -1 : st.Peek();
        st.Push(i);
        }
        return res;
    }
    public int[] findNSE(int[] arr){
        Stack<int> st = new Stack<int>();
        int n = arr.Length;
        int[] res = new int[n];
        
        for(int i=n-1; i>=0; i--){
            while(st.Count>0 && arr[st.Peek()]>arr[i]){
            st.Pop();
        }
        res[i] = st.Count == 0 ? n : st.Peek();
        st.Push(i);
        }
        return res;
    }
      
}