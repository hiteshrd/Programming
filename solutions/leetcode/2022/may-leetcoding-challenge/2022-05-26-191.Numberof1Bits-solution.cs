public class Solution {
    public int HammingWeight(uint n) {
        int result =0;
        string str = Convert.ToString(n,2);
        int[] num = str.ToCharArray().Select(a=>a-'0').ToArray();
        for(int i = 0;i<num.Length;i++)
            {
            if(num[i] == 1)
                {
                result++;
                }
            }
        return result;
    }
}
