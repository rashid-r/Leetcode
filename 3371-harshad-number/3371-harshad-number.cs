public class Solution {
    public int SumOfTheDigitsOfHarshadNumber(int x) {
        var result = x.ToString().Select(a=>int.Parse(a.ToString())).Sum();
        return x % result == 0 ? result : -1 ;
    }
}