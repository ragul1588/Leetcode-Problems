public class Solution {
     private const int MOD = 1000000007;
    public int RangeSum(int[] nums, int n, int left, int right) {
        List<BigInteger> subarraySums = new List<BigInteger>();
        BigInteger sum;

        for (int i = 0; i < nums.Length; i++)
        {
            sum = 0;
            for (int j = i; j < nums.Length; j++)
            {
                sum += nums[j];
                subarraySums.Add(sum);
            }
        }

        subarraySums.Sort();

        BigInteger result = 0;
        for (int k = left - 1; k < right; k++)
        {
            result = (result + subarraySums[k]) % MOD;
        }

        return (int)result;
    }
}