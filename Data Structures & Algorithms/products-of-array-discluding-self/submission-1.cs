public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int arrayLength = nums.Length;
        int[] results = new int[arrayLength];

        int left = 1;
        int[] leftProduct = new int[arrayLength];
        leftProduct[0] = 1;
        for(int i = 0; i < arrayLength; i++)
        {   
            if(i - 1 < 0)
            {
                continue;
            }

            left *= nums[i-1];
            leftProduct[i] = left;
        }

        int right = 1;
        int[] rightProduct = new int[arrayLength];
        rightProduct[arrayLength-1] = 1;
        for(int i = arrayLength - 1; i >= 0; i--)
        {   
            if(i + 1 >= arrayLength)
            {   
                continue;
            }
            right *= nums[i+1];
            rightProduct[i] = right;
        }

        for(int i = 0; i < arrayLength; i++)
        {
            results[i] = leftProduct[i] * rightProduct[i];
        }
        return results;
    }
}
