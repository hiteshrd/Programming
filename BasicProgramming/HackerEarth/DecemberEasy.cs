using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming.HackerEarth
{
    public class DecemberEasy
    {
        public void Paintwalls()
        {
            int tc = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < tc; i++)
            {
                int[] nmk = Array.ConvertAll<string, int>(Console.ReadLine().Split(), a => Convert.ToInt32(a));
                int[][] arr;
                if (nmk[2] > nmk[0] && nmk[2] > nmk[1])
                {
                    Console.WriteLine("-1");
                    return;
                }
                //int
            }
        }
    }
}
