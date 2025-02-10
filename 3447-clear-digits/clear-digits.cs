public class Solution {
public string ClearDigits(string s)
{
    string val = "";
    int count = -1;
    List<Char> li = new List<Char>();
        foreach (Char a in s)
        {
            li.Add(a);
            count++;
            if (Char.IsNumber(a))
            {
                if (Char.IsLetterOrDigit(li[count - 1]) == true)
                {
                    li.RemoveAt(count);
                    li.RemoveAt(count - 1);
                    count = count - 2;
                }
                else {
                    li.RemoveAt(count);
                    count--;
                }
            }
        }
        foreach (Char a in li)
        {
            val += a;
        }
        return val;
    }
}