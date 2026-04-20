public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(string str in strs)
        {
            sb.Append(str.Length);
            sb.Append("#");
            sb.Append(str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> strs = new List<string>();
        
        int currentIndex = 0;

        while(currentIndex < s.Length)
        {
            int delimiterIndex = currentIndex;
            
            while(s[delimiterIndex] != '#')
            {
                delimiterIndex++;
            }

            int length = int.Parse(s.Substring(currentIndex, delimiterIndex - currentIndex));
            int startIndex = delimiterIndex + 1;

            strs.Add(s.Substring(startIndex, length));
            currentIndex = startIndex + length;
        }

        return strs;
        
   }
}
