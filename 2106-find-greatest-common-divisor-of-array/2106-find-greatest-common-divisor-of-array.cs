public class Solution {
    public int FindGCD(int[] nums) {
        int small = nums.Min();
        int large = nums.Max();
        int result = 0;
        for(int i=1; i<=small; i++){
            if(small % i == 0 && large % i == 0){
                result = i;
            }
        }
        return result;
    }
}