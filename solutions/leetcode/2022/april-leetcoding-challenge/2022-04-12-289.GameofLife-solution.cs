//Runtime: 214 ms, faster than 29.44% of C# online submissions for Game of Life.
//Memory Usage: 40.5 MB, less than 91.11% of C# online submissions for Game of Life.

public class Solution {
    public void GameOfLife(int[][] board) {
        int rows = board.Length;
        int cols = board[0].Length;
        int counter = 0;
        SortedDictionary<int,int> myDic = new SortedDictionary<int,int>();
        for(int i = 0; i<rows; i++)
        {
            for(int j = 0; j<cols; j++)
            {
                int nei = j +1 < cols ? board[i][j+1]: 0;
                nei += j - 1 >= 0 ? board[i][j-1] : 0;
                nei += i + 1 < rows ? board[i+1][j] : 0;
                nei += i - 1 >= 0 ? board[i-1][j] : 0;
                nei += j + 1 <cols && i+1 <rows ? board[i+1][j+1] : 0;
                nei += j + 1 <cols && i-1 >= 0 ? board[i-1][j+1] : 0;
                nei += j - 1 >= 0 && i+1 <rows ? board[i+1][j-1] : 0;
                nei += j - 1 >= 0 && i-1 >= 0 ? board[i-1][j-1] : 0;
                if(board[i][j] == 0 && nei == 3)
                {
                    myDic.Add(counter,1);
                }
                else if(board[i][j] == 1 && (nei == 2 || nei == 3))
                {
                    myDic.Add(counter,1);
                }
                else if(board[i][j] == 1 && (nei < 2 || nei > 3))
                {
                    myDic.Add(counter,0);
                }
                else
                {
                    myDic.Add(counter,board[i][j]);
                }
                counter++;
            }
        }
        counter = 0;
        for(int i = 0; i<rows; i++)
        {
            for(int j = 0; j<cols; j++)
            {
                board[i][j] = myDic[counter];
                counter++;
            }
        }
    }
}
