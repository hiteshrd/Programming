public class Solution {
    public int FindMaxForm(string[] strs, int m, int n) {
        int[,] arr = new int[m+1,n+1];
        int zero,one;
        for(int i=0;i<strs.Length;i++)
        {
            zero = 0;
            for(int j=0;j<strs[i].Length;j++)
                if(strs[i][j]=='0')
                    zero++;
            one = strs[i].Length-zero;
            
            for(int j=m;j>=zero;j--)
                for(int k=n;k>=one;k--)
                    arr[j,k]=Math.Max(arr[j,k],1+arr[j-zero,k-one]);
        }
        return arr[m,n];
    }
}
