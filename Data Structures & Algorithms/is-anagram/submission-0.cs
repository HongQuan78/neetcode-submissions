public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> dictionary = new Dictionary<char, int>();
        
        foreach(char c in s)
        {
            if(dictionary.ContainsKey(c))
            {
                dictionary[c]++;
                continue;
            }

            dictionary.Add(c, 1);
        }

        foreach(char c in t)
        {
            if (!dictionary.ContainsKey(c))
            {
                return false;
            }

            dictionary[c]--;

            if(dictionary[c] < 0)
            {
                return false;
            }

        }

        return true;

        
    }
}
