using System;

namespace BasicProgramming
{
    public class BirthdayCakeCandles
    {
        public void FindCandles()
        {

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
                ;
            int result = 1;

            Array.Sort(ar);
            for (int i = ar.Length -1; i >0; i--)
            {
                if (ar[i] == ar[i - 1])
                {
                    result++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}