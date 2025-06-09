public class Solution {
    public int FindFinalValue(int[] nums, int original) {
        return nums.Contains(original) ? FindFinalValue(nums, original * 2) : original;
        // while (nums.Contains(original))
        // original *= 2;
        // return original;
    }
}