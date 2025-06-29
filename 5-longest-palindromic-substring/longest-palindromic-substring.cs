public class Solution {
    public string LongestPalindrome(string s)
    {
    
        if (string.IsNullOrEmpty(s)) return "";

        string answer = s[0].ToString();
        int max = 1;

        for (int i = 0; i < s.Length; i++)
        {
            string result = "";
            for (int j = i; j < s.Length; j++)
            {
                result += s[j];
                if (isPalindrome(result) && result.Length > max)
                {
                    max = result.Length;
                    answer = result;
                }
            }
        }

        return answer;
    }

    private bool isPalindrome(string str)
    {
        int left = 0, right = str.Length - 1;
        while (left < right)
        {
            if (str[left] != str[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
}