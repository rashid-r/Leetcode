public class Solution {
    public bool IsPalindrome(int x) {
        string c = x.ToString();
        char[] a = c.ToCharArray();
        Array.Reverse(a);
        string r = new string(a);
        return c == r ;
    }
}