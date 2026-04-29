public class MinStack {
    private Stack<int> stack;
    private Stack<int> minStack;

    public MinStack() {
        stack = new Stack<int>();    
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if (minStack.Count == 0 || minStack.Peek() >= val)
        {
            minStack.Push(val);
        }
    }
    
    public void Pop() {
        if (stack.Count == 0)
        {
            return;
        }

        int val = stack.Pop();
        if(minStack.Count > 0 && minStack.Peek() == val)
        {
            minStack.Pop();
        }
        
    }
    
    public int Top() {
        if (stack.Count > 0)
        {
            return stack.Peek();
        }

        return 0;
    }
    
    public int GetMin() {
        
        if (minStack.Count > 0)
        {
            return minStack.Peek();
        }

        return 0;
    }
}
