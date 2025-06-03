public class Solution {
    public int CountEven(int num) {
        
        var result = new List<int>();
        List<int> list = Enumerable.Range(1,num).ToList();
        foreach(int l in list){
            var sum = l.ToString().Select(a=> int.Parse(a.ToString())).Sum();
            if(sum%2==0)
            result.Add(sum);
        }
        return result.Count();
    }
}