public class Solution {
    public int NumberOfSubstrings(string s) {
     //Optimal Solution
         int count=0, n = s.Length;
         int[] val = {-1,-1,-1};
        for(int i=0; i<n; i++){
            val[s[i] - 'a'] = i;

           if(val[0]>-1 && val[1]>-1 && val[2]>-1) {
               count +=(1+Math.Min(Math.Min(val[0], val[1]), val[2]));
           }
         }
     return count;
    }
}