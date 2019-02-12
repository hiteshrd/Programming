using System;

namespace BasicProgramming
{
    public class Staircase
    {
        public void PrintStaircase()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string(' ', n - i) + new string('#', i));
            }
        }
    }
}