public class Solution {
    public int KthFactor(int n, int k) {
        var res = new List<int>();
     
    for(int i=1; i*i<=n; i++){
      if(n%i == 0){
        res.Add(i);
        
        if(i != n/i){
           res.Add(n/i);
        }
      }
      res.Sort();
    }
      return k > res.Count ? -1 : res[k-1];
    }
}