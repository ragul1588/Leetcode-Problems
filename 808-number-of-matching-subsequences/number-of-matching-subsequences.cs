public class Solution {
    public int NumMatchingSubseq(string s, string[] words) {

      int n = s.Length, minLen = Int32.MaxValue, index = -1,No_OfSequence = 0;

        //Optimal solution
             foreach(string s2 in words){
                int j=0;
                int t=0;
                int m = s2.Length;
               while(j<n && t<m){
                    if(s[j] == s2[t]){
                      t++;
                    } 
                    j++;
                }
                if(t==m){
                    No_OfSequence +=1;
                }
            }
       return No_OfSequence;
    }
}