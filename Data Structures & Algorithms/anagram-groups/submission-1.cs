public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();
        
        foreach(string str in strs)
        {
            int[] charCounts = new int[26];

            foreach(char c in str)
            {
                int charIndex = c - 'a';
                charCounts[charIndex]++;
            }

            string key = KeyBuilder(charCounts);
            if (!result.ContainsKey(key))
            {
               result[key] = new List<string>();
            }
            
            result[key].Add(str);
        }

        return result.Values.ToList();
    }

    public string KeyBuilder(int[] arr)
    {
        return string.Join("#", arr);
    }
}
