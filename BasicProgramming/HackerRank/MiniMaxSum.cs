using System;

namespace BasicProgramming
{
    public class MiniMaxSum
    {
        public void FindMiniMaxSum()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            Array.Sort(arr);
            long max = 0, min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    min += arr[i];
                }
                else if (i == arr.Length - 1)
                {
                    max += arr[i];
                }
                else
                {
                    min += arr[i];
                    max += arr[i];
                }
            }

            Console.WriteLine(min + " " + max);
        }
    }
}