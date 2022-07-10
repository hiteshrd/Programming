public class Solution {
    public int TotalNQueens(int n) {
        return FindQueens(0,n, new int[n], new bool[n]);
    }
    private int FindQueens(int count, int n, int[] queens, bool[] valid)
    {
        if(count == n)
            return 1;
        int result = 0;
        for(int i = 0; i<n;i++)
        {
            var temp = !valid[i];
            for(int j = 0; j < count && temp;j++)
            {
                if( Math.Abs(j-count) == Math.Abs(queens[j] - i))
                {
                    temp = false;
                }
            }
            if(temp)
            {
                queens[count]= i;
                valid[i] = true;
                result += FindQueens(count+1, n, queens,valid);
                valid[i] = false;
            }
        }
        return result;
    }
}
