public class Solution {
    public bool IsPalindrome(string s) {
        int leftPointer = 0;
        int rightPointer = s.Length - 1;
        
        while(leftPointer < rightPointer)
        {
            if(!char.IsLetterOrDigit(s[leftPointer]))
            {
                leftPointer++;
                continue;
            }
            if(!char.IsLetterOrDigit(s[rightPointer]))
            {
                rightPointer--;
                continue;
            }
            if(char.ToLower(s[leftPointer]) != char.ToLower(s[rightPointer]))
            {
                return false;
            }

            leftPointer++;
            rightPointer--;
        }

        return true;
    }
}
