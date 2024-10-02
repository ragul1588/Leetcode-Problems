public class Solution {
    public int MaxProfit(int[] prices) {
        int maxprofit = 0;
        int cost = 0;
        int mini = prices[0];

       for(int i=1; i<prices.Length; i++){
           cost = prices[i]-mini;
           maxprofit = Math.Max(maxprofit,cost);
           mini = (mini<prices[i]) ? mini : prices[i]; 
       }
       return maxprofit;
    }
}