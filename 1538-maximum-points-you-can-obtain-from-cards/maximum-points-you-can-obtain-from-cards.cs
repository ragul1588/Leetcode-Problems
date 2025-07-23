public class Solution {
    public int MaxScore(int[] cardPoints, int k) {
        
        int sum = 0, maxPoints = 0, n = cardPoints.Length;
        for(int i=0; i<k; i++){
           sum +=cardPoints[i]; 
        }
        maxPoints = Math.Max(maxPoints, sum);
         int right = n-1;
        for(int i=k-1; i>=0; i--){
            sum -=cardPoints[i];
            sum +=cardPoints[right];
            right--;
            maxPoints = Math.Max(maxPoints,sum);
        }
        return maxPoints;
    }
}