public class Solution {
    public int LengthOfLastWord(string s) {
        var wordsList = s.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
        var result = wordsList.Last();
        return result.Length;
    }
}