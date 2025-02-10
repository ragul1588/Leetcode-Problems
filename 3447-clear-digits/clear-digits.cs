public class Solution {
    public string ClearDigits(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char ch in s)
        {
            if (char.IsDigit(ch) && stack.Count > 0)
            {
                stack.Pop();
            }
            else
            {
                stack.Push(ch);
            }
        }
        return new string(stack.Reverse().ToArray());
    }
}