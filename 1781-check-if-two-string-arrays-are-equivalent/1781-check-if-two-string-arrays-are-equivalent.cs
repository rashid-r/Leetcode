public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        var one = string.Join("",word1);
        var two = string.Join("",word2);
        return one == two;
    }
}