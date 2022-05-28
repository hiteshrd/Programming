public class Solution {
    Dictionary<(int, int), int> dic;
    public int LongestIncreasingPath(int[][] matrix) {
        int result = 1;
        dic = new Dictionary<(int, int), int>();
        for(int i = 0; i< matrix.Length;i++)
        {
            for(int j = 0; j < matrix[i].Length; j++)
            {
                result = Math.Max(result, FindLength(matrix,i,j));
            }
        }
        return result;
        
    }
    private int FindLength(int[][] matrix, int x, int y)
    {
        (int, int)[] movements = new (int,int)[]{(0,-1), (0,1), (1,0),(-1,0)};
        int row = matrix.Length;
        int col = matrix[0].Length;
        int result = 1;
        
        if(dic.ContainsKey((x,y)))
        {
            return dic[(x,y)];
        }
        
        foreach((int a,int b) in movements)
        {
            int newx = x + a;
            int newy = y + b;
            if(newx >=0 && newx < row && newy >= 0 && newy < col && matrix[x][y] < matrix[newx][newy])
            {
                result = Math.Max(result, 1+ FindLength(matrix,newx,newy));
            }
                
            
        }
        dic[(x,y)] = result;
        
        return result;
    }
}
