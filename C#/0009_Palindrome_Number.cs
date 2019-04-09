public class Solution {
    public bool IsPalindrome(int x) {
            int temp = x;
            int reversedInt = 0;

            while (temp > 0)
            {
                int digit = temp % 10;
                reversedInt = (reversedInt * 10) + digit;
                temp = temp / 10;
            }

            if (x == reversedInt)
            {
                return true;
            } else
            {
                return false;
            }
        }
}
