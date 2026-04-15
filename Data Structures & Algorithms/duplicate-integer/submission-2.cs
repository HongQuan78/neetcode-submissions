public class Solution {
    public bool hasDuplicate(int[] nums) {
       
       if (nums.Length <= 1)
       {
        return false;
       }

       HashSet<int> hash = new HashSet<int>();
       foreach(int num in nums)
       {
            if(hash.Contains(num))
            {
                return true;
            }

            hash.Add(num);
       }
       return false;
    }
}