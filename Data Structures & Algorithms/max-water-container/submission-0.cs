public class Solution {
    public int MaxArea(int[] heights) {
        int result = 0;
        for(int i = 0; i < heights.Length; i++)
        {
            
            for(int j = i+1; j < heights.Length; j++)
            {
                int area = Math.Min(heights[i], heights[j]) * (j - i);
                if (area > result)
                {
                    result = area;
                }
            }
            
        }

        return result;
    }
}
