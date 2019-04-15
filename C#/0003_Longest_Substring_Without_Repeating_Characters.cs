public class Solution {
    public int LengthOfLongestSubstring(string s)
        {
        // Because our only goal is the return the largest length of a non-repeating substring, regardless
        // of length, we can initialize a field to keep track of that at 0
        int longestLength = 0;

        // I decided to use a Queue, because I want to be able to easily dequeue a string's characters,
        // until it reaches the duplicate characters, because we want a SUBSTRING not a SUBSEQUENCE
        Queue<char> uniqueCharacters = new Queue<char>();
        
        // Let's iterate through the string s. Because C# treats strings as an array of char, we can do this easily with foreach
        foreach (char letter in s)
        {
            
            // Check to see if this letter is repeated, if it is, remove all characters BEFORE it
            // until it reaches the duplicate letter, including the duplicate letter itself
            while (uniqueCharacters.Contains(letter))
            {
                uniqueCharacters.Dequeue();
            }
            
            // No matter what happens, queue this character into the Queue.
            uniqueCharacters.Enqueue(letter);
            
            // Increment longestLength whenever the substring is bigger than the "last" biggest substring
            if (uniqueCharacters.Count > longestLength)
            {
                longestLength++;
            }
        }
        return longestLength;
    }
}
