public class Solution {
    public int CommonFactors(int a, int b)
    {
        int gcd = GCD(a, b);
        return CountFactors(gcd);
    }
    
    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    
    private int CountFactors(int n)
    {
        int count = 0;
        for (int i = 1; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                count++; // i is a factor
                if (i != n / i)
                {
                    count++; // (n / i) is also a factor
                }
            }
        }
        return count;
    }
}