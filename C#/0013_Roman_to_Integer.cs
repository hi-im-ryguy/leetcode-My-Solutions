public class Solution {
    public int RomanToInt(string s) {
        int y = 0;

            // Iterate through the Roman Numeral string, one by one
            for (int i = 0; i < s.Length; i++)
            {
                // Integer representation of the current index of the Roman Numeral
                int digit1Integer = (int)Enum.Parse(typeof(RomanNumeralValues), s[i].ToString());

                // Check if there is another Roman "digit" and assign it to an integer representation
                if (i + 1 < s.Length)
                {
                    int digit2Integer = (int)Enum.Parse(typeof(RomanNumeralValues), s[i + 1].ToString());
                    
                    // Check if the Roman "digit" following the first one is a multiple of 5 or 10, then apply the
                    // Roman Numeral counting rules
                    if (digit1Integer * 5 == digit2Integer
                        || digit1Integer * 10 == digit2Integer)
                    {
                        digit1Integer = digit2Integer - digit1Integer;
                        i++;
                    }
                }
                y += digit1Integer;
            }
            return y;
    }
    
    public enum RomanNumeralValues
    {
        I = 1,
        V = 5,
        X = 10,
        L = 50,
        C = 100,
        D = 500,
        M = 1000
    }
}
