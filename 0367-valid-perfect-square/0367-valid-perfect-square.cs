public class Solution {
    public bool IsPerfectSquare(int num) {

        if (num < 0) return false;

        double root = Math.Sqrt(num);
        return root == (int)root;
    }
}