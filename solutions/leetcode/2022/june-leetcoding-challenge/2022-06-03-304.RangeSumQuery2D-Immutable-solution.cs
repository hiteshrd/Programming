public class NumMatrix {
    int[][] matrix;
    public NumMatrix(int[][] matrix) {
        this.matrix = matrix;
        for(int i =0; i<matrix.Length; i++)
        {
            for(int j = 1; j<matrix[0].Length; j++)
            {
                this.matrix[i][j] = matrix[i][j-1] + matrix[i][j];
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        int result = 0;
        for(int i =row1; i<=row2; i++)
        {
            if(col1> 0)
            {
                result += this.matrix[i][col2] - this.matrix[i][col1-1];
            }
            else
            {
                result += this.matrix[i][col2];
            }
        }
        return result;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */
