public class Solution {
    public int HammingWeight(int n) {
        return Convert.ToString(n,2).ToString().Select(x => int.Parse(x.ToString())).Sum();
    }
}