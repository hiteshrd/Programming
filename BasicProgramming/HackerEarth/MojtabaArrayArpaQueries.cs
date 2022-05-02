using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming.HackerEarth
{
    public class MojtabaArrayArpaQueries
    {
        //public void FindMojtabaArrayArpaQueries()
        //{
        //    long[] nkq = Array.ConvertAll<string, long>(Console.ReadLine().Split(' '), Convert.ToInt64);
        //    long[] arr = Array.ConvertAll<string, long>(Console.ReadLine().Split(' '), Convert.ToInt64);
        //    long k = nkq[1];
        //    List<int> output = new List<int>() ;
        //    for (int i = 0; i < nkq[2]; i++)
        //    {
        //        int[] lr = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), Convert.ToInt32);
        //        if (lr[1] - lr[0] > 1)
        //        {
        //            for (int l = 2; l <= lr[1] - lr[0]; l++)
        //            {
        //                for (int j = lr[0] + 1; j <= lr[1]-1; j++)
        //                {
        //                    long prod = 1;
        //                    for (int m = 0; m < l; m++)
        //                    {
        //                        prod = prod * arr[lr[0]];
        //                    }

        //                    output.Add(arr.Aggregate(prod,
        //                        (current, next) => k % (current * next) == 0 ? l : -1, b => b.GetHashCode()));
        //                }
        //            }
        //        }
        //        else
        //        {
        //            output.Add(-1);
        //        }
        //    }
        //    output.ForEach(a => Console.Write("{0}\n", a));
        //}
        public void DOPermutations()
        {
            int tc = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < tc; j++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), Convert.ToInt32);
                int[] arrO = new int[n];
                arrO = arr;
                int output = 0;
                while (!isSorted(arr) && output != -1)
                {
                    if (arrO == arr && output != 0)
                    {
                        output = -1;
                    }
                    else
                    {
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (i < arr.Length - 1)
                                arr[i] = arr[i + 1];
                            else
                                arr[i] = arr[0];
                        }

                        output++;
                    }
                }
                Console.WriteLine(output == 0 ? -1 : output);
            }
        }
        bool isSorted(int[] a)
        {
            int i = a.Length - 1;
            if (i <= 0) return true;
            if ((i & 1) > 0) { if (a[i] < a[i - 1]) return false; i--; }
            for (int ai = a[i]; i > 0; i -= 2)
                if (ai < (ai = a[i - 1]) || ai < (ai = a[i - 2])) return false;
            return a[0] <= a[1];
        }
    }
}
