public class Solution {
    public string ReverseWords(string s) {
        return string.Join(" ",s.Split(" ").Select(a=> new string(a.Reverse().ToArray())));
    }
}