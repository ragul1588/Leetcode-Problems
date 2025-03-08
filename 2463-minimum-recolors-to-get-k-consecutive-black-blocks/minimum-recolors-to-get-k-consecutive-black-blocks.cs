public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        int minNumber = Int32.MaxValue;
        int count = 0;
        int numberOfTimes = 0;
        int val = blocks.Length-k;
        if(val==0){
           for(int i=0; i<blocks.Length; i++){
                if(blocks[i]=='W'){
                    count++;
                } 
           }
           return count;
        }

        for(int i=0; i<blocks.Length-k+1; i++){
            count = 0;
            numberOfTimes = 0;
            for(int j=i; j<blocks.Length; j++){
                 numberOfTimes++;
               if(blocks[j]=='W' && numberOfTimes<=k){
                count++;
               }
            }
            minNumber = count <= minNumber ? count : minNumber;
        }
        return minNumber;
    }
}