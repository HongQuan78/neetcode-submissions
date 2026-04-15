public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int key = target - nums[i];
            if(dictionary.ContainsKey(key))
            {
                return new int[] {dictionary[key], i};
            }  

            dictionary[nums[i]] = i;
        }

        return new int[] {0, 0};
    }
}
