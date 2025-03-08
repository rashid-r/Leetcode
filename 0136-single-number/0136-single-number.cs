public class Solution {
    public int SingleNumber(int[] nums) {
        return nums.GroupBy(p=>p).Where(n=>n.Count()==1).Select(g=>g.Key).FirstOrDefault();
     
    }
}