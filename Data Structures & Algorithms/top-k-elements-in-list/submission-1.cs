public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (int num in nums) 
        {
            if(dict.ContainsKey(num))
            {
                dict[num]++;
                continue;
            }
            
            dict.Add(num, 1);
        }
        
        return dict.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();

    }
}
