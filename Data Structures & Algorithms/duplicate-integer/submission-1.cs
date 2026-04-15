public class Solution {
    public bool hasDuplicate(int[] nums) {
       
       if (nums.Length <= 1)
       {
        return false;
       }

       Array.Sort(nums);

        for(int i = 0; i < nums.Length; i++)
        { 
            int nextIndex = i + 1;
            if (nextIndex >= nums.Length)
            {
                return false;
            }

            if (nums[i] - nums[nextIndex] == 0)
            {
                return true;
            }
        }

       return false;
    }
}