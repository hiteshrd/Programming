public class Solution {
    public int MaxProduct(string[] words) {
       // Array.OrderByDescending(words, a=>a.ToCharArray().Count());
         words = words.OrderByDescending(c => c.ToCharArray().Count()).ToArray();
        int result = 0;
        for(int i = 0; i< words.Length; i++)
        {
            char[] arr = words[i].ToCharArray();
            for(int j = i+1; j<words.Length;j++)
            {
                var arr2 = words[j].ToCharArray();
                if(arr.Any(a=>arr2.Contains(a)))
                {
                    continue;
                }
                else
                {
                    int temp = arr2.Count() * arr.Count();
                    result = Math.Max(result,temp);
                }
            }
        }
        return result;
    }
}
