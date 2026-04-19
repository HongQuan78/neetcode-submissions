public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (int num in nums) 
        {
            if (dict.ContainsKey(num)) 
            {
                dict[num]++;
                continue;
            }

            dict.Add(num, 1);
        }

        int bucketSize = nums.Length + 1;
        List<int>[] buckets = new List<int>[bucketSize];

        foreach (var item in dict) 
        {
            if (buckets[item.Value] == null) 
            {
                buckets[item.Value] = new List<int>();
            }

            buckets[item.Value].Add(item.Key);
        }

        int[] result = new int[k];
        int count = 0;
        for (int i = bucketSize - 1; i >= 0; i--) 
        {
            if (buckets[i] == null) 
            {
                continue;
            }
            foreach (int num in buckets[i]) 
            {
                result[count++] = num;
                if (count == k) 
                {
                    return result;
                }
            }
        }

        return result;
    }
}
