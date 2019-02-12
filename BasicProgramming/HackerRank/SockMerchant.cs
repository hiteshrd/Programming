using System;
using System.Linq;

namespace BasicProgramming
{
    public class SockMerchant
    {
        public void FindPairs()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
                ;
            int result = 0;
            Array.Sort(ar);
            for (int i = 0; i < ar.Length-1; i++)
            {
                if (ar[i] == ar[i + 1])
                {
                    result++;
                    i++;
                }
            }

            Console.WriteLine(result);
        }
    }
}