public class Solution {
    public IList<IList<int>> ShiftGrid(int[][] grid, int k) {
        SortedDictionary<int,int> myDic = new SortedDictionary<int,int>();
        int counter = k + 1;
        int len = grid.Length * grid[0].Length;
        for(int i = 0; i<grid.Length; i++)
        {
            int carryover = 0;
            //int 
            for(int j = 0; j< grid[i].Length; j++)
            {
                myDic.Add((counter)%len,grid[i][j]);
                counter++;
            }
        }
        
        counter = 1;
        for(int i = 0; i<grid.Length; i++)
        {
            for(int j = 0; j< grid[i].Length; j++)
            {
                grid[i][j] = myDic[counter == len ? 0: counter];
                counter++;
            }
            
        }
        return grid;
        
    }
}
