public class Solution {
    public int CountNegatives(int[][] grid) {
        return grid.SelectMany(a=>a).Count(n=>n<0);
    }
}