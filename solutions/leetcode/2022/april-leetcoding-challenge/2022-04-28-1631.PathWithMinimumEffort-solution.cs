public class Solution {
    public int MinimumEffortPath(int[][] heights) {
        int rows = heights.Length;
        int cols = heights[0].Length;
        PriorityQueue<(int,int),int> myQueue = new PriorityQueue<(int rows,int cols),int>();
        myQueue.Enqueue((0,0),0);
        Dictionary<(int,int),int> myDic = new Dictionary<(int,int),int>();
        myDic.Add((0,0),0);
        
        while(myQueue.TryDequeue(out var cell, out var val))
        {
            var (row,col) = cell;
            if(row == rows-1 && col == cols-1)
            {
                return val;
            }
            var cells = new[]{
                (row-1,col),(row,col-1),(row+1,col), (row, col+1)
            };
            foreach (var (i,j) in cells)
            {
                if(i<0 || j< 0 || i> rows-1 || j > cols-1)
                {
                    continue;
                }
                int newVal = Math.Max(Math.Abs(heights[row][col] - heights[i][j]), val);
                if(!myDic.ContainsKey((i,j)) || myDic[(i,j)] > newVal)
                {
                    myQueue.Enqueue((i,j),newVal);
                    myDic[(i,j)] = newVal;
                }
                
            }
            
        }
        return -1;
        
    }
}
