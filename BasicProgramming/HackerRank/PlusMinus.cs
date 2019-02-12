using System;

namespace BasicProgramming
{
    public class PlusMinus
    {
        public void FindFractions()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            decimal pos = 0, neg = 0, zero = 0;
            foreach (var val in arr)
            {
                if (val > 0)
                {
                    pos++;
                }
                else if (val < 0)
                {
                    neg++;
                }
                else
                {
                    zero++;
                }
            }

            Console.WriteLine(Math.Round(pos / n, 6));
            Console.WriteLine(Math.Round(neg / n, 6));
            Console.WriteLine(Math.Round(zero / n, 6));
        }
    }
}