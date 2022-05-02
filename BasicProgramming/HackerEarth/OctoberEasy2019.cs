using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming.HackerEarth
{
    public class OctoberEasy2019
    {
        public void RecyclingMachine()
        {
            int tc = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < tc; i++)
            {
                long output = 0;
                long[] bottles = Array.ConvertAll(Console.ReadLine().Split(' '), a => Convert.ToInt64(a));
                while(bottles[0] > bottles[1])
                {
                    long filledBootle = bottles[0] / bottles[1];
                    output += filledBootle;
                }
            }
        }
    }
}
