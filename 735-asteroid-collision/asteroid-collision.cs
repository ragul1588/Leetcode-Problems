public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
         List<int> st = new List<int>();
    int n = asteroids.Length;

    for (int i = 0; i < n; i++)
    {
        if (asteroids[i] > 0)
        {
            st.Add(asteroids[i]);
        }
        else
        {
            while (st.Count > 0 &&
                   st[st.Count - 1] > 0 &&
                   st[st.Count - 1] < Math.Abs(asteroids[i]))
            {
                st.RemoveAt(st.Count - 1);
            }

            if (st.Count > 0 &&
                st[st.Count - 1] == Math.Abs(asteroids[i]))
            {
                st.RemoveAt(st.Count - 1);
            }
            else if (st.Count == 0 ||
                     st[st.Count - 1] < 0)
            {
                st.Add(asteroids[i]);
            }
        }
    }

    return st.ToArray();
}
}