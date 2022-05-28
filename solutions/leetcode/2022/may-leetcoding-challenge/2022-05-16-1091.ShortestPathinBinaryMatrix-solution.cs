public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        bool[][] visited = new bool[grid.Length][]; 
        for(int i = 0; i < grid.Length;i++)
        {
            visited[i] = new bool[grid.Length];
        }
        (int,int)[] movements = new []{(-1,-1),(-1,0),(-1,1),(1,-1),(1,0),(1,1), (0,-1),(0,1)};
        Queue<(int,int)> qe = new Queue<(int,int)>();
        qe.Enqueue((0,1));
        qe.Enqueue((1,0));
        qe.Enqueue((1,1));
        int n = grid.Length-1;
        visited[0][0] = true;
        int len = 1;
        if(n < 0 || grid[0][0] == 1 || grid[n][n] == 1)
            return -1;
        if(n == 0)
            return 1;
        while(qe.Count >0)
        {
            len++;
            int count  =qe.Count;
            for(int i=0;i<count;i++)
            {
                (int row, int col) = qe.Dequeue();
                if(row <0 || col < 0 || row > n || col > n || grid[row][col] ==1)
                {
                    continue;
                }
                if(!visited[row][col])
                {
                    if(row == col && row == n)
                    {
                        return len;
                    }
                    visited[row][col] = true;
                    foreach((int x,int y) in movements)
                    {
                        qe.Enqueue((row+x, col+y));
                    }
                }
            }
        }
        return -1;
    }
}
