public class Solution {
    public string LongestCommonPrefix(string[] strs)
        {
        string commonPrefix = strs.Length > 0 ? GetFirstShortestString(strs) : "";
        for (int i = 0; i < strs.Length; i++)
        {
            for (int j = 0; j < strs[i].Length && j < commonPrefix.Length; j++)
            {                   
                if (strs[i][j] != commonPrefix[j])
                {
                    commonPrefix = commonPrefix.Substring(0, j);
                }

                if (commonPrefix == "")
                {
                    return commonPrefix;
                }
            }
        }
        return commonPrefix;
        }
    
    public string GetFirstShortestString(string[] strs) {
        string shortestString = strs.Length > 0 ? strs[0] : "";
        foreach (string str in strs) {
            if (str.Length < shortestString.Length) {
                shortestString = str;
            }
        }
        return shortestString;
    }
}
