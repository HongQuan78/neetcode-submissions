public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int arrayLength = nums.Length;
        int[] results = new int[arrayLength];

        results[0] = 1;
        for(int i = 1; i < arrayLength; i++)
        {   
            results[i] = results[i - 1] * nums[i - 1];
        }

        int right = 1;
        for(int i = arrayLength - 1; i >= 0; i--)
        {
            results[i] *= right;
            right *= nums[i]; 
        }

        return results;
    }
}
