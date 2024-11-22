public class Solution {
    public IList<IList<int>> Generate(int numRows) {
       List<IList<int>> ans = new List<IList<int>>();

        // Generate Pascal's Triangle row by row
        for (int row = 1; row <= numRows; row++)
        {
            List<int> tempLst = new List<int>();  // Temporary list for the current row

            // For each column in the row, calculate nCr(row-1, col-1)
            for (int col = 1; col <= row; col++)
            {
                tempLst.Add(nCr(row - 1, col - 1));  // Add nCr(row-1, col-1) to the current row
            }

            // Add the current row to the result
            ans.Add(tempLst);
        }

        return ans; 
    }
     public static int nCr(int n, int r)
    {
        long res = 1;

        // Calculate nCr
        for (int i = 0; i < r; i++)
        {
            res = res * (n - i);
            res = res / (i + 1);
        }

        return (int)res;  // Cast result to int before returning
    }
}