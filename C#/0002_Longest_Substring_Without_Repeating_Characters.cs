public class Solution {
    public int LengthOfLongestSubstring(string s)
        {
            int longestLength = 0;
            Queue<char> uniqueCharacters = new Queue<char>();
            foreach (char letter in s)
            {
                while (uniqueCharacters.Contains(letter))
                {
                    uniqueCharacters.Dequeue();
                }

                uniqueCharacters.Enqueue(letter);

                if (uniqueCharacters.Count > longestLength)
                {
                    longestLength++;
                }
            }
            return longestLength;
        }
}
