public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        if(candies.Length == 0 || candies == null) return null;
        int count = 0;
        int greatest = Int32.MinValue;
        foreach(var a in candies){
           if(a>=greatest){
            greatest = a;
           }
           count++;
        }

        bool[] result = new bool[count];

        for(int i=0; i<candies.Length; i++){
          if((candies[i] + extraCandies) >= greatest){
            result[i] = true;
          }
        }

        return result;  
    }
}