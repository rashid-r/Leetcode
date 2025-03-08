public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var result = nums.GroupBy(p=>p).Any(n=>n.Count() > 1);
        return result;
    }
}