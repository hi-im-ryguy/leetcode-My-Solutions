using System.Collections.Generic;


public class Solution {
    public static int[] TwoSum(int[] nums, int target) {
		var answer = NoteDownNumber(nums, target);
		Console.WriteLine(answer[0]);
		Console.WriteLine(answer[1]);
		return answer;
    }

	public static int[] NoteDownNumber(int[] nums, int target) {
		int originalTarget = target;
		Dictionary<int, int> validPartners = new Dictionary<int, int>();

		for (int i = 0; i < nums.Length; i++) {
			int theValue = nums[i];
			int validAnswer = target - theValue;

			if (validPartners.TryGetValue(validAnswer, out int index)) {
				Console.WriteLine("Found a valid partner!");
				Console.WriteLine(validAnswer);
				Console.WriteLine(index);
				Console.WriteLine(i);
				return new int[] {index, i};
			};

			if (validPartners.ContainsKey(theValue)) continue;

			validPartners.Add(theValue, i);
			target = originalTarget;
		}

		PrintDictionary(validPartners);

		return new int[] {0, 0};
	}

	public static void PrintDictionary(Dictionary<int, int> it) {
		Console.WriteLine(string.Join(Environment.NewLine, it.Select(kvp => $"{kvp.Key}: {kvp.Value}")));
	}

	public static void Main(String[] args) {
		TwoSum(new int[] {2,7,11,15}, 9);
	}
}