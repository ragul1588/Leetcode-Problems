public class Solution {
    public int NumMatchingSubseq(string s, string[] words) {
       
     int No_OfSequence = 0;
     
      int n = s.Length, minLen = Int32.MaxValue, index = -1;
        
        //Optimal solution
     
         //for(int i=0; i<n; i++){
  
             foreach(string s2 in words){
                int j=0;
                int t=0;
                int m = s2.Length;
               while(j<n && t<m){
                    if(s[j] == s2[t]) t++;
                    
                    j++;
                }
                
                if(t==m){
                        No_OfSequence +=1;
                }
            }
        //}
       return No_OfSequence;
    }
        
        //return index == -1 ? "" : s1.Substring(index,minLen);
       
    

     
}