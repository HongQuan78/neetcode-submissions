public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        int length = nums.Length;
        Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();
        for (int i = 0; i < length; i++) 
        {
            int sum = 0;
            for (int j = i + 1; j < length; j++) 
            {
                for (int k = j + 1; k < length; k++)
                {
                    sum = nums[i] + nums[j] + nums[k];
                    if (sum == 0)
                    {
                        string key = $"{nums[i]},{nums[j]},{nums[k]}";
                        if (!dictionary.ContainsKey(key))
                        {
                            dictionary[key] = new List<int> { nums[i], nums[j], nums[k] };
                        }

                    }
                }
            }
           
        }

        return dictionary.Values.ToList();
    }
}
