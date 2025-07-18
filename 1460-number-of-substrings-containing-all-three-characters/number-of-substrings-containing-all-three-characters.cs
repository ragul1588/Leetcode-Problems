public class Solution {
    public int NumberOfSubstrings(string s) {
     //Brute Force Solution
         int count=0, n = s.Length;
        for(int i=0; i<n; i++){
            int[] val = new int[3];
           for(int j=i; j<n; j++){
               val[s[j] - 'a'] = 1;
              if(val[0] + val[1] + val[2] == 3){
                 count = count + (n-j);
                 break;
            }
         }
     }
     return count;
    }
}