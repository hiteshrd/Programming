public class Solution {
    Dictionary<(int, int), int> dic;
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        dic = new Dictionary<(int, int), int>();
        return FindPath(obstacleGrid, 0,0);
        
    }
    private int FindPath(int[][] grid, int x, int y)
    {
        (int, int)[] movements = new (int,int)[]{(0,1), (1,0)};
        int row = grid.Length;
        int col = grid[0].Length;
        int count = 0;
        if(grid[x][y] == 1 || x >= row  || y >= col)
            return 0;
        if(x == row -1 && y == col-1 && grid[x][y] == 0)
        {
            return 1;
        }
        if(dic.TryGetValue((x,y),out count))
            return count;
        
        
        foreach((int a,int b) in movements)
        {
            int newx = x + a;
            int newy = y + b;
            if(newx >=0 && newx < row && newy >= 0 && newy < col && grid[newx][newy] == 0)
            {
                count += FindPath(grid,newx,newy);
            }            
        }        
        dic.Add((x,y), count);
        return count;
        
    }
}
