using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming.HackerEarth
{
    public class AprilCircuits
    {
        private char[,] _grid;
        public void GridPhrase()
        {
            int[] arr = Array.ConvertAll<string, int>(Console.ReadLine().Split(), Convert.ToInt32);
            _grid = new char[arr[0],arr[1]];
            for (int i = 0; i < arr[0]; i++)
            {
                char[] arrVal = Console.ReadLine().ToCharArray();
                for (int j = 0; j < arr[1]; j++)
                {
                    _grid[i, j] = arrVal[j];
                }
            }

            Console.WriteLine(PatternSearch("saba"));
        }

        // This function searches in all 8-direction from point 
        // (row, col) in grid[][] 
        private bool Search2D(int R, int C, int row, int col, string word)
        {
            // For searching in all 8 direction 
            int[] x = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] y = { -1, 0, 1, -1, 1, -1, 0, 1 };
            // If first character of word doesn't match with 
            // given starting point in grid. 
            if (_grid[row,col] != word[0])
                return false;

            int len = word.Length;

            // Search word in all 8 directions starting from (row,col) 
            for (int dir = 0; dir < 8; dir++)
            {
                // Initialize starting point for current direction 
                int k, rd = row + x[dir], cd = col + y[dir];

                // First character is already checked, match remaining 
                // characters 
                for (k = 1; k < len; k++)
                {
                    // If out of bound break 
                    if (rd >= R || rd < 0 || cd >= C || cd < 0)
                        break;

                    // If not matched,  break 
                    if (_grid[rd,cd] != word[k])
                        break;

                    //  Moving in particular direction 
                    rd += x[dir];
                    cd += y[dir];
                }

                // If all character matched, then value of must 
                // be equal to length of word 
                if (k == len)
                    return true;
            }
            return false;
        }

        //  Searches given word in a given matrix in all 8 directions 
        int PatternSearch(string word)
        {
            List<string> patternsFound = new List<string>();
            int R = _grid.GetLength(0);
            int C = _grid.GetLength(1);
            // Consider every point as starting point and search 
            // given word 
            for (int row = 0; row < R; row++)
            for (int col = 0; col < C; col++)
                if (Search2D(R, C, row, col, word))
                    patternsFound.Add(row + "," + col);
            return patternsFound.Count;
        }

        public void DivideMaximize()
        {
            int[] nk = Array.ConvertAll<string, int>(Console.ReadLine().Split(), Convert.ToInt32);
            int[] arr = Array.ConvertAll<string, int>(Console.ReadLine().Split(), Convert.ToInt32);
            var dict = new Dictionary<int, int>();

            foreach (var value in arr)
            {
                if (dict.ContainsKey(value))
                    dict[value]++;
                else
                    dict[value] = 1;
            }
            Dictionary<int, int> a = new Dictionary<int, int>();
            Dictionary<int, int> b = new Dictionary<int, int>();
            Dictionary<int, int> c = new Dictionary<int, int>();
            for (int i = 0; i < arr.Count(); i++)
            {
                a.Add(i, arr[i]);
            }

            var aDistinct = a.Distinct().ToDictionary(l => l.Key, l => l.Value);

            //dict.Where(a=>a.Value > 1).ToDictionary(l => l.Key, l => l.Value);

            //var aSorted = a.OrderBy(k => k.Value).ToDictionary(l=>l.Key, l=>l.Value);
            for (int i = 0; i < 2*nk[0] - 2; i = i+2)
            {
                if (a[i] < a[i])
                {
                    b.Add(i, a[i]);
                }
                else if(a[i] == a[i])
                {
                    b.Add(i, a[i]);
                }
                else
                {
                    c.Add(i, a[i + 1]);
                }
                
                //b.Add(val.Key, val.Value);
            }
            foreach (KeyValuePair<int, int> val in a.OrderBy(k => k.Key))
            {
            }
            for (int i = 0; i < 2*nk[0]; i++)
            {
                

                if(i%2 == 0)
                {
                    b.Add(a[i], i);
                }
                else
                {
                    c.Add(a[i],i);
                }
                int bIndex = 0;
                if(b.TryGetValue(i,out bIndex))
                {

                }

            }
        }
    }
}
