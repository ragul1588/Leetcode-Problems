public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int sum =0;

        for(int i=0; i<weights.Length; i++){
            sum+=weights[i];
        }
        int ans =-1, low = weights.Max(), high = sum;
        while(low<=high){
          int mid = (low+high)/2;
          int daysReq = findDays(weights,mid);
          if(daysReq<=days){
            high = mid-1;
            ans = mid;
          } 
          else low = mid+1;
        }
        return ans;
    }

    int findDays(int[] arr, int mid){
       int day =1, load =0;
       for(int i=0; i<arr.Length; i++){
        if(load + arr[i]>mid){
            day+=1;
            load=arr[i];
        }
        else load+=arr[i];
       }
       return day;
    }
}