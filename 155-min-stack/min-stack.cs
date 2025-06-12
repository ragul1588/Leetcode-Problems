public class MinStack {
    private Stack<long> st = new Stack<long>();
    private long mini;

    /** initialize your data structure here. */
    public MinStack() {
        mini = long.MaxValue;
    }

    public void Push(int value) {
        long val = (long)value;
        if (st.Count == 0) {
            mini = val;
            st.Push(val);
        } else {
            if (val < mini) {
                st.Push(2 * val - mini);
                mini = val;
            } else {
                st.Push(val);
            }
        }
    }

    public void Pop() {
        if (st.Count == 0) return;

        long val = st.Pop();
        if (val < mini) {
            mini = 2 * mini - val;
        }
    }

    public int Top() {
        long val = st.Peek();
        if (val < mini) {
            return (int)mini;
        }
        return (int)val;
    }

    public int GetMin() {
        return (int)mini;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */