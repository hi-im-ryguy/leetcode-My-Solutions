/**
 * @param {number[]} height
 * @return {number}
 */
var maxArea = function(height) {
    let maxArea = 0;
    let tallestLeftIndex = 0;
    let tallestRightIndex = height.length - 1;
    
    for (let i = tallestLeftIndex; i < height.length; i++) {
        if (height[i] > height[tallestLeftIndex] || i == 0) {
            tallestLeftIndex = i;
            for (let j = tallestRightIndex; j > i; j--) {
                if (height[j] >= height[i]) {
                    maxArea = Math.max(maxArea, Math.min(height[i], height[j]) * (j - i));
                    break;
                }
                if (height[j] > height[tallestRightIndex] || j == height.length - 1) {
                    tallestRightIndex = j;
                    maxArea = Math.max(maxArea, Math.min(height[i], height[j])* (j - i));
                }
            }
        }
    }
    return maxArea;
};
