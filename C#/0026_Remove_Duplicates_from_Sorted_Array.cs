class Solution {
public:
    int removeDuplicates(vector<int>& nums) {
        int sizeOfArray = nums.size();
        if (sizeOfArray == 0) {
            return 0;
        }
        if (sizeOfArray == 1) {
            return 1;
        }

        int uniqueValues = 1;
        int uniqueNumber = nums[0];
        int index = 1;

        for (int i = 1; i < sizeOfArray; i++) {
            if (uniqueNumber != nums[i]) {
                uniqueNumber = nums[i];
                nums[index] = uniqueNumber;
                uniqueValues++;
                index++;
            }
        }
        return uniqueValues;
    }
};
