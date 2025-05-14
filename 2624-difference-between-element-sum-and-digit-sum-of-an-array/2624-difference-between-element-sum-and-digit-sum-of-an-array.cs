public class Solution {
    public int DifferenceOfSum(int[] nums) {
        // int sum = nums.Aggregate((a,b) => a+b);
        int sum = nums.Sum();
        var sep = nums.SelectMany(n=>n.ToString()).Select(x=>int.Parse(x.ToString()));
        int sums = sep.Sum();
        return sum - sums;
    }
}