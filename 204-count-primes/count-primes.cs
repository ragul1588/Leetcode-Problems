public class Solution {
    public int CountPrimes(int n) {
        
        int i,j,k =0;
        int count =0;
        bool[] ds = new bool[n+1];

        for(i=2; i<=n; i++){
            ds[i] = true;
        }

        for(j=2; j*j<=n; j++){
          for(k=j*j; k<=n; k+=j){
             ds[k] = false;
             
          }
        }
        int val =n;
        while(val>0){
            if(ds[val-1]==true){
               count++;
            }
            val--;
        }
        return count;
    }
}