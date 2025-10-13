public class Solution {
    public int MaximumCount(int[] nums) {
        var pos = nums.Count(e => e>0);
        var neg = nums.Count(x => x<0);
        var max = Math.Max(pos,neg);
        return max;
    }
}