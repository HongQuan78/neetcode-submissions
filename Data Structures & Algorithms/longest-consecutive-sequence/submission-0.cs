public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length == 0)
        {
            return 0;
        }
        int totalCount = 1;
        HashSet<int> hash = new HashSet<int>();
        foreach(int num in nums)
        {
            if(!hash.Contains(num))
            {
                hash.Add(num);
            }
        }

        foreach(int num in hash)
        {
            if(hash.Contains(num - 1))
            {
                continue;
            }

            int count = 0; 
            int value = num;
            
            while(hash.Contains(value))
            {
                count++;
                value++;
            }

            if(totalCount < count)
            {
                totalCount = count;
            }
        }
        return totalCount;
    }
}
