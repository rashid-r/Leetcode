public class Solution {
    public bool DetectCapitalUse(string word) {
        return word == word.ToUpper()||char.IsUpper(word[0]) && word.Substring(1) == word.Substring(1).ToLower()||word == word.ToLower() ? true : false;
    }
}