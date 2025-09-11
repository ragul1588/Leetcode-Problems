public class Solution {
    public int MaxScore(int[] cardPoints, int k) {
        
        int r =0, l=0, maxScore=0, n=cardPoints.Length;
        
        for(int i=0; i<k; i++){
          maxScore +=cardPoints[i];
        }
         int rightInd = n-1;
         l=maxScore;
        for(int i=k-1; i>=0; i--){
          l -=cardPoints[i];
          r +=cardPoints[rightInd];
          maxScore = Math.Max(maxScore,r+l); 
          rightInd--;
        }
        return maxScore;
    }
}