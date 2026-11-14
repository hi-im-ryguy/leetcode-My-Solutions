using System.Collections.Generic;


public class Solution {
    public int[] TwoSum(int[] nums, int target) {
		var answer = NoteDownNumber(nums, target);
		return answer;
    }

	public static int[] NoteDownNumber(int[] nums, int target) {
		int originalTarget = target;
		Dictionary<int, int> validPartners = new Dictionary<int, int>();

		for (int i = 0; i < nums.Length; i++) {
			int theValue = nums[i];
			int validAnswer = target - theValue;

			if (validPartners.TryGetValue(validAnswer, out int index)) {
				return new int[] {index, i};
			};

			if (validPartners.ContainsKey(theValue)) continue;

			validPartners.Add(theValue, i);
			target = originalTarget;
		}
		return new int[] {0, 0};
	}
}