public class Solution {
    public int MissingNumber(int[] nums) {
        
        int n = nums.Length;
        int result = Enumerable.Range(1,n).Except(nums).FirstOrDefault();
        return result ;
    }
}