public class Solution {
    public int[][] Transpose(int[][] matrix) {
        int m = matrix[0].Length;
        int n = matrix.Length;
        int[][] result = new int[m][];

        for(int i = 0; i< n; i++)
        {
            for(int j = 0; j< m; j++)
            {
                if(result[j] == null)
                    result[j] = new int[n];
                result[j][i] =  matrix[i][j];
            }
        }
        return result;
    }
}
