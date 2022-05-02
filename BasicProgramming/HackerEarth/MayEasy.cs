using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming.HackerEarth
{
    public class MayEasy
    {
        public void GoodNumbers()
        {
            var tc = Convert.ToInt32(Console.ReadLine());
            List<long> lstoutput = new List<long>();
            for (int i = 0; i < tc; i++)
            {
                var N = Convert.ToInt32(Console.ReadLine());
                long output = 0;
                if (N > 1 && N < 6)
                {
                    output = 1;
                }
                else
                {
                    output = 1;
                    for (int j = 6; j < N; j += 4)
                    {
                        output++;
                    }
                }
                lstoutput.Add(output);
            }
            lstoutput.ForEach(a => Console.WriteLine(a));
        }
    }
}
