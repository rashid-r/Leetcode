public class Solution {
    public bool AreOccurrencesEqual(string s) {
        return s.GroupBy(c => c)
                .Select(g => g.Count())
                .Distinct()
                .Count() == 1;
    }
}