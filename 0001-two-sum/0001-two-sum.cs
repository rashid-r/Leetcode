public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        int sum = 0;
        for(int i=0; i<nums.Length; i++){
            for(int j= 1; j<nums.Length; j++){
                
                sum = nums[j] + nums[i];
                if(sum == target && i!=j){
                    return [i,j];
                    break ;
                }
                
            }
        }
        return [];
       
    }
}