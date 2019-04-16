public class Solution {
    public int MaxArea(int[] heights)
        {
        int maxArea = 0;
        int biggestI = 0;
        int biggestJ = heights.Length - 1;

        // I'm going to "traverse" the graph, starting from the leftmost vertical line.
        for (int i = 0; i < heights.Length; i++)
        {
            // Because I'm traversing from the left, I only care about the vertical line, if it's taller than the recorded tallest line, or if it's the LEFT-most line.
            if (heights[i] > heights[biggestI] || i == 0)
            {
                biggestI = i;
                
                // After finding a taller line, than the last-recorded tallest line, I want to traverse the graph, starting from the RIGHT-most line.
                for (int j = biggestJ; j > i; j--)
                {
                    
                    // IF I find a line that is AS TALL or TALLER, than my current tallest, left-most line, I wanna stop traversing. There is no point in traversing anymore left, because I've found the biggest area possible.
                    if (heights[j] >= heights[i])
                    {
                        maxArea = Math.Max(maxArea, Math.Min(heights[i], heights[j]) * (j - i));
                        break;
                    }
                    
                    // IF I find a line that is TALLER, than my current tallest, RIGHT-MOST line, I wanna calculate the area, and check if it's bigger than the already-recorded 'maxArea'.
                    if (heights[j] >= heights[biggestJ] || j == heights.Length - 1)
                    {
                        maxArea = Math.Max(maxArea, Math.Min(heights[i], heights[j]) * (j - i));
                        biggestJ = j;
                    }
                }
            }
        }
        return maxArea;
    }
}
