public class Solution {
    public IList<IList<string>> SolveNQueens(int n) {
        int[] queens = new int[n];
        List<IList<string>> result = new List<IList<string>>();
        for(int i = 0; i<n;i++)
        {
            queens[i] = Int32.MaxValue;
        }
        int current = 0;
        while(current >= 0)
        {
            if(queens[current] == n)
            {
                queens[current] = Int32.MaxValue;
                current--;
                continue;
            }
            else if(queens[current] == Int32.MaxValue)
            {
                queens[current] = 0;
            }
            else
            {
                queens[current]++;
            }
            while(queens[current] < n)
            {
                if(IsValid(queens))
                {
                    if(current == n-1)
                    {
                        result.Add(GetQueens(queens));
                    }
                    else
                    {
                        current++;
                        break;
                    }
                }
                queens[current]++;
            }
        }
        return result;
    }
    private bool IsValid(int[] queens)
    {
        int count = queens.Length-1;
        while(queens[count] >= queens.Length)
        {
            count--;
        }
        for(int i = 0; i<count;i++)
        {
            if(queens[i] == queens[count] || queens[i] + i == queens[count] + count || queens[i] -i == queens[count] - count)
            {
                return false;
            }
        }
        return true;
    }
    private string[] GetQueens(int[] queens)
    {
        char[][] board = new char[queens.Length][];
        string[] result = new string[queens.Length];
        for(int i =0; i< queens.Length; i++)
        {
            for(int j = 0; j<queens.Length; j++)
            {
                if(board[i] == null)
                {
                    board[i] = new char[queens.Length];
                }
                board[i][j] = queens[i] == j?  'Q':'.';                
            }
            result[i] = new string(board[i]);
        }
        return result;
    }
}
