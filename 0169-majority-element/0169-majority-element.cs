public class Solution {
    public int MajorityElement(int[] nums) {
        int result = nums.GroupBy(p=>p).OrderByDescending(g=>g.Count()).FirstOrDefault().Key;
        return result;
    }
}