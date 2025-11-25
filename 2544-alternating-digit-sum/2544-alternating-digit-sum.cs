public class Solution {
    public int AlternateDigitSum(int n) {
    var list = new List<int>();
    var signed = new List<int>();
    var unsigned = new List<int>();

    string str = n.ToString();

    for (int i = 0; i < str.Length; i++) {
        list.Add(str[i] - '0');
    }

    for (int j = 0; j < list.Count; j++) {
        if (j % 2 == 0)
            signed.Add(list[j]);
        else
            unsigned.Add(-list[j]); 
    }

    return signed.Sum() + unsigned.Sum();
}
}