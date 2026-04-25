public class Solution {
    public bool IsValid(string s) {
        if (s.Length == 0 || s.Length % 2 != 0)
        {
            return false;
        }

        Stack<char> parentheses = new Stack<char>();
        
        foreach(char currentValue in s)
        {
            if(currentValue == '[' || currentValue == '(' || currentValue == '{')
            {
                parentheses.Push(currentValue);
                continue;
            }

            if(parentheses.Count == 0)
            {
                return false;
            }

            char peek = parentheses.Peek();
            if (currentValue - peek == 1 || currentValue - peek == 2)
            {
                parentheses.Pop();
                continue;
            }

            return false;
        }
        
        return parentheses.Count == 0;
    }
}
