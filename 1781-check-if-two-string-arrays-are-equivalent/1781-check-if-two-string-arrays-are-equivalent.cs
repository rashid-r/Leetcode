public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
        return string.Join("",word2) == string.Join("",word1);
    }
}