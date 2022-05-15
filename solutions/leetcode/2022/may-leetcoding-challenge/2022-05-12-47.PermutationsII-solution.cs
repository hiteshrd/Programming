public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) {
        Dictionary<string,int[]> dic = new Dictionary<string,int[]>();
        var data = PrepareData(string.Join("", nums.Select(a=>(char)('k' + a))));
        return data.Select(s => s.Select(a=>a-'k').ToArray()).ToArray();
    }
    private HashSet<string> PrepareData(string str)
    {
        HashSet<string> hs = new HashSet<string>();
        if(str.Length ==1)
        {
            hs.Add(str);
        }
        else
        {
            string firstChar = str[0].ToString();
            var st = PrepareData(str.Substring(1));
            foreach(var item in st)
            {
                for(int i = 0;i<=item.Length;i++)
                {
                    hs.Add(item.Insert(i,firstChar));
                }
            }
        }
        return hs;
    }
}
