public class Solution {
    public int[][] GenerateMatrix(int n) {
        int startrow = 0;
        int endrow = n-1;
        int startcol = 0;
        int endcol = n-1;
        int num = 1;
        int[][] result = new int[n][];
        for (int k = 0; k < n; k++)
            result[k] = new int[n];
        while(true)
        {
            for(int i = startcol; i<= endcol; i++)
            {
                result[startrow][i] = num;
                num++;
            }
            startrow++;
            if(startrow > endrow)
                break;
            for(int i = startrow; i<= endrow; i++)
            {
                result[i][endcol] = num;
                num++;
            }
            endcol--;
            if(startcol > endcol)
                break;
            for(int i = endcol; i>= startcol; i--)
            {
                result[endrow][i] = num;
                num++;
            }
            endrow--;
            for(int i = endrow; i>= startrow; i--)
            {
                result[i][startcol] = num;
                num++;
            }
            startcol++;
        }
        return result;
        
    }
}
